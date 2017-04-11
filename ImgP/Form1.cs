

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgP
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Bitmap gray;

        double[,] gdata;
        int[] hist = new int[256];
        float[] histcum = new float[256];
        int[] histEq = new int[256];
        int min;
        int max;
        double hh, tt;
        int stps;
        bool loaded = false;
        string lastop;
        string fname;
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (bmp != null) bmp.Dispose();
                if (gray != null) gray.Dispose();
                bmp = new Bitmap(ofd.FileName.ToString());
                fname = ofd.FileName.ToString();
                gray = grayscale(bmp);
                img_main.Image = gray;
                img_main.Refresh();
                hist = new int[256];
                histEq = new int[256];
                histcum = new float[256];
                loaded = true;
                img_hist.BackColor = Color.White;
                calcHist();
                drawHist(hist);
                lastop = "Original";
            }
            img_main.Select();
            ofd.Dispose();
        }

        private void redraw()
        {
            int v;
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    v = (int)(Math.Min(255, Math.Max(0, gdata[x, y])));
                    gray.SetPixel(x, y, Color.FromArgb(v, v, v));
                }
            calcHist();
            drawHist(hist);
            img_main.Image = gray;
            img_main.Refresh();
        }

        private Bitmap BmpFromData(double[,] data)
        {
            Bitmap bmp = new Bitmap(gray.Width, gray.Height);
            int v;
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    v = (int)(Math.Min(255, Math.Max(0, data[x, y])));
                    bmp.SetPixel(x, y, Color.FromArgb(v, v, v));
                }
            return bmp;
        }

        private Bitmap BmpFromData(double[,] data, double scale)
        {
            Bitmap bmp = new Bitmap(gray.Width, gray.Height);
            int v;
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    v = (int)(Math.Min(255, Math.Max(0, scale * data[x, y])));
                    bmp.SetPixel(x, y, Color.FromArgb(v, v, v));
                }
            return bmp;
        }

        private Bitmap grayscale(Bitmap original)
        {
            Color c;
            int val;
            Bitmap g = new Bitmap(original.Width, original.Height);
            gdata = new double[g.Width, g.Height];
            for (int x = 0; x < original.Width; x++)
                for (int y = 0; y < original.Height; y++)
                {
                    c = original.GetPixel(x, y);
                    val = Math.Min(255, (c.R + c.G + c.B) / 3);
                    g.SetPixel(x, y, Color.FromArgb(val, val, val));
                    gdata[x, y] = val;
                }
            return g;
        }



        private double[,] convolve(double[,] cm, int rad)
        {
            double[,] r = new double[gray.Width, gray.Height];
            int xx, yy;
            double v;
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {

                    v = 0;
                    for (int i = 0; i <= 2 * rad; i++)
                        for (int j = 0; j <= 2 * rad; j++)
                        {
                            xx = x + i - rad;
                            yy = y + j - rad;
                            if (xx < 0 || xx > gray.Width - 1) xx = x - i + rad;
                            if (yy < 0 || yy > gray.Height - 1) yy = y - j + rad;

                            if (cm[i, j] != 0)
                                v += (cm[i, j] * gdata[xx, yy]);
                            r[x, y] = (Math.Min(255, Math.Max(0, v)));
                        }
                }
            return r;
        }
        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                gray = grayscale(bmp);
                redraw();
                lastop = "Original";
            }
        }

        #region HIST_OPS
        private void calcHist()
        {
            for (int i = 0; i < 256; i++) hist[i] = 0;       //vypocet hist
            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    hist[(int)gdata[x, y]]++;
                }

            int norm = gray.Width * gray.Height;
            int sum = 0;

            for (int i = 0; i < 256; i++)
            {     //vypocet kumul.hist
                sum += hist[i];
                histcum[i] = (float)sum;
            }

            lastop = "Cumulative";    //predtym, ako sa znormuje, zapis kumulativny hist do histCumulative.txt
            writeHist(histcum);

            for (int i = 0; i < 256; i++)          //normuj
            {
                histcum[i] = (float)histcum[i] / norm;
            }
            for (int i = 0; i < 256; i++) histEq[i] = (int)(255 * histcum[i] + 0.5F);
            setminmax();
        }

        private void drawHist(int[] hist)
        {
            Bitmap histimg = new Bitmap(256, 256);
            Graphics gfx = Graphics.FromImage(histimg);
            float scale = 1.0F;
            int maxval = 0;
            for (int i = 0; i < 256; i++) if (hist[i] > maxval) maxval = hist[i];
            scale = 256.0F / maxval;
            gfx.Clear(Color.White);
            for (int i = 0; i < 256; i++)
            {
                gfx.FillRectangle(Brushes.Black, i, 256 - hist[i] * scale, 1, hist[i] * scale);
            }
            img_hist.Image = histimg;
            img_hist.Refresh();
            gfx.Dispose();
        }

        private void writeHist(int[] hist)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("hist" + lastop + ".txt");
            for (int i = 0; i < 256; i++) file.WriteLine(Convert.ToString(i) + " : " + Convert.ToString(hist[i]));
            file.Close();
        }
        private void writeHist(float[] hist)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("hist" + lastop + ".txt");
            for (int i = 0; i < 256; i++) file.WriteLine(Convert.ToString(i) + " : " + Convert.ToString(hist[i]));
            file.Close();
        }

        private void setminmax()
        {
            for (int i = 0; i < 256; i++) if (hist[i] != 0) max = i;
            for (int i = 255; i >= 0; i--) if (hist[i] != 0) min = i;
            minlabel.Text = min.ToString();
            maxlabel.Text = max.ToString();
        }

        private void fSHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                for (int x = 0; x < gray.Width; x++)
                    for (int y = 0; y < gray.Height; y++)
                    {
                        gdata[x, y] = Math.Max(0, Math.Min(255, (int)(255.0F / (max - min) * (gdata[x, y] - min))));
                    }
                redraw();
                lastop = "FHSH";
                writeHist(hist);
            }
        }

        private void equalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                for (int x = 0; x < gray.Width; x++)
                    for (int y = 0; y < gray.Height; y++)
                    {
                        gdata[x, y] = histEq[(int)gdata[x, y]];
                    }
                redraw();
                lastop = "Equalize";
                writeHist(hist);
            }
        }

        private void writetxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeHist(hist);
        }
        #endregion
        #region BLUR


        private void uniform3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 1.0/9, 1.0/9, 1.0/9 },
                  { 1.0/9, 1.0/9, 1.0/9 },
                  { 1.0/9, 1.0/9, 1.0/9 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "Blur3x3";
            }
        }
        private void diamond13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double v = 1.0 / 13;
                double[,] cm = new double[,] {
                  { 0, 0, v,0,0 },
                  { 0, v, v,v,0 },
                  { v, v,v,v,v },
                  { 0,v,v,v,0 },
                  { 0,0,v,0,0 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "Blur5x5";
            }
        }
        #endregion
        #region SHARPEN

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 0, -1, 0 },
                  { -1, 5, -1 },
                  { 0, -1, 0 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "Shapen3x3";
            }
        }
        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double a = -1.0 / 8, b = 2.0 / 8, c = 1.0;
                double[,] cm = new double[,] {
                  { a, a, a,a,a },
                  { a, b, b,b,a },
                  { a, b,c,b,a },
                  { a, b, b,b,a },
                 { a, a, a,a,a }};
                gdata = convolve(cm, 2);
                redraw();
                lastop = "Shapen5x5";
            }
        }
        #endregion
        #region EDGE DETECT
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 0, 0, 0,0,0 },
                  { 0, 0, 0,0,0 },
                  { -1, -1,4,-1,-1 },
                  { 0,0,0,0,0 },
                  { 0,0,0,0,0 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "EdgeHorizontal";
            }
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 0, 0, 0,0,-1 },
                  { 0, 0, 0,-2,0 },
                  { 0, 0,6,0,0 },
                  { 0,-2,0,0,0 },
                  { -1,0,0,0,0 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "EdgeDiagonal";
            }
        }
        private void laplace4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 0, 1, 0 },
                  { 1, -4, 1 },
                  { 0, 1, 0 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "EdgeLaplace4";
            }
        }
        private void laplace8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { 1, 1, 1 },
                  { 1, -8, 1 },
                  { 1, 1, 1 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "EdgeLaplace8";
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { -1, -2, -1 },
                  { 0,0, 0 },
                  { 1, 2, 1 }
                   };
                gdata = convolve(cm, 1);
                cm = new double[,] {
                  { -1, 0, 1 },
                  { -2,0, 2 },
                  { -1, 0, 1 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "EdgeSobel";
            }
        }


        #endregion
        #region EMBOSS
        private void x3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { -2, -1, 0 },
                  { -1, 1, 1 },
                  { 0, 1, 2 }
                   };
                gdata = convolve(cm, 1);
                redraw();
                lastop = "Emboss3x3";
            }
        }

        private void x5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                double[,] cm = new double[,] {
                  { -1,-1, -1,-1,0 },
                  { -1, -1, -1,0,1 },
                  { -1, -1,0,1,1 },
                  { -1,0,1,1,1 },
                  { 0,1,1,1,1 } };
                gdata = convolve(cm, 2);
                redraw();
                lastop = "Emboss5x5";
            }
        }

        #endregion

        #region NUM HEAT FLUX
        void thermalExp(int steps, double t, double h)
        {
            //steps
            //t time step
            //h space step
            double[,] gold = new double[gray.Width, gray.Height];

            double left, right, up, down, kmp = t / (h * h);
            int nx = gray.Width, ny = gray.Height;

            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    gold[x, y] = gdata[x, y];
                }

            for (int i = 0; i < steps; i++)
            {

                for (int x = 0; x < nx; x++)
                    for (int y = 0; y < ny; y++)
                    {
                        if (x == 0) left = gold[x + 1, y];
                        else left = gold[x - 1, y];
                        if (y == 0) up = gold[x, y + 1];
                        else up = gold[x, y - 1];
                        if (x == nx - 1) right = gold[x - 1, y];
                        else right = gold[x + 1, y];
                        if (y == ny - 1) down = gold[x, y - 1];
                        else down = gold[x, y + 1];

                        gdata[x, y] = ((1 - 4 * kmp) * gdata[x, y] + kmp * (left + right + up + down));

                    }

                gray = BmpFromData(gdata);
                gray.Save(fname + "_step" + i + ".bmp");
                img_main.Image = gray;
                img_main.Refresh();

                for (int x = 0; x < gray.Width; x++)
                    for (int y = 0; y < gray.Height; y++)
                    {
                        gold[x, y] = gdata[x, y];
                    }
            }
        }

        void thermalImp(int steps, double t, double h, double tol, double omg, int iter)
        {
            double res, rloc, yy = 0;
            int i;

            double[,] gold = new double[gray.Width, gray.Height];
            double[,] gp = new double[gray.Width, gray.Height];
            double left, right, up, down, kmp = t / (h * h);
            int nx = gray.Width, ny = gray.Height;
            string vypis;

            System.IO.StreamWriter file = new System.IO.StreamWriter(fname + "_residuals.txt");

            for (int k = 0; k < steps; k++)
            {
                res = 1000;
                i = 0;

                for (int x = 0; x < nx; x++)
                    for (int y = 0; y < ny; y++)
                    {
                        gp[x, y] = gdata[x, y];
                    }

                while (i < iter && res > tol)
                {


                    for (int x = 0; x < nx; x++)
                        for (int y = 0; y < ny; y++)
                        {
                            if (x == 0) left = gdata[x + 1, y];
                            else left = gdata[x - 1, y];
                            if (y == 0) up = gdata[x, y + 1];
                            else up = gdata[x, y - 1];
                            if (x == nx - 1) right = gdata[x - 1, y];
                            else right = gdata[x + 1, y];
                            if (y == ny - 1) down = gdata[x, y - 1];
                            else down = gdata[x, y + 1];

                            yy = (gp[x, y] + kmp * (left + right + up + down)) / (1 + 4 * kmp);
                            gdata[x, y] = (gdata[x, y] + omg * (yy - gdata[x, y]));

                        }
                    res = 0;
                    for (int x = 0; x < nx; x++)
                    {
                        for (int y = 0; y < ny; y++)
                        {

                            if (x == 0) left = gdata[x + 1, y];
                            else left = gdata[x - 1, y];
                            if (y == 0) up = gdata[x, y + 1];
                            else up = gdata[x, y - 1];
                            if (x == nx - 1) right = gdata[x - 1, y];
                            else right = gdata[x + 1, y];
                            if (y == ny - 1) down = gdata[x, y - 1];
                            else down = gdata[x, y + 1];

                            rloc = (1 + 4 * kmp) * gdata[x, y] - kmp * (left + up + right + down) - gp[x, y];
                            res += rloc * rloc;
                        }
                    }
                    res = Math.Sqrt(res);
                    res /= (nx * ny);

                    i++;
                    vypis = "krok " + Convert.ToString(k) + " | iteracia " + Convert.ToString(i) + " : " + Convert.ToString(res);
                    file.WriteLine(vypis);
                    txtlog.Text = vypis;
                    txtlog.Refresh();
                }
                gray = BmpFromData(gdata);
                gray.Save(fname + "_step" + k + ".bmp");
                img_main.Image = gray;
                img_main.Refresh();

            }
            file.Close();
        }
        #endregion

        #region NUM PERONA-MALIK
        void PMExp(int steps, double t, double h, double K)
        {
            //steps
            //t time step
            //h space step
            double[,] gold = new double[gray.Width, gray.Height];
            double[,] gsig = new double[gray.Width, gray.Height];
            int e, w, s, n;
            double left, right, up, down, kmp = t / (h * h);
            double ge, gw, gs, gn, g1, g2;

            int nx = gray.Width, ny = gray.Height;

            for (int x = 0; x < gray.Width; x++)
                for (int y = 0; y < gray.Height; y++)
                {
                    gold[x, y] = gdata[x, y];
                    gsig[x, y] = gold[x, y];
                }

            for (int i = 0; i < steps; i++)
            {

                for (int x = 0; x < nx; x++)
                    for (int y = 0; y < ny; y++)
                    {
                        if (x == 0) w = x + 1;
                        else w = x - 1;
                        if (y == 0) n = y + 1;
                        else n = y - 1;
                        if (x == nx - 1) e = x - 1;
                        else e = x + 1;
                        if (y == ny - 1) s = y - 1;
                        else s = y + 1;

                        left = gold[w, y];
                        up = gold[x, n];
                        down = gold[x, s];
                        right = gold[e, y];
                        gsig[x, y] = 1 / 4 * (left + right + up + down);
                    }

                for (int x = 0; x < nx; x++)
                    for (int y = 0; y < ny; y++)
                    {
                        if (x == 0) w = x + 1;
                        else w = x - 1;
                        if (y == 0) n = y + 1;
                        else n = y - 1;
                        if (x == nx - 1) e = x - 1;
                        else e = x + 1;
                        if (y == ny - 1) s = y - 1;
                        else s = y + 1;

                        left = gold[w, y];

                        g1 = 0.25 * (gold[x, s] + gold[w, s] - gold[x, n] - gold[w, n]) / h;
                        g2 = (gsig[x, y] - gsig[w, y]) / h;
                        gw = Math.Sqrt(g1 * g1 + g2 * g2);
                        gw = 1 / (1 + K * gw * gw);

                        up = gold[x, n];

                        g1 = 0.25 * (gold[w, y] + gold[w, n] - gold[e, y] - gold[e, n]) / h;
                        g2 = (gsig[x, y] - gsig[x, n]) / h;
                        gn = Math.Sqrt(g1 * g1 + g2 * g2);
                        gn = 1 / (1 + K * gn * gn);

                        down = gold[x, s];

                        g1 = 0.25 * (gold[w, y] + gold[w, s] - gold[e, y] - gold[e, s]) / h;
                        g2 = (gsig[x, s] - gsig[x, y]) / h;
                        gs = Math.Sqrt(g1 * g1 + g2 * g2);
                        gs = 1 / (1 + K * gs * gs);

                        right = gold[e, y];

                        g1 = 0.25 * (gold[x, n] + gold[e, n] - gold[x, s] - gold[e, s]) / h;
                        g2 = (gsig[x, y] - gsig[e, y]);
                        ge = Math.Sqrt(g1 * g1 + g2 * g2);
                        ge = 1 / (1 + K * ge * ge);

                        if (pm.Checked) gdata[x, y] = ((1 - kmp * (gw + gn + ge + gs)) * gold[x, y] + kmp * (gw * left + ge * right + gn * up + gs * down));
                        else if (pmedge.Checked) gdata[x, y] = 1 / 4 * (gw + gn + ge + gs);
                    }

                gray = BmpFromData(gdata);
                gray.Save(fname + "_step" + i + ".bmp");
                img_main.Image = gray;
                img_main.Refresh();
                txtlog.Text = "_step" + i;
                txtlog.Refresh();
                for (int x = 0; x < gray.Width; x++)
                    for (int y = 0; y < gray.Height; y++)
                    {
                        gold[x, y] = gdata[x, y];
                        gsig[x, y] = gold[x, y];
                    }
            }
        }

        void PMImp(int steps, double t, double h, double tol, double omg, int iter, double K)
        {
            double res, rloc, yy = 0;
            int i;

            double[,] gold = new double[gray.Width, gray.Height];
            double left, right, up, down, kmp = t / (h * h);
            int nx = gray.Width, ny = gray.Height;
            string vypis;

            System.IO.StreamWriter file = new System.IO.StreamWriter(fname + "_residuals.txt");

            for (int k = 0; k < steps; k++)
            {
                res = 1000;
                i = 0;
                while (i < iter && res > tol * tol)
                {
                    res = 0;
                    for (int x = 0; x < nx; x++)
                        for (int y = 0; y < ny; y++)
                        {
                            gold[x, y] = gdata[x, y];
                        }

                    for (int x = 0; x < nx; x++)
                        for (int y = 0; y < ny; y++)
                        {
                            if (x == 0) left = gdata[x + 1, y];
                            else left = gdata[x - 1, y];
                            if (y == 0) up = gdata[x, y + 1];
                            else up = gdata[x, y - 1];
                            if (x == nx - 1) right = gdata[x - 1, y];
                            else right = gdata[x + 1, y];
                            if (y == ny - 1) down = gdata[x, y - 1];
                            else down = gdata[x, y + 1];

                            yy = (gold[x, y] + kmp * (left + right + up + down)) / (1 + 4 * kmp);
                            gdata[x, y] = (int)(gdata[x, y] + omg * (yy - gdata[x, y]));


                        }

                    for (int x = 0; x < nx; x++)
                        for (int y = 0; y < ny; y++)
                        {

                            if (x == 0) left = gdata[x + 1, y];
                            else left = gdata[x - 1, y];
                            if (y == 0) up = gdata[x, y + 1];
                            else up = gdata[x, y - 1];
                            if (x == nx - 1) right = gdata[x - 1, y];
                            else right = gdata[x + 1, y];
                            if (y == ny - 1) down = gdata[x, y - 1];
                            else down = gdata[x, y + 1];

                            rloc = (1 + 4 * kmp) * gdata[x, y] - kmp * (left + right + up + down) - gold[x, y];
                            res += rloc * rloc;
                        }
                }
                res = res / (nx * nx * ny * ny);

                i++;
                vypis = "krok " + Convert.ToString(k) + " | iteracia " + Convert.ToString(i) + " : " + Convert.ToString(res);
                file.WriteLine(vypis);
                txtlog.Text = vypis;
                txtlog.Refresh();

                gray = BmpFromData(gdata);
                gray.Save(fname + "_step" + k + ".bmp");
                img_main.Image = gray;
                img_main.Refresh();
            }


        }
        #endregion

        private void calc_Click(object sender, EventArgs e)
        {
            stps = (int)numsteps.Value;
            tt = (double)numt.Value;
            hh = (double)numh.Value;

            if (hflux.Checked)
            {
                thermalExp(stps, tt, hh);
            }
            else if (pm.Checked || pmedge.Checked)
            {
                PMExp(stps, tt, hh, (double)numK.Value);
            }
        }

        private void hflux_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stps = (int)numsteps.Value;
            tt = (double)numt.Value;
            hh = (double)numh.Value;
            if (hflux.Checked)
            {
                thermalImp(stps, tt, hh, Math.Pow(10, (int)-numtol.Value), (double)numomg.Value, (int)numiter.Value);
            }
            else if (pm.Checked || pmedge.Checked)
            {
                PMImp(stps, tt, hh, Math.Pow(10, (int)-numtol.Value), (double)numomg.Value, (int)numiter.Value, (double)numK.Value);
            }
        }

    }
}
