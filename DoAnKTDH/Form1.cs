using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanKTDH
{
    public partial class Form1 : Form
    {
        int trangThaiNut;
        Graphics g;
        Point O = new Point(400, 280);
        Point p1 = new Point(400, 250), p2 = new Point(400, 75), p3 = new Point(525, 75);
        int a = 0, x = 0, a1 = 0, x1 = 0;
        int b = 0, t = 0, b1 = 0, t1 = 0;
        Boolean kt1 = true, kt2 = true;
        Boolean conLac5 = true;
        Boolean conLac1 = false;
        public Form1()
        {
            InitializeComponent();
            this.panel1.Height = 800;
            this.panel1.Width = 800;
            this.panel2.Height = 800;
            this.hinh1button2D.Enabled = false;
            this.hinh2button2D.Enabled = false;
            this.hinh3button2D.Enabled = false;
            this.hinh1button3D.Enabled = false;
            this.hinh2button3D.Enabled = false;
            this.hinh3Button3D.Enabled = false;
            this.panel4.Visible = false;
        }

        void veLuoi()
        {
            g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.LightGray);
            // vẽ lưới pixel
            for (int y = 0; y <= 800; y += 5)
            {
                g.DrawLine(p, 0, y, 800, y);
            }
            for (int x = 0; x <= 800; x += 5)
            {
                g.DrawLine(p, x, 0, x, 800);
            }
            // vẽ trục tọa độ 
            Pen pT = new Pen(Color.Black);
            g.DrawLine(pT, 0, 400, 800, 400);
            g.DrawLine(pT, 400, 0, 400, 800);

            Point p1 = new Point(400, 0);
            Point p2 = new Point(393, 17);
            Point p3 = new Point(407, 17);
            Point[] P1 = { p1, p2, p3 };
            g.FillPolygon(new SolidBrush(Color.Black), P1);

            Point p4 = new Point(800, 400);
            Point p5 = new Point(783, 393);
            Point p6 = new Point(783, 407);
            Point[] P2 = { p4, p5, p6 };
            g.FillPolygon(new SolidBrush(Color.Black), P2);

            System.Drawing.Font f = new System.Drawing.Font("Arial", 10);
            g.DrawString("0", f, new SolidBrush(Color.Black), new Point(385, 405));   //250->235
            g.DrawString("Y", f, new SolidBrush(Color.Black), new Point(410, 3));
            g.DrawString("X", f, new SolidBrush(Color.Black), new Point(785, 375));
            g.DrawString("80", f, new SolidBrush(Color.Black), new Point(780, 410));
            g.DrawString("80", f, new SolidBrush(Color.Black), new Point(370, 5));
            g.DrawString("-80", f, new SolidBrush(Color.Black), doiXungQuaOy(new Point(780 + 15, 410)));
            g.DrawString("-80", f, new SolidBrush(Color.Black), new Point(370, 780));


        }

        public void veLuoi3D()
        {
            g = panel1.CreateGraphics();
            Pen mypen = new Pen(Color.Black);
            Pen mypen1 = new Pen(Color.LightGray);
            int x = 800;
            int y = 800;
            for (int i = 0; i < x;)
            {
                g.DrawLine(mypen1, 0, i, x, i);
                i = i + 5;
            }
            for (int i = 0; i < x;)
            {
                g.DrawLine(mypen1, i, 0, i, y);
                i = i + 5;
            }
            g.DrawLine(mypen, 400, 0, 400, 400);
            g.DrawLine(mypen, 400, 400, 800, 400);
            g.DrawLine(mypen, 400, 400, 0, 800);

            Point p1 = new Point(400, 0);
            Point p2 = new Point(393, 17);
            Point p3 = new Point(407, 17);
            Point[] P1 = { p1, p2, p3 };
            g.FillPolygon(new SolidBrush(Color.Black), P1);

            Point p4 = new Point(800, 400);
            Point p5 = new Point(783, 393);
            Point p6 = new Point(783, 407);
            Point[] P2 = { p4, p5, p6 };
            g.FillPolygon(new SolidBrush(Color.Black), P2);

            Point p7 = new Point(0, 800);
            Point p8 = new Point(5, 785);
            Point p9 = new Point(16, 795);
            Point[] P3 = { p7, p8, p9 };
            g.FillPolygon(new SolidBrush(Color.Black), P3);

            System.Drawing.Font f = new System.Drawing.Font("Arial", 10);
            g.DrawString("Y", f, new SolidBrush(Color.Black), new Point(410, 3));
            g.DrawString("X", f, new SolidBrush(Color.Black), new Point(785, 375));
            g.DrawString("Z", f, new SolidBrush(Color.Black), new Point(15, 780));

        }

        void resetLabelToado()
        {
            label_toado1.Text = "---";
            label_toado1.BackColor = Color.FromArgb(224, 224, 224);
            label_toado2.Text = "---";
            label_toado3.Text = "---";
            label_toado4.Text = "---";
            label_toado4.BackColor = Color.FromArgb(224, 224, 224);
            label_toado5.Text = "---";
            label_toado6.Text = "---";
            label_toado7.Text = "---";
            label_toado7.BackColor = Color.FromArgb(224, 224, 224);
            label_toado8.Text = "---";
            label_toado9.Text = "---";
            label_toado10.Text = "---";
            label_toado10.BackColor = Color.FromArgb(224, 224, 224);
            label_toado11.Text = "---";
            label_toado12.Text = "---";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2D_Click(object sender, EventArgs e)
        {
            hinh1button2D.Enabled = true;
            hinh2button2D.Enabled = true;
            hinh3button2D.Enabled = true;
            //khi click vào vẽ 2D thì các button trong 3D sẽ bị vô hiệu hóa
            hinh1button3D.Enabled = false;
            hinh2button3D.Enabled = false;
            hinh3Button3D.Enabled = false;
            this.panel4.Visible = false;
            veLuoi();
        }

        private void button3D_Click(object sender, EventArgs e)
        {
            this.panel1.Refresh();
            veLuoi3D();
            hinh1button3D.Enabled = true;
            hinh2button3D.Enabled = true;
            hinh3Button3D.Enabled = true;
            //khi click vào vẽ 3D thì các button trong 2D sẽ bị vô hiệu hóa
            hinh1button2D.Enabled = false;
            hinh2button2D.Enabled = false;
            hinh3button2D.Enabled = false;
        }

        //=================Code hình 1 2D============================
        void veHCN(int x, int y, int height, int width, SolidBrush color)
        {
            g = this.panel1.CreateGraphics();
            g.FillRectangle(color, x - 2, y - 2, height * 5, width * 5);
        }

        void veMotDiem(int X, double a, SolidBrush color)
        {
            int Y = (int)a;
            g = this.panel1.CreateGraphics();
            g.FillRectangle(color, X - 2, Y - 2, 5, 5);
        }

        void veDuongThang(Point p1, Point p2, SolidBrush color)
        {
            Point p = new Point(), pe = new Point();
            int dx, dy, dx1, dy1, s1, s2;
            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;
            dx1 = Math.Abs(dx);
            dy1 = Math.Abs(dy);
            s1 = 2 * dy1 - dx1;
            s2 = 2 * dx1 - dy1;

            if (dy1 <= dx1)
            {
                if (dx >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.X = p2.X;
                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.X = p1.X;
                }
                veMotDiem(p.X, p.Y, color);
                for (int i = 0; p.X < pe.X; i++)
                {
                    p.X = p.X + 5;
                    if (s1 < 0) s1 = s1 + 2 * dy1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.Y = p.Y + 5;
                        else p.Y = p.Y - 5;
                        s1 = s1 + 2 * (dy1 - dx1);
                    }
                    veMotDiem(p.X, p.Y, color);
                }
            }

            else
            {
                if (dy >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.Y = p2.Y;

                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.Y = p1.Y;
                }
                veMotDiem(p.X, p.Y, color);
                for (int i = 0; p.Y < pe.Y; i++)
                {
                    p.Y = p.Y + 5;
                    if (s2 <= 0) s2 = s2 + 2 * dx1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.X = p.X + 5;
                        else p.X = p.X - 5;
                        s2 = s2 + 2 * (dx1 - dy1);
                    }
                    veMotDiem(p.X, p.Y, color);
                }
            }
        }

        void ve8Diem(int xc, int yc, int x, int y, SolidBrush color)
        {
            veMotDiem(x + xc, y + yc, color);
            veMotDiem(y + xc, x + yc, color);
            veMotDiem(-y + xc, x + yc, color);
            veMotDiem(-x + xc, y + yc, color);
            veMotDiem(-x + xc, -y + yc, color);
            veMotDiem(-y + xc, -x + yc, color);
            veMotDiem(y + xc, -x + yc, color);
            veMotDiem(x + xc, -y + yc, color);
        }

        void veDuongTron(int xt, int yt, int r, SolidBrush color)
        {
            int x, y, p;
            y = r * 5;
            x = 0;
            p = 3 - 2 * r;
            while (x <= y)
            {
                ve8Diem(xt, yt, x, y, color);
                if (p < 0)
                {
                    p += 4 * x + 6;
                }
                else
                {
                    p += 4 * (x - y) + 10;
                    y -= 5;
                }
                x += 5;
            }
        }
        void veTamGiac(Point p1, Point p2, Point p3, SolidBrush color)
        {
            veDuongThang(p1, p2, color);
            veDuongThang(p2, p3, color);
            veDuongThang(p1, p3, color);
        }

        void toTamGiac(Point p1, Point p2, Point p3, SolidBrush color)
        {
            Pen pen = new Pen(color);
            Brush brush = color;
            Point[] p = { p1, p2, p3 };
            g = this.panel1.CreateGraphics();
            g.DrawPolygon(pen, p);
            g.FillPolygon(brush, p);
        }

        Point quayMotDiem(Point Q, Point A, string gocquay) // quay điểm Q quanh điểm A bất kì
        {
            Point P = new Point();
            double temp = double.Parse(gocquay) * 3.1415926535897932384626433 / 180;
            P.X = (int)(Q.X * (double)Math.Cos(temp) + Q.Y * (-(double)Math.Sin(temp)) + (A.X * (1 - (double)Math.Cos(temp)) + A.Y * (double)Math.Sin(temp)));
            P.Y = (int)(Q.X * (double)Math.Sin(temp) + Q.Y * (double)Math.Cos(temp) + (A.Y * (1 - (double)Math.Cos(temp)) + A.X * -(double)Math.Sin(temp)));
            return P;
        }

        void veCanhChongChong(SolidBrush color1, SolidBrush color2, SolidBrush color3, SolidBrush color4)
        {
            panel3.Refresh();
            Point t1 = p1, t2 = p2, t3 = p3;
            veTamGiac(p1, p2, p3, color1);
            toTamGiac(p1, p2, p3, color1);
            label_toado1.BackColor = Color.Blue;
            label_toado1.Text = "TAM GIÁC MÀU XANH BIỂN";
            label_toado2.Text = "Đỉnh 1 (X = " + doiXsangx(t1.X) + "; Y = " + doiYsangy(t1.Y) + ")     Đỉnh 2 (X = " + doiXsangx(t2.X) + "; Y = " + doiYsangy(t2.Y) + ")";
            label_toado3.Text = "Đỉnh 3 (X = " + doiXsangx(t3.X) + "; Y = " + doiYsangy(t3.Y) + ")";

            t1 = quayMotDiem(p1, O, 90 + ""); t2 = quayMotDiem(p2, O, 90 + ""); t3 = quayMotDiem(p3, O, 90 + "");
            veTamGiac(t1, t2, t3, color2);
            toTamGiac(t1, t2, t3, color2);
            label_toado4.BackColor = Color.Green;
            label_toado4.Text = "TAM GIÁC MÀU XANH LÁ";
            label_toado5.Text = "Đỉnh 1 (X = " + doiXsangx(t1.X) + "; Y = " + doiYsangy(t1.Y) + ")     Đỉnh 2 (X = " + doiXsangx(t2.X) + "; Y = " + doiYsangy(t2.Y) + ")";
            label_toado6.Text = "Đỉnh 3 (X = " + doiXsangx(t3.X) + "; Y = " + doiYsangy(t3.Y) + ")";

            t1 = quayMotDiem(p1, O, 180 + ""); t2 = quayMotDiem(p2, O, 180 + ""); t3 = quayMotDiem(p3, O, 180 + "");
            veTamGiac(t1, t2, t3, color3);
            toTamGiac(t1, t2, t3, color3);
            label_toado7.BackColor = Color.Red;
            label_toado7.Text = "TAM GIÁC MÀU ĐỎ";
            label_toado8.Text = "Đỉnh 1 (X = " + doiXsangx(t1.X) + "; Y = " + doiYsangy(t1.Y) + ")     Đỉnh 2 (X = " + doiXsangx(t2.X) + "; Y = " + doiYsangy(t2.Y) + ")";
            label_toado9.Text = "Đỉnh 3 (X = " + doiXsangx(t3.X) + "; Y = " + doiYsangy(t3.Y) + ")";

            t1 = quayMotDiem(p1, O, 270 + ""); t2 = quayMotDiem(p2, O, 270 + ""); t3 = quayMotDiem(p3, O, 270 + "");
            veTamGiac(t1, t2, t3, color4);
            toTamGiac(t1, t2, t3, color4);
            label_toado10.BackColor = Color.Yellow;
            label_toado10.Text = "TAM GIÁC MÀU VÀNG";
            label_toado11.Text = "Đỉnh 1 (X = " + doiXsangx(t1.X) + "; Y = " + doiYsangy(t1.Y) + ")     Đỉnh 2 (X = " + doiXsangx(t2.X) + "; Y = " + doiYsangy(t2.Y) + ")";
            label_toado12.Text = "Đỉnh 3 (X = " + doiXsangx(t3.X) + "; Y = " + doiYsangy(t3.Y) + ")";
        }

        void veChongChong(SolidBrush color, SolidBrush color1, SolidBrush color2, SolidBrush color3, SolidBrush color4)
        {
            veHCN(390, 310, 5, 55, color);
            veDuongTron(400, 280, 5, color);
            veCanhChongChong(color1, color2, color3, color4);
        }

        void toHinhTron(int x, int y, int a, SolidBrush color)
        {
            Rectangle rect = new Rectangle(x, y, a, a);
            g = this.panel1.CreateGraphics();
            g.FillEllipse(color, rect);
        }

        void veDoremon(SolidBrush color1, SolidBrush color2, SolidBrush color3, SolidBrush color4)
        {
            toHinhTron(50, 580, 700, color3); // đầu ngoài
            veDuongTron(400, 930, 70, color1); // viền đầu ngoài

            toHinhTron(100, 630, 600, color2); // đầu trong

            toHinhTron(250, 595, 150, color2); // mắt trái
            veDuongTron(325, 670, 15, color1); // viền mắt trái

            toHinhTron(400, 595, 150, color2); // mắt phải
            veDuongTron(475, 670, 15, color1); // viền mắt phải

            veDuongThang(new Point(400, 720), new Point(400, 820), new SolidBrush(Color.Black));

            toHinhTron(375, 700, 50, color4); // vẽ mũi

            for (int i = 1; i <= 4; i++) veDuongTron(325, 675, i, color1); // con ngươi trái
            for (int i = 1; i <= 4; i++) veDuongTron(475, 675, i, color1); // con ngươi phải
        }
        //===========================================================

        //=================Code hình 2 2D============================
        void veMotDiem(int x, double a, Color color)
        {
            g = this.panel1.CreateGraphics();
            int y = (int)a;
            g.FillRectangle(new SolidBrush(color), x - 2, y - 2, 5, 5);
        }

        void ve8Diem(int xc, int yc, int x, int y, Color color)
        {
            veMotDiem(x + xc, y + yc, color);
            veMotDiem(y + xc, x + yc, color);
            veMotDiem(-y + xc, x + yc, color);
            veMotDiem(-x + xc, y + yc, color);
            veMotDiem(-x + xc, -y + yc, color);
            veMotDiem(-y + xc, -x + yc, color);
            veMotDiem(y + xc, -x + yc, color);
            veMotDiem(x + xc, -y + yc, color);
        }

        void veDuongTron(int xt, int yt, int r, Color color)
        {
            int x, y, p;
            y = r * 5;
            x = 0;
            p = 3 - 2 * r;
            while (x <= y)
            {
                ve8Diem(xt, yt, x, y, color);
                if (p < 0)
                {
                    p += 4 * x + 6;
                }
                else
                {
                    p += 4 * (x - y) + 10;
                    y -= 5;
                }
                x += 5;
            }
        }

        void veDuongThang(Point p1, Point p2, Color color)
        {
            Point p = new Point(), pe = new Point();
            int dx, dy, dx1, dy1, s1, s2;
            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;
            dx1 = Math.Abs(dx);
            dy1 = Math.Abs(dy);
            s1 = 2 * dy1 - dx1;
            s2 = 2 * dx1 - dy1;

            if (dy1 <= dx1)
            {
                if (dx >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.X = p2.X;
                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.X = p1.X;
                }
                veMotDiem(p.X, p.Y, color);
                for (int i = 0; p.X < pe.X; i++)
                {
                    p.X = p.X + 5;
                    if (s1 < 0) s1 = s1 + 2 * dy1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.Y = p.Y + 5;
                        else p.Y = p.Y - 5;
                        s1 = s1 + 2 * (dy1 - dx1);
                    }
                    veMotDiem(p.X, p.Y, color);
                }
            }

            else
            {
                if (dy >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.Y = p2.Y;

                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.Y = p1.Y;
                }
                veMotDiem(p.X, p.Y, color);
                for (int i = 0; p.Y < pe.Y; i++)
                {
                    p.Y = p.Y + 5;
                    if (s2 <= 0) s2 = s2 + 2 * dx1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.X = p.X + 5;
                        else p.X = p.X - 5;
                        s2 = s2 + 2 * (dx1 - dy1);
                    }
                    veMotDiem(p.X, p.Y, color);
                }
            }
        }

        void veNetDutMua(Point p1, Point p2, Color color)
        {
            int dem = 0;
            Point p = new Point(), pe = new Point();
            int dX, dY, dX1, dY1, s1, s2;
            dX = p2.X - p1.X;
            dY = p2.Y - p1.Y;
            dX1 = Math.Abs(dX);
            dY1 = Math.Abs(dY);
            s1 = 2 * dY1 - dX1;
            s2 = 2 * dX1 - dY1;

            if (dY1 <= dX1)
            {
                if (dX >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.X = p2.X;
                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.X = p1.X;
                }
                veMotDiem(p.X, p.Y, color); dem++;
                for (int i = 0; p.X < pe.X; i++)
                {
                    p.X = p.X + 5; //
                    if (s1 < 0) s1 = s1 + 2 * dY1;
                    else
                    {
                        if ((dX < 0 && dY < 0) || (dX > 0 && dY > 0)) p.Y = p.Y + 5; //
                        else p.Y = p.Y - 5; //
                        s1 = s1 + 2 * (dY1 - dX1);
                    }
                    if (dem <= 4)
                    {
                        veMotDiem(p.X, p.Y, color);
                        dem++;
                    }
                    else
                    {
                        dem++;
                        if (dem > 7)
                        {
                            dem = 0;
                        }
                    }
                }
            }
            else
            {
                if (dY >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.Y = p2.Y;

                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.Y = p1.Y;
                }
                veMotDiem(p.X, p.Y, color); dem++;
                for (int i = 0; p.Y < pe.Y; i++)
                {
                    p.Y = p.Y + 5; //
                    if (s2 <= 0) s2 = s2 + 2 * dX1;
                    else
                    {
                        if ((dX < 0 && dY < 0) || (dX > 0 && dY > 0)) p.X = p.X + 5; //
                        else p.X = p.X - 5; //
                        s2 = s2 + 2 * (dX1 - dY1);
                    }
                    if (dem <= 4)
                    {
                        veMotDiem(p.X, p.Y, color);
                        dem++;
                    }
                    else
                    {
                        dem++;
                        if (dem > 7)
                        {
                            dem = 0;
                        }
                    }
                }
            }
        }

        void veHinhChuNhat(Point p1, Point p2, Color color1, Color color2)
        {
            Point p3 = new Point(p1.X, p2.Y);
            Point p4 = new Point(p2.X, p1.Y);
            veDuongThang(p1, p4, color1);
            veDuongThang(p4, p2, color1);
            veDuongThang(p2, p3, color1);
            veDuongThang(p3, p1, color1);
            if ((p1.Y < p2.Y) && (p1.X < p2.X))
            {
                g.FillRectangle(new SolidBrush(color2), p1.X + 3, p1.Y + 3, p2.X - p1.X - 5, p2.Y - p1.Y - 5);
            }
            else if ((p2.Y < p1.Y) && (p2.X < p1.X))
            {
                g.FillRectangle(new SolidBrush(color2), p2.X + 3, p2.Y + 3, p1.X - p2.X - 5, p1.Y - p2.Y - 5);

            }
            else if ((p1.Y < p2.Y) && (p1.X > p2.X))
            {
                g.FillRectangle(new SolidBrush(color2), p4.X + 3, p4.Y + 3, p1.X - p4.X - 5, p3.Y - p1.Y - 5);

            }
            else if ((p1.Y > p2.Y) && (p1.X < p2.X))
            {
                g.FillRectangle(new SolidBrush(color2), p3.X + 3, p3.Y + 3, p2.X - p3.X - 5, p4.Y - p2.Y - 5);

            }
        }

        int doiXsangx(int X)
        {
            return (X - 400) / 5;
        }

        int doiYsangy(int Y)
        {
            return (400 - Y) / 5;
        }
        int doiXsangx(double X)
        {
            double x = (X - 400) / 5;
            return (int)x;
        }

        int doiYsangy(double Y)
        {
            double y = (400 - Y) / 5;
            return (int)y;
        }

        void veMay(Point m, Color color, Color cl)
        {
            g = this.panel1.CreateGraphics();

            panel3.Refresh();
            label_toado1.Text = "TỌA ĐỘ CỦA ĐÁM MÂY:";

            Rectangle rect1 = new Rectangle(m.X - 10 * 5 + 1, m.Y - 10 * 5 + 1, 10 * 10 - 2, 10 * 10 - 2);
            g.FillEllipse(new SolidBrush(cl), rect1);
            veDuongTron(m.X, m.Y, 10, color);
            if (doiXsangx(m.X) <= 80 && doiXsangx(m.X) >= -80)
            {
                label_toado2.Text = "Tâm hình tròn thứ 1 (" + "x = " + doiXsangx(m.X) + ", " + "y = " + doiYsangy(m.Y) + ")";
            }
            else label_toado2.Text = "Tâm hình tròn thứ 1";

            Rectangle rect2 = new Rectangle(m.X + 40 - 10 * 5 + 1, m.Y - 60 - 10 * 5 + 1, 10 * 10, 10 * 10);
            g.FillEllipse(new SolidBrush(cl), rect2);
            veDuongTron(m.X + 40, m.Y - 60, 10, color);
            if (doiXsangx(m.X + 40) <= 80 && doiXsangx(m.X + 40) >= -80)
            {
                label_toado3.Text = "Tâm hình tròn thứ 2 (" + "x = " + doiXsangx(m.X + 40) + ", " + "y = " + doiYsangy(m.Y - 60) + ")";
            }
            else label_toado3.Text = "Tâm hình tròn thứ 2";

            Rectangle rect3 = new Rectangle(m.X + 90 - 10 * 5, m.Y - 10 * 5, 10 * 10, 10 * 10);
            g.FillEllipse(new SolidBrush(cl), rect3);
            veDuongTron(m.X + 90, m.Y, 10, color);
            if (doiXsangx(m.X + 90) <= 80 && doiXsangx(m.X + 90) >= -80)
            {
                label_toado4.Text = "Tâm hình tròn thứ 3 (" + "x = " + doiXsangx(m.X + 90) + ", " + "y = " + doiYsangy(m.Y) + ")";
            }
            else label_toado4.Text = "Tâm hình tròn thứ 3";

            Rectangle rect4 = new Rectangle(m.X + 130 - 10 * 5, m.Y - 60 - 10 * 5, 10 * 10 + 1, 10 * 10 + 1);
            g.FillEllipse(new SolidBrush(cl), rect4);
            veDuongTron(m.X + 130, m.Y - 60, 10, color);
            if (doiXsangx(m.X + 130) <= 80 && doiXsangx(m.X + 130) >= -80)
            {
                label_toado5.Text = "Tâm hình tròn thứ 4 (" + "x = " + doiXsangx(m.X + 130) + ", " + "y = " + doiYsangy(m.Y - 60) + ")";
            }
            else label_toado5.Text = "Tâm hình tròn thứ 4";

            Rectangle rect5 = new Rectangle(m.X + 180 - 10 * 5, m.Y - 10 * 5, 10 * 10 + 1, 10 * 10 + 1);
            g.FillEllipse(new SolidBrush(cl), rect5);
            veDuongTron(m.X + 180, m.Y, 10, color);
            if (doiXsangx(m.X + 180) <= 80 && doiXsangx(m.X + 180) >= -80)
            {
                label_toado6.Text = "Tâm hình tròn thứ 5 (" + "x = " + doiXsangx(m.X + 180) + ", " + "y = " + doiYsangy(m.Y) + ")";
            }
            else label_toado6.Text = "Tâm hình tròn thứ 5";
        }

        void veNuoc(Point n1, Point n2, Color color)
        {
            veNetDutMua(n1, n2, color);
            veNetDutMua(new Point(n1.X + 50, n1.Y), new Point(n2.X + 50, n2.Y), color);
            veNetDutMua(new Point(n1.X + 100, n1.Y), new Point(n2.X + 100, n2.Y), color);
            veNetDutMua(new Point(n1.X + 150, n1.Y), new Point(n2.X + 150, n2.Y), color);
            veNetDutMua(new Point(n1.X + 200, n1.Y), new Point(n2.X + 200, n2.Y), color);
            veNetDutMua(new Point(n1.X + 250, n1.Y), new Point(n2.X + 250, n2.Y), color);
        }

        void veChau(Point c, Color color)
        {
            veHinhChuNhat(c, new Point(c.X + 180, c.Y + 30), Color.Black, color);
            veHinhChuNhat(new Point(c.X + 30, c.Y + 30), new Point(c.X + 150, c.Y + 100), Color.Black, color);
        }

        void veLa(Point l, Color color)
        {
            g = this.panel1.CreateGraphics();

            Point p11 = new Point(l.X, l.Y);
            Point p12 = new Point(l.X - 100, l.Y - 89);
            Point p13 = new Point(l.X - 100, l.Y - 30);
            Point[] p1 = { p11, p12, p13 };
            g.FillPolygon(new SolidBrush(color), p1);
            Point p14 = new Point(l.X - 100, l.Y - 90);
            Point p15 = new Point(l.X - 190, l.Y - 10);
            Point p16 = new Point(l.X - 100, l.Y - 30);
            Point[] p2 = { p14, p15, p16 };
            g.FillPolygon(new SolidBrush(color), p2);
            veDuongThang(l, new Point(l.X - 100, l.Y - 90), Color.Black);
            veDuongThang(new Point(l.X - 100, l.Y - 90), new Point(l.X - 190, l.Y - 10), Color.Black);
            veDuongThang(new Point(l.X - 190, l.Y - 10), new Point(l.X - 100, l.Y - 30), Color.Black);
            veDuongThang(new Point(l.X - 100, l.Y - 30), l, Color.Black);

            Point p21 = new Point(l.X, l.Y);
            Point p22 = new Point(l.X + 100, l.Y - 90);
            Point p23 = new Point(l.X + 100, l.Y - 30);
            Point[] p3 = { p21, p22, p23 };
            g.FillPolygon(new SolidBrush(color), p3);
            Point p24 = new Point(l.X + 100, l.Y - 90);
            Point p25 = new Point(l.X + 190, l.Y - 10);
            Point p26 = new Point(l.X + 100, l.Y - 30);
            Point[] p4 = { p24, p25, p26 };
            g.FillPolygon(new SolidBrush(color), p4);
            veDuongThang(l, new Point(l.X + 100, l.Y - 90), Color.Black);
            veDuongThang(new Point(l.X + 100, l.Y - 90), new Point(l.X + 190, l.Y - 10), Color.Black);
            veDuongThang(new Point(l.X + 190, l.Y - 10), new Point(l.X + 100, l.Y - 30), Color.Black);
            veDuongThang(new Point(l.X + 100, l.Y - 30), l, Color.Black);
        }

        void veHoa(Point h, Point t1, Point t2, Point t3, int bk, Color color1, Color color2) //1-> mau nhanh, 2-> mau hoa
        {
            g = this.panel1.CreateGraphics();

            panel3.Refresh();
            label_toado7.Text = "TỌA ĐỘ 3 BÔNG HOA:";

            veDuongThang(h, t1, color1); veDuongThang(h, t2, color1); veDuongThang(h, t3, color1);

            veDuongTron(t1.X, t1.Y, bk, color2);
            Rectangle rect1 = new Rectangle(t1.X - bk * 5, t1.Y - bk * 5, bk * 10, bk * 10);
            g.FillEllipse(new SolidBrush(color2), rect1);
            label_toado8.Text = "Bông hoa thứ 1: " + "Tâm(x = " + doiXsangx(t1.X) + ", " + "y = " + doiYsangy(t1.Y) + "); Bán kính = " + bk;

            veDuongTron(t2.X, t2.Y, bk, color2);
            Rectangle rect2 = new Rectangle(t2.X - bk * 5, t2.Y - bk * 5, bk * 10, bk * 10);
            g.FillEllipse(new SolidBrush(color2), rect2);
            label_toado9.Text = "Bông hoa thứ 2: " + "Tâm(x = " + doiXsangx(t2.X) + ", " + "y = " + doiYsangy(t2.Y) + "); Bán kính = " + bk;

            veDuongTron(t3.X, t3.Y, bk, color2);
            Rectangle rect3 = new Rectangle(t3.X - bk * 5, t3.Y - bk * 5, bk * 10, bk * 10);
            g.FillEllipse(new SolidBrush(color2), rect3);
            label_toado10.Text = "Bông hoa thứ 2: " + "Tâm(x = " + doiXsangx(t3.X) + ", " + "y = " + doiYsangy(t3.Y) + "); Bán kính = " + bk;

        }

        void veMatTroi(int trangthai)
        {
            if (trangthai == 0)
            {
                Rectangle rect = new Rectangle(330, 2, 100, 100);
                g.FillEllipse(new SolidBrush(Color.Yellow), rect);
                veDuongTron(380, 50, 10, Color.Black);
                veDuongTron(380, 50, 13, Color.Yellow);
                veDuongTron(380, 50, 16, Color.Yellow);
                veDuongTron(380, 50, 19, Color.Yellow);

                //ve mat
                Rectangle rect1 = new Rectangle(350, 40, 10, 10);
                g.FillEllipse(new SolidBrush(Color.Black), rect1);
                Rectangle rect2 = new Rectangle(400, 40, 10, 10);
                g.FillEllipse(new SolidBrush(Color.Black), rect2);

                //ve mieng
                veDuongThang(new Point(355, 70), new Point(380, 80), Color.Black);
                veDuongThang(new Point(380, 80), new Point(405, 70), Color.Black);
            }

            if (trangthai == 1)
            {
                Rectangle rect = new Rectangle(330, 2, 100, 100);
                g.FillEllipse(new SolidBrush(Color.Yellow), rect);
                veDuongTron(380, 50, 10, Color.Black);
                veDuongTron(380, 50, 13, Color.Yellow);
                veDuongTron(380, 50, 16, Color.Yellow);
                veDuongTron(380, 50, 19, Color.Yellow);

                //ve mat
                Rectangle rect1 = new Rectangle(350, 40, 10, 10);
                g.FillEllipse(new SolidBrush(Color.Black), rect1);
                Rectangle rect2 = new Rectangle(400, 40, 10, 10);
                g.FillEllipse(new SolidBrush(Color.Black), rect2);

                //ve mieng
                veDuongThang(new Point(355, 80), new Point(380, 70), Color.Black);
                veDuongThang(new Point(380, 70), new Point(405, 80), Color.Black);
            }
        }

        void veChauHoa()
        {
            //ve mat troi
            veMatTroi(0);

            //ve chau
            veChau(new Point(300, 500), Color.SaddleBrown);

            //ve la
            veLa(new Point(390, 495), Color.Green);

            //ve hoa
            veHoa(new Point(390, 495), new Point(350, 400), new Point(380, 350), new Point(420, 400), 1, Color.Green, Color.Red);

            //Ve may bay den
            for (int i = 0; i <= 500; i += 5)
            {
                veMay(new Point(-200 + i, 110), Color.Black, Color.Gray);
                Thread.Sleep(10);
                if (i == 150) veMatTroi(1);
                if (i < 500) veMay(new Point(-200 + i, 110), Color.Cyan, Color.Gray);
            }
            //ve mua
            for (int i = 0; i < 4; i++)
            {
                veNuoc(new Point(280, 170), new Point(230, 340), Color.Blue);
                Thread.Sleep(400);
                veNuoc(new Point(280, 170), new Point(230, 340), Color.Cyan);
                Thread.Sleep(400);
            }
            //ve may bay di
            for (int i = 500; i <= 1100; i += 5)
            {
                veMay(new Point(-200 + i, 110), Color.Black, Color.Gray);
                Thread.Sleep(10);
                if (i == 750) veMatTroi(0);
                veMay(new Point(-200 + i, 110), Color.Cyan, Color.Gray);
            }

            //ve hoa lon len
            veHoa(new Point(390, 495), new Point(350, 400), new Point(380, 350), new Point(420, 400), 1, Color.Green, Color.Cyan);
            for (int i = 0; i <= 70; i += 5)
            {
                veHoa(new Point(390, 495), new Point(350 - i, 400 - i), new Point(380, 350 - i), new Point(420 + i, 400 - i), 1, Color.Green, Color.Red);
                Thread.Sleep(100);
                if (i < 70) veHoa(new Point(390, 495), new Point(350 - i, 400 - i), new Point(380, 350 - i), new Point(420 + i, 400 - i), 1, Color.Cyan, Color.Cyan);
            }

            int bk = 1;
            for (int i = 0; i < 3; i++)
            {
                bk = bk * 2;
                veHoa(new Point(390, 495), new Point(350 - 70, 400 - 70), new Point(380, 350 - 70), new Point(420 + 70, 400 - 70), bk, Color.Green, Color.Red);
                Thread.Sleep(600);
            }

            //ve mat hoa 1
            //ve mat
            Rectangle rect1 = new Rectangle(260, 320, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Black), rect1);
            Rectangle rect2 = new Rectangle(290, 320, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Black), rect2);
            //ve mieng
            veDuongThang(new Point(265, 340), new Point(280, 350), Color.Black);
            veDuongThang(new Point(280, 350), new Point(295, 340), Color.Black);

            //ve mat hoa 2
            //ve mat
            Rectangle rect3 = new Rectangle(360, 270, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Black), rect3);
            Rectangle rect4 = new Rectangle(390, 270, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Black), rect4);
            //ve mieng
            veDuongThang(new Point(365, 290), new Point(380, 300), Color.Black);
            veDuongThang(new Point(380, 300), new Point(395, 290), Color.Black);

            //ve mat hoa 3
            //ve mat
            Rectangle rect5 = new Rectangle(470, 320, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Black), rect5);
            Rectangle rect6 = new Rectangle(500, 320, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Black), rect6);
            //ve mieng
            veDuongThang(new Point(475, 340), new Point(490, 350), Color.Black);
            veDuongThang(new Point(490, 350), new Point(505, 340), Color.Black);
        }

        //===========================================================

        //=================Code hình 3 2D============================
        private void Bresenhem(Point p1, Point p2, Color m)
        {
            Point p = new Point(0, 0), pe = new Point(0, 0);
            int dx, dy, dx1, dy1, s1, s2;
            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;
            dx1 = Math.Abs(dx);
            dy1 = Math.Abs(dy);
            s1 = 2 * dy1 - dx1;
            s2 = 2 * dx1 - dy1;

            if (dy1 <= dx1)
            {
                if (dx >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.X = p2.X;
                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.X = p1.X;
                }
                putpixel(p.X, p.Y, m);
                for (int i = 0; p.X < pe.X; i++)
                {
                    p.X = p.X + 5;
                    if (s1 < 0) s1 = s1 + 2 * dy1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.Y = p.Y + 5;
                        else p.Y = p.Y - 5;
                        s1 = s1 + 2 * (dy1 - dx1);
                    }
                    putpixel(p.X, p.Y, m);
                }
            }

            else
            {
                if (dy >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.Y = p2.Y;

                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.Y = p1.Y;
                }
                putpixel(p.X, p.Y, m);
                for (int i = 0; p.Y < pe.Y; i++)
                {
                    p.Y = p.Y + 5;
                    if (s2 <= 0) s2 = s2 + 2 * dx1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.X = p.X + 5;
                        else p.X = p.X - 5;
                        s2 = s2 + 2 * (dx1 - dy1);
                    }
                    putpixel(p.X, p.Y, m);
                }
            }
        }
        public Point doiXungQuaOy(Point diem)
        {
            int x = -(doiXsangx(diem.X));
            int y = diem.Y;
            int x1 = 400 + 5 * x;
            Point p = new Point(x1, y);
            return p;
        }
        private void putpixel(int x, int y, Color a)
        {
            Brush mybrush = new SolidBrush(a);
            g.FillRectangle(mybrush, (float)(x - 2), (float)(y - 2), 5, 5);
        }
        public int round(double tds)
        {
            int tdm;
            double sodu = tds % 5;
            if (sodu != 0)
            {
                if (sodu >= 3) tdm = (int)(tds + 5 - sodu);
                else tdm = (int)(tds - sodu);
            }
            else tdm = (int)tds;
            // if (tdm > 400) tdm = 400;
            return tdm;
        }
        public Point Tinhtien(Point d1, int dx, int dy)
        {
            int x, y;
            x = d1.X; y = d1.Y;
            double[,] matran1;
            double[] mang;
            mang = new double[3];
            matran1 = new double[3, 3];

            //Ma tran cua phep tinh tien diem p theo vecter(dx,dy);
            matran1[0, 0] = 1; matran1[0, 1] = 0; matran1[0, 2] = 0;
            matran1[1, 0] = 0; matran1[1, 1] = 1; matran1[1, 2] = 0;
            matran1[2, 0] = dx; matran1[2, 1] = dy; matran1[2, 2] = 1;
            mang[0] = x; mang[1] = y; mang[2] = 1;
            Point pt2 = nhanMT2(matran1, mang);
            Point kq = new Point(round(pt2.X), round(pt2.Y));
            return kq;
        }
        public Point nhanMT2(double[,] matran, double[] mang)
        {
            double[] mangtam;
            mangtam = new double[3];

            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                mangtam[i] = mang[0] * matran[0, dem] + mang[1] * matran[1, dem] + mang[2] * matran[2, dem];
                dem++;
            }

            Point pt = new Point(Convert.ToInt16(mangtam[0]), Convert.ToInt16(mangtam[1]));
            return pt;
        }
        public Point dxungOy(Point diem, int x)
        {
            Point temp = new Point(0, 0);
            if (diem.X < x) temp.X = diem.X + 2 * (x - diem.X);
            else temp.X = diem.X - 2 * (diem.X - x);
            temp.Y = diem.Y;
            return temp;
        }
        public void toMauHinhTron(int x1, int y1, int x2, int y2, SolidBrush redBrush)
        {
            // Create solid brush.


            // Create rectangle for ellipse.
            int x = x1;
            int y = y1;
            int width = x2;
            int height = y2;
            Rectangle rect = new Rectangle(x, y, width, height);

            // Fill ellipse on screen.
            g.FillEllipse(redBrush, rect);
        }
        public void Midpoint_htron(htron T)
        {
            int x, y, cx, cy, p, R;
            Color m = T.mau;
            cx = T.tam.X; cy = T.tam.Y;
            x = 0;
            y = R = T.bkinh;
            int maxX = round((float)(Math.Sqrt(2) / 2 * R));
            // int maxX = Math.Sqrt(2) / 2 * R;
            p = 1 - R;
            put8pitxel(x, y, cx, cy, m);
            while (x <= maxX)
            {
                if (p < 0) p += 2 * x + 3;
                else { p += 2 * (x - y) + 5; y -= 5; }
                x += 5;
                put8pitxel(x, y, cx, cy, m);
            }
        }
        private void put8pitxel(int x, int y, int cx, int cy, Color m)
        {
            putpixel(cx + x, cy + y, m);
            putpixel(cx + x, cy - y, m);
            putpixel(cx - x, cy + y, m);
            putpixel(cx - x, cy - y, m);
            putpixel(cx + y, cy + x, m);
            putpixel(cx + y, cy - x, m);
            putpixel(cx - y, cy + x, m);
            putpixel(cx - y, cy - x, m);
        }
        public void veDay()
        {
            Bresenhem(new Point(200, 1), new Point(600, 1), Color.Black);
            Bresenhem(new Point(240, 0), new Point(240, 260), Color.Black);
            Bresenhem(new Point(320, 0), new Point(320, 260), Color.Black);
            Bresenhem(new Point(400, 0), new Point(400, 260), Color.Black);
            Bresenhem(new Point(480, 0), new Point(480, 260), Color.Black);
            Bresenhem(new Point(560, 0), new Point(560, 260), Color.Black);
        }
        public void VeMay2()
        {
            SolidBrush redBrush1 = new SolidBrush(Color.White);
            //hình tròn1
            toMauHinhTron(647, 30, 45, 40, redBrush1);  //547 + 50
            Point p1 = new Point(670, 50);  //570
            htron hinhTron1 = new htron(20, p1, Color.Black);
            Midpoint_htron(hinhTron1);
            //hình tròn 2
            toMauHinhTron(670, 12, 65, 60, redBrush1);  //570
            Point p2 = new Point(705, 42);   //605
            htron hinhTron2 = new htron(30, p2, Color.Black);
            Midpoint_htron(hinhTron2);
            //hinh tròn 3
            toMauHinhTron(710, 20, 59, 55, redBrush1); //610
            Point p3 = new Point(740, 45); //640
            htron hinhTron3 = new htron(25, p3, Color.Black);
            Midpoint_htron(hinhTron3);
        }
        public void veNui(Color m)
        {
            //Núi 1 bên trái - phải
            Point d1 = new Point(0, 800);
            Point d2 = new Point(70, 700);
            Bresenhem(d1, d2, Color.Black);
            Bresenhem(doiXungQuaOy(d1), doiXungQuaOy(d2), Color.Black);
            Point d3 = new Point(105, 745);
            Bresenhem(d2, d3, Color.Black);
            Bresenhem(doiXungQuaOy(d2), doiXungQuaOy(d3), Color.Black);
            //Núi 2 trái - phải
            Point d4 = new Point(200, 600);
            Point d5 = new Point(70, 800);
            Bresenhem(d4, d5, Color.Black);
            Bresenhem(doiXungQuaOy(d4), doiXungQuaOy(d5), Color.Black);
            Point d6 = new Point(265, 700);
            Bresenhem(d4, d6, Color.Black);
            Bresenhem(doiXungQuaOy(d4), doiXungQuaOy(d6), Color.Black);
            //Núi ở giữa
            Point d7 = new Point(200, 800);
            Point d8 = new Point(400, 500);
            Bresenhem(d7, d8, Color.Black);
            Bresenhem(d8, doiXungQuaOy(d7), Color.Black);
        }
        public void toMauNui(Color m)
        {
            SolidBrush blueBrush = new SolidBrush(m);
            // Create points that define polygon.
            //Núi 1 bên trái
            Point p1 = new Point(0, 800);  //7
            Point p2 = new Point(70, 700);  //6
            Point p3 = new Point(150, 800);  //7
            Point[] curvePoints1 = { p1, p2, p3 };
            g.FillPolygon(blueBrush, curvePoints1);
            //Núi 2 bên trái
            Point p4 = new Point(200, 600);  //5
            Point p5 = new Point(70, 800);  //7
            Point p6 = new Point(330, 800);//7
            Point[] curvePoints2 = { p4, p5, p6 };
            g.FillPolygon(blueBrush, curvePoints2);
            //Núi 3 ở giữa
            Point p7 = new Point(200, 800);//7
            Point p8 = new Point(400, 500);//4
            Point p7_dx = doiXungQuaOy(p7);
            Point[] curvePoints3 = { p7, p8, p7_dx };
            g.FillPolygon(blueBrush, curvePoints3);
            //Núi 1 bên phải
            Point p1_dx = doiXungQuaOy(p1);
            Point p2_dx = doiXungQuaOy(p2);
            Point p3_dx = doiXungQuaOy(p3);
            Point[] curvePoints1_dx = { p1_dx, p2_dx, p3_dx };
            g.FillPolygon(blueBrush, curvePoints1_dx);
            //Núi 2 bên phải
            Point p4_dx = doiXungQuaOy(p4);
            Point p5_dx = doiXungQuaOy(p5);
            Point p6_dx = doiXungQuaOy(p6);
            Point[] curvePoints2_dx = { p4_dx, p5_dx, p6_dx };
            g.FillPolygon(blueBrush, curvePoints2_dx);

        }
        public void veNgoiSao()
        {
            //ngôi sao 1
            Bresenhem(new Point(80, 20), new Point(80, 70), Color.White);
            Bresenhem(new Point(50, 45), new Point(110, 45), Color.White);
            Bresenhem(new Point(95, 30), new Point(65, 60), Color.White);
            Bresenhem(new Point(65, 30), new Point(95, 60), Color.White);
            //ngôi sao 2
            Bresenhem(new Point(700, 225), new Point(760, 225), Color.Yellow);
            Bresenhem(new Point(730, 200), new Point(730, 250), Color.Yellow);
            Bresenhem(new Point(745, 210), new Point(715, 240), Color.Yellow);
            Bresenhem(new Point(715, 210), new Point(745, 240), Color.Yellow);
        }
        public void toMauConLac()
        {
            // SolidBrush redBrush = new SolidBrush(Color.SpringGreen);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            toMauHinhTron(197, 257, 88, 88, redBrush);
            toMauHinhTron(277, 257, 88, 88, redBrush);
            toMauHinhTron(357, 257, 88, 88, redBrush);
            toMauHinhTron(437, 257, 88, 88, redBrush);
            toMauHinhTron(517, 257, 88, 88, redBrush);

            //to bóng trắng cho con lắc
            Bresenhem(new Point(220, 280), new Point(220, 300), Color.White);
            Bresenhem(new Point(300, 280), new Point(300, 300), Color.White);
            Bresenhem(new Point(380, 280), new Point(380, 300), Color.White);
            Bresenhem(new Point(460, 280), new Point(460, 300), Color.White);
            Bresenhem(new Point(540, 280), new Point(540, 300), Color.White);
        }
        public void veConLac(Point p, int r, Color c)
        {
            Point p1 = new Point(0, 0);
            p1.X = p.X;
            p1.Y = p.Y;
            htron hinhTron = new htron(r, p1, c);
            Midpoint_htron(hinhTron);
        }
        public void ve3ConLacDau()
        {
            int i = 0;
            int r = 40;
            Color c = Color.Black;
            Point p1 = new Point(240, 300);
            Point p2 = new Point(320, 300);
            Point p3 = new Point(400, 300);
            veConLac(p1, r, c);//lac 1
            veConLac(p2, r, c);//lac 2
            veConLac(p3, r, c);//lac 3
        }
        public void toMau3ConLacDau()
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            toMauHinhTron(197, 257, 88, 88, redBrush);
            toMauHinhTron(277, 257, 88, 88, redBrush);
            toMauHinhTron(357, 257, 88, 88, redBrush);
            //to bóng trắng cho con lắc
            Bresenhem(new Point(220, 280), new Point(220, 300), Color.White);//bóng con lắc 1
            Bresenhem(new Point(300, 280), new Point(300, 300), Color.White);//bóng con lắc 2
            Bresenhem(new Point(380, 280), new Point(380, 300), Color.White);//bóng con lắc 3
        }
        public void ve4LineDau()
        {
            Bresenhem(new Point(200, 1), new Point(600, 1), Color.Black);     //dây ngang
            Bresenhem(new Point(240, 0), new Point(240, 260), Color.Black);   //dây con lắc 1
            Bresenhem(new Point(320, 0), new Point(320, 260), Color.Black);  //dây con lắc 2
            Bresenhem(new Point(400, 0), new Point(400, 260), Color.Black);  // dây con lắc 3
            Bresenhem(new Point(480, 0), new Point(480, 260), Color.Black);  // dây con lắc 4
        }
        public void ve3ConLacSau()
        {
            int r = 40;
            Color c = Color.Black;
            Point p1 = new Point(240, 300);
            Point p2 = new Point(320, 300);
            Point p3 = new Point(400, 300);
            Point p4 = doiXungQuaOy(p2);
            Point p5 = doiXungQuaOy(p1);
            veConLac(p3, r, c);//lac 3
            veConLac(p4, r, c);//lac 4
            veConLac(p5, r, c);//lac 5

        }
        public void toMau3ConLacSau()
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            toMauHinhTron(357, 257, 88, 88, redBrush);
            toMauHinhTron(437, 257, 88, 88, redBrush);
            toMauHinhTron(517, 257, 88, 88, redBrush);
            //bóng con lắc
            Bresenhem(new Point(380, 280), new Point(380, 300), Color.White);//bóng con lắc 3
            Bresenhem(new Point(460, 280), new Point(460, 300), Color.White);//bóng con lắc 4
            Bresenhem(new Point(540, 280), new Point(540, 300), Color.White);//bóng con lắc 5

        }
        public void ve4LineSau()
        {
            Bresenhem(new Point(200, 1), new Point(600, 1), Color.Black); //dây ngang
            Bresenhem(new Point(320, 0), new Point(320, 260), Color.Black);  //dây con lắc 2
            Bresenhem(new Point(400, 0), new Point(400, 260), Color.Black);  //dây con lắc 3
            Bresenhem(new Point(480, 0), new Point(480, 260), Color.Black);  //dây con lắc 4
            Bresenhem(new Point(560, 0), new Point(560, 260), Color.Black);  //dây con lắc 5
        }
        public void doiToaDo(Point p1, Point line1, Point p2, Point line2)
        {

            label_toado1.Text = "TỌA ĐỘ CON LẮC 1";
            label_toado2.Text = "X = " + doiXsangx(p1.X);
            label_toado3.Text = "Y = " + doiYsangy(p1.Y);
            label_toado4.Text = "TỌA ĐÔ DÂY CỦA CON LẮC 1";
            label_toado5.Text = "X = " + doiXsangx(line1.X);
            label_toado6.Text = "Y = " + doiYsangy(line1.Y);

            label_toado7.Text = "TỌA ĐỘ CON LẮC 5";
            label_toado8.Text = "X = " + doiXsangx(p2.X);
            label_toado9.Text = "Y = " + doiYsangy(p2.Y);
            label_toado10.Text = "TỌA ĐÔ DÂY CỦA CON LẮC 5";
            label_toado11.Text = "X = " + doiXsangx(line2.X);
            label_toado12.Text = "Y = " + doiYsangy(line2.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = this.panel1.CreateGraphics();
            Point p1 = new Point(240, 300);
            Point p2 = new Point(320, 300);
            Point p3 = new Point(400, 300);
            Point p4 = doiXungQuaOy(p2);
            Point p5 = doiXungQuaOy(p1);
            xuLi2(p1, p2, p4, p5);
        }

        public void xuLi2(Point p1, Point p2, Point p4, Point p5)
        {
            int r = 40;
            Point dauLine1 = new Point(240, 0);
            Point cuoiLine1 = new Point(240, 260);
            Point dauLine2 = new Point(560, 0);
            Point cuoiLine2 = new Point(560, 260);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush r_While = new SolidBrush(Color.White);//1
            SolidBrush r_Yellow = new SolidBrush(Color.Yellow);//2
            SolidBrush r_Black = new SolidBrush(Color.Black);//3
            SolidBrush r_Orange = new SolidBrush(Color.Orange); //4
            SolidBrush r_Gray = new SolidBrush(Color.Gray); //5
            SolidBrush r_Pale = new SolidBrush(Color.PaleTurquoise);  //6
            SolidBrush r_Indigo = new SolidBrush(Color.Indigo);  //7

            if (conLac5 == true && conLac1 == false)
            {
                panel1.BackColor = Color.PaleTurquoise;
                //    luoi2D(); //them cho vui
                toMau3ConLacDau();
                ve3ConLacDau();
                ve4LineDau();
                VeMay2();
                Color m = Color.Lime;
                toMauNui(m);
                veNui(m);

                //đổi tọa độ
                doiToaDo(p1, cuoiLine1, Tinhtien(p5, a, x), Tinhtien(cuoiLine2, a, x));

                Point toMau = new Point(517, 257);
                Point p5_Mat1 = new Point(540, 290);  //mắt trái
                Point p5_Mat2 = new Point(570, 290);  //mắt phải
                Point p5_Mieng = new Point(550, 300); //miệng
                Point p5_CheMieng = new Point(550, 290);
                veConLac(Tinhtien(p5, a1, x1), 40, Color.PaleTurquoise);  //ẩn (xóa) con lắc 5 lúc sau tịnh tiến
                veConLac(p4, r, Color.Black); //vẽ lại con lắc 4
                Bresenhem(dauLine2, Tinhtien(cuoiLine2, a1, x1), Color.PaleTurquoise);  //ẩn (xóa) dây con lắc 5 lúc sau

                if (a != 0 && x != 0)
                {
                    toMauHinhTron(Tinhtien(toMau, a1, x1).X - 15, Tinhtien(toMau, a1, x1).Y - 15, 120, 120, r_Pale); //ẩn vòng mặt trời ngoài cùng
                    toMauHinhTron(Tinhtien(toMau, a1, x1).X, Tinhtien(toMau, a1, x1).Y, 88, 88, r_Pale); //ẩn vòng mặt trời ở giữa
                    toMauHinhTron(Tinhtien(toMau, a, x).X - 15, Tinhtien(toMau, a, x).Y - 15, 120, 120, r_Yellow); // tô vòng mặt trời ngoài cùng
                    toMauHinhTron(Tinhtien(toMau, a, x).X - 5, Tinhtien(toMau, a, x).Y - 5, 100, 100, r_Orange); //tô màu vòng mặt trời ở giữa
                    toMauHinhTron(Tinhtien(toMau, a, x).X, Tinhtien(toMau, a, x).Y, 88, 88, r_Yellow);// tô màu mặt trời
                    toMauHinhTron(Tinhtien(p5_Mat1, a, x).X, Tinhtien(p5_Mat1, a, x).Y, 10, 10, r_Black); //vẽ con mắt trái tịnh tiến
                    toMauHinhTron(Tinhtien(p5_Mat2, a, x).X, Tinhtien(p5_Mat2, a, x).Y, 10, 10, r_Black);  //vẽ mắt phải tịnh tiến
                    toMauHinhTron(Tinhtien(p5_Mieng, a, x).X, Tinhtien(p5_Mieng, a, x).Y, 20, 20, r_Black); //miejng tịnh tiến
                    toMauHinhTron(Tinhtien(p5_CheMieng, a, x).X, Tinhtien(p5_CheMieng, a, x).Y, 20, 20, r_Yellow);
                    toMauHinhTron(437, 257, 88, 88, redBrush);
                    veConLac(p4, r, Color.Black); // vẽ lại con lắc 4
                    Bresenhem(new Point(460, 280), new Point(460, 300), Color.White); // vẽ lại bóng con lắc 4
                    veConLac(Tinhtien(p5, a, x), 40, Color.Black);  //vẽ con lắc mới 5 tịnh tiến
                    Bresenhem(dauLine2, Tinhtien(cuoiLine2, a, x), Color.Black);  // vẽ dây 5 mới tịnh tiến
                }
                if (kt1 == true)
                {
                    a1 = a;
                    x1 = x;
                    a = a + 10;
                    x = x - 5;
                }
                if (a == 100 && x == -50)
                {
                    kt1 = false;
                }

                if (kt1 == false)
                {
                    if (a > -10 && x < 5)
                    {
                        veConLac(Tinhtien(p5, a1, x1), r, Color.PaleTurquoise); //ẩn con lắc 5 tịnh tiến cũ
                        Bresenhem(dauLine2, Tinhtien(cuoiLine2, a1, x1), Color.PaleTurquoise); // ẩn dây con lắc 5 cũ

                        toMauHinhTron(Tinhtien(toMau, a1, x1).X - 15, Tinhtien(toMau, a1, x1).Y - 15, 120, 120, r_Pale); //ẩn con lắc 5
                        toMauHinhTron(Tinhtien(toMau, a, x).X - 15, Tinhtien(toMau, a, x).Y - 15, 120, 120, r_Yellow); //tô màu vòng trong ngoài cùng
                        toMauHinhTron(Tinhtien(toMau, a, x).X - 5, Tinhtien(toMau, a, x).Y - 5, 100, 100, r_Orange); //tô màu vòng tròn ở giữa
                        toMauHinhTron(Tinhtien(toMau, a, x).X, Tinhtien(toMau, a, x).Y, 88, 88, r_Yellow); // tô màu con lắc 5 mới

                        toMauHinhTron(Tinhtien(p5_Mat1, a, x).X, Tinhtien(p5_Mat1, a, x).Y, 10, 10, r_Black); //tịnh tiến mắt trái về
                        toMauHinhTron(Tinhtien(p5_Mat2, a, x).X, Tinhtien(p5_Mat2, a, x).Y, 10, 10, r_Black); //tịnh tiến mắt phải về
                        toMauHinhTron(Tinhtien(p5_Mieng, a, x).X, Tinhtien(p5_Mieng, a, x).Y, 20, 20, r_Black); //tịnh tiến miệng về
                        toMauHinhTron(Tinhtien(p5_CheMieng, a, x).X, Tinhtien(p5_CheMieng, a, x).Y, 20, 20, r_Yellow);
                        veConLac(Tinhtien(p5, a, x), r, Color.Black); // vẽ con lắc 5 tịnh tiến về
                        Bresenhem(dauLine2, Tinhtien(cuoiLine2, a, x), Color.Black); //vẽ dây con lắc 5 tịnh tiến về
                        a1 = a;
                        x1 = x;
                        a = a - 10;
                        x = x + 5;
                        if (a <= -10 && x >= 5)
                        {
                            toMauHinhTron(Tinhtien(toMau, a, x).X - 15, Tinhtien(toMau, a, x).Y - 15, 120, 120, r_Pale); //ẩn con lắc 5
                            toMauHinhTron(toMau.X, toMau.Y, 88, 88, redBrush);
                            veConLac(p5, r, Color.Black);
                            toMauHinhTron(437, 257, 88, 88, redBrush);
                            Bresenhem(new Point(540, 180), new Point(540, 200), Color.White);  //vẽ lại bóng con lắc 5
                            veConLac(p4, r, Color.Black);
                            Bresenhem(new Point(460, 180), new Point(460, 200), Color.White);  //vẽ lại bóng con lắc 4
                            Bresenhem(dauLine2, cuoiLine2, Color.Black);
                            kt1 = true;
                            conLac5 = false;
                            conLac1 = true;
                            a = 0;
                            x = 0;
                            a1 = 0;
                            x1 = 0;
                        }
                    }
                }
            }
            if (conLac5 == false && conLac1 == true)
            {
                panel1.BackColor = Color.Indigo;
                //   luoi2D(); // them cho vui
                toMau3ConLacSau();
                ve3ConLacSau();
                ve4LineSau();
                veNgoiSao();
                Color m = Color.Black;
                toMauNui(m);
                veNui(m);

                //đổi tọa độ
                doiToaDo(Tinhtien(p1, b, t), Tinhtien(cuoiLine1, b, t), p5, cuoiLine2);
                //
                Point toMau = new Point(197, 257);
                Point p1_Mat1 = new Point(210, 290);
                Point p1_Mat2 = new Point(250, 290);
                Point p1_CheMat1 = new Point(210, 280);
                Point p1_CheMat2 = new Point(250, 280);

                veConLac(Tinhtien(p1, b1, t1), r, Color.Indigo); //ẩn con lắc 1 cũ
                veConLac(p2, r, Color.Black);
                Bresenhem(dauLine1, Tinhtien(cuoiLine1, b1, t1), Color.Indigo); //ẩn đi dây 1

                if (b != 0 && t != 0)
                {

                    toMauHinhTron(Tinhtien(toMau, b1, t1).X, Tinhtien(toMau, b1, t1).Y, 88, 88, r_Indigo); //ẩn con lắc 1 cũ
                    toMauHinhTron(Tinhtien(toMau, b, t).X, Tinhtien(toMau, b, t).Y, 88, 88, r_Gray); //tô màu con lắc 1 mới
                    toMauHinhTron(Tinhtien(p1_Mat1, b, t).X, Tinhtien(p1_Mat1, b, t).Y, 20, 20, r_Black);//vẽ mắt 1 tịnh tiến
                    toMauHinhTron(Tinhtien(p1_Mat2, b, t).X, Tinhtien(p1_Mat2, b, t).Y, 20, 20, r_Black);//vẽ măt 2 tịnh tiến
                    toMauHinhTron(Tinhtien(p1_CheMat1, b, t).X, Tinhtien(p1_CheMat1, b, t).Y, 20, 25, r_Gray);
                    toMauHinhTron(Tinhtien(p1_CheMat2, b, t).X, Tinhtien(p1_CheMat2, b, t).Y, 20, 25, r_Gray);

                    toMauHinhTron(277, 257, 88, 88, redBrush);
                    veConLac(p2, r, Color.Black);
                    Bresenhem(new Point(300, 280), new Point(300, 300), Color.White);  //vẽ lại bóng con lắc 2
                    veConLac(Tinhtien(p1, b, t), r, Color.Black); //vẽ con lắc 1 tịnh tiến
                    Bresenhem(dauLine1, Tinhtien(cuoiLine1, b, t), Color.Black); //tịnh tiến dây 1
                }
                if (kt2 == true)
                {
                    b1 = b;
                    t1 = t;
                    b = b - 10;
                    t = t - 5;
                }
                if (b == -100 && t == -50)
                {
                    kt2 = false;
                }
                if (kt2 == false)
                {
                    veConLac(Tinhtien(p1, b1, t1), r, Color.Indigo);//ẩn con lắc 1 cũ về
                    toMauHinhTron(Tinhtien(toMau, b1, t1).X, Tinhtien(toMau, b1, t1).Y, 88, 88, r_Indigo);//tô màu ẩn con lắc 1 cũ
                    toMauHinhTron(Tinhtien(toMau, b, t).X, Tinhtien(toMau, b, t).Y, 88, 88, r_Gray); //tô màu tịnh tiến mới về
                    Bresenhem(dauLine1, Tinhtien(cuoiLine1, b1, t1), Color.Indigo); //ẩn dây cũ

                    toMauHinhTron(Tinhtien(p1_Mat1, b, t).X, Tinhtien(p1_Mat1, b, t).Y, 20, 20, r_Black);//vẽ mắt trái tịnh tiến về
                    toMauHinhTron(Tinhtien(p1_Mat2, b, t).X, Tinhtien(p1_Mat2, b, t).Y, 20, 20, r_Black);//vẽ mắt phải tịnh tiến về
                    toMauHinhTron(Tinhtien(p1_CheMat1, b, t).X, Tinhtien(p1_CheMat1, b, t).Y, 20, 25, r_Gray);
                    toMauHinhTron(Tinhtien(p1_CheMat2, b, t).X, Tinhtien(p1_CheMat2, b, t).Y, 20, 25, r_Gray);

                    veConLac(Tinhtien(p1, b, t), r, Color.Black); //vẽ con lắc 1 tịnh tiến về
                    Bresenhem(dauLine1, Tinhtien(cuoiLine1, b, t), Color.Black); // vẽ dây mới tịnh tiến về
                    b1 = b;
                    t1 = t;
                    b = b + 10;
                    t = t + 5;
                    if (b >= 10 && t >= 5)
                    {
                        toMauHinhTron(Tinhtien(toMau, b1, t1).X, Tinhtien(toMau, b1, t1).Y, 88, 88, r_Indigo); //ẩn con lắc 1 cũ
                        toMauHinhTron(toMau.X, toMau.Y, 88, 88, redBrush);
                        veConLac(p1, r, Color.Black);
                        toMauHinhTron(277, 257, 88, 88, redBrush);
                        Bresenhem(new Point(220, 280), new Point(220, 300), Color.White); //vẽ lại bóng con lắc 1
                        veConLac(p2, r, Color.Black);
                        //  Bresenhem(dauLine1, Tinhtien(cuoiLine1, b, t), Color.Black); //vẽ lại dây mới
                        Bresenhem(new Point(300, 280), new Point(300, 300), Color.White);  //vẽ lại bóng con lắc 2
                        kt2 = true;
                        conLac5 = true;
                        conLac1 = false;
                        b = 0;
                        t = 0;
                        b1 = 0;
                        t1 = 0;
                    }
                }
            }
        }

        //===========================================================

        //==============================VE HINH HOP 3D=====================================
        int doixsangX(int X)
        {
            int x = 5 * X + 400;
            return x;
        }

        int doiysangY(int Y)
        {
            int y = 400 - 5 * Y;
            return y;
        }

        Point doiDiemQuyUocSangManHinh(Point p)
        {
            Point P = new Point(doixsangX(p.X), doiysangY(p.Y));
            return P;
        }
        public class Point3D
        {
            public int X, Y, Z;
            public Point3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        public int lamTron(double a)
        {
            int a1 = (int)a;
            double du = a - a1;
            if (du >= 0.5)
            {
                return a1 + 1;
            }
            return a1;
        }

        public Point chuyen3Dsang2D(Point3D P3D) //Cabinet
        {
            int X = lamTron(P3D.X - P3D.Z * ((Math.Sqrt(2)) / 4));
            int Y = lamTron(P3D.Y - P3D.Z * ((Math.Sqrt(2)) / 4));
            Point P = new Point(X, Y);
            return P;
        }



        void veHinhHop(int x, int y, int z, int CD, int CR, int CC)
        {

            Point3D F3D = new Point3D(x, y, z);
            Point3D B3D = new Point3D(x, y + CC, z);
            Point3D G3D = new Point3D(x + CD, y, z);
            Point3D C3D = new Point3D(B3D.X + CD, B3D.Y, B3D.Z);

            Point3D E3D = new Point3D(x, y, z + CR);
            Point3D A3D = new Point3D(E3D.X, E3D.Y + CC, E3D.Z);
            Point3D D3D = new Point3D(A3D.X + CD, A3D.Y, A3D.Z);
            Point3D H3D = new Point3D(E3D.X + CD, E3D.Y, E3D.Z);

            label_toado1.Text = "TỌA ĐỘ CỦA CÁC ĐỈNH TRONG HÌNH HỘP";
            label_toado3.Text = "Đỉnh A (" + A3D.X + ", " + A3D.Y + ", " + A3D.Z + ")";
            label_toado4.Text = "Đỉnh B (" + B3D.X + ", " + B3D.Y + ", " + B3D.Z + ")";
            label_toado5.Text = "Đỉnh C (" + C3D.X + ", " + C3D.Y + ", " + C3D.Z + ")";
            label_toado6.Text = "Đỉnh D (" + D3D.X + ", " + D3D.Y + ", " + D3D.Z + ")";

            label_toado8.Text = "Đỉnh E (" + E3D.X + ", " + E3D.Y + ", " + E3D.Z + ")";
            label_toado9.Text = "Đỉnh F (" + F3D.X + ", " + F3D.Y + ", " + F3D.Z + ")";
            label_toado10.Text = "Đỉnh G (" + G3D.X + ", " + G3D.Y + ", " + G3D.Z + ")";
            label_toado11.Text = "Đỉnh H (" + H3D.X + ", " + H3D.Y + ", " + H3D.Z + ")";

            Point A1 = chuyen3Dsang2D(A3D);
            Point B1 = chuyen3Dsang2D(B3D);
            Point C1 = chuyen3Dsang2D(C3D);
            Point D1 = chuyen3Dsang2D(D3D);
            Point E1 = chuyen3Dsang2D(E3D);
            Point F1 = chuyen3Dsang2D(F3D);
            Point G1 = chuyen3Dsang2D(G3D);
            Point H1 = chuyen3Dsang2D(H3D);

            Point A = doiDiemQuyUocSangManHinh(A1);
            Point B = doiDiemQuyUocSangManHinh(B1);
            Point C = doiDiemQuyUocSangManHinh(C1);
            Point D = doiDiemQuyUocSangManHinh(D1);
            Point E = doiDiemQuyUocSangManHinh(E1);
            Point F = doiDiemQuyUocSangManHinh(F1);
            Point G = doiDiemQuyUocSangManHinh(G1);
            Point H = doiDiemQuyUocSangManHinh(H1);

            System.Drawing.Font f = new System.Drawing.Font("Arial", 13);
            g.DrawString("A", f, new SolidBrush(Color.Black), new Point(A.X - 25, A.Y - 15));
            g.DrawString("B", f, new SolidBrush(Color.Black), new Point(B.X - 25, B.Y - 15));
            g.DrawString("E", f, new SolidBrush(Color.Black), new Point(E.X - 25, E.Y - 15));
            g.DrawString("F", f, new SolidBrush(Color.Black), new Point(F.X - 25, F.Y - 15));

            g.DrawString("C", f, new SolidBrush(Color.Black), new Point(C.X + 4, C.Y - 15));
            g.DrawString("D", f, new SolidBrush(Color.Black), new Point(D.X + 4, D.Y - 15));
            g.DrawString("G", f, new SolidBrush(Color.Black), new Point(G.X + 4, G.Y - 15));
            g.DrawString("H", f, new SolidBrush(Color.Black), new Point(H.X + 4, H.Y - 15));

            veDuongThang(B, A, Color.Red);
            veDuongThang(B, C, Color.Red);
            veDuongThang(D, C, Color.Red);
            veDuongThang(D, A, Color.Red);

            veNetDut(F, E, Color.Red);
            veNetDut(F, G, Color.Red);
            veDuongThang(H, G, Color.Red);
            veDuongThang(E, H, Color.Red);

            veDuongThang(A, E, Color.Red);
            veNetDut(B, F, Color.Red);
            veDuongThang(C, G, Color.Red);
            veDuongThang(D, H, Color.Red);
        }

        //================================================================================

        //=============================VE HINH 2 3D=======================================
        public Point Cabinet(int x, int y, int z)
        {
            double X = x - z * (Math.Sqrt(2)) / 4;
            double Y = y - z * (Math.Sqrt(2)) / 4;
            int X1 = lamTron(X);
            int Y1 = lamTron(Y);
            Point d = new Point(X1, Y1);
            return d;
        }
        void ve1Poin(int x, double a, SolidBrush color)
        {
            int y = (int)a;
            g = this.panel1.CreateGraphics();
            g.FillRectangle(color, x - 2, y - 2, 5, 5);
        }
        public void draw(Point p, int r)
        {
            g = panel1.CreateGraphics();
            //vẽ hình tròn
            htron hinhTron = new htron(r, p, Color.Red);
            Midpoint_htron(hinhTron);

            //vẽ elip
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush black = new SolidBrush(Color.Black);
            veEllipse(p.X, p.Y, r, (int)(r * Math.Sqrt(2) / 4), Color.Red);

            int i = 0;
            int dem = 0;
            while (i <= r)
            {
                if (dem < 4)
                {
                    ve1Poin(p.X + i, p.Y, red);
                }
                if (dem == 6)
                {
                    dem = 0;
                }
                dem++;
                i = i + 5;
            }
            ve1Poin(p.X, p.Y, black);
            System.Drawing.Font f = new System.Drawing.Font("Arial", 15);
            g.DrawString("O", f, black, new Point(p.X - 10, p.Y + 5));
            g.DrawString("R", f, black, new Point(p.X + (r / 5), p.Y - ((r / 5))));
        }

        //================================================================================

        //========================VE HINH 3 - 3D ==========================================
        int doixsangX(double X)
        {
            double x = 5 * X + 400;
            return lamTron(x);
        }

        int doiysangY(double Y)
        {
            double y = 400 - 5 * Y;
            return lamTron(y);
        }

        Point doiDiemQuyUocSangManHinh(PointDouble p)
        {
            Point P = new Point(doixsangX(p.X), doiysangY(p.Y));
            return P;
        }
  
        void veNetDut(Point p1, Point p2, Color color)
        {
            int dem = 0;
            Point p = new Point(), pe = new Point();
            int dx, dy, dx1, dy1, s1, s2;
            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;
            dx1 = Math.Abs(dx);
            dy1 = Math.Abs(dy);
            s1 = 2 * dy1 - dx1;
            s2 = 2 * dx1 - dy1;

            if (dy1 <= dx1)
            {
                if (dx >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.X = p2.X;
                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.X = p1.X;
                }
                veMotDiem(p.X, p.Y, color); dem++;
                for (int i = 0; p.X < pe.X; i++)
                {
                    p.X = p.X + 5; //
                    if (s1 < 0) s1 = s1 + 2 * dy1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.Y = p.Y + 5; //
                        else p.Y = p.Y - 5; //
                        s1 = s1 + 2 * (dy1 - dx1);
                    }
                    if (dem <= 3)
                    {
                        veMotDiem(p.X, p.Y, color);
                        dem++;
                    }
                    else
                    {
                        dem = 0;
                    }
                }
            }

            else
            {
                if (dy >= 0)
                {
                    p.X = p1.X;
                    p.Y = p1.Y;
                    pe.Y = p2.Y;

                }
                else
                {
                    p.X = p2.X;
                    p.Y = p2.Y;
                    pe.Y = p1.Y;
                }
                veMotDiem(p.X, p.Y, color); dem++;
                for (int i = 0; p.Y < pe.Y; i++)
                {
                    p.Y = p.Y + 5; //
                    if (s2 <= 0) s2 = s2 + 2 * dx1;
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) p.X = p.X + 5; //
                        else p.X = p.X - 5; //
                        s2 = s2 + 2 * (dx1 - dy1);
                    }
                    if (dem <= 3)
                    {
                        veMotDiem(p.X, p.Y, color);
                        dem++;
                    }
                    else
                    {
                        dem = 0;
                    }
                }
            }
        }
        void ve4Diem(int xc, int yc, int x, int y, Color color)
        {
            veMotDiem(xc + x, yc + y, color);
            veMotDiem(xc + x, yc - y, color);
            veMotDiem(xc - x, yc - y, color);
            veMotDiem(xc - x, yc + y, color);
        }
        void veEllipse(int xc, int yc, int a, int b, Color color)// Sử dụng thuật thoán Bresenham để vẽ Ellipse
        {
            int x, y, dem1 = 0, dem2 = 0;
            x = 0;
            y = b;

            float x0 = (float)(a * a / Math.Sqrt(a * a + b * b));
            float p = (float)(a * a * (1 - 2 * b) + b * b);
            ve4Diem(xc, yc, x, y, color);

            while (x <= x0)
            {
                if (p < 0)
                {
                    p += 2 * b * b * (2 * x + 3);
                }
                else
                {
                    p += (2 * b * b) * (2 * x + 3) + 4 * a * a * (1 - y);
                    y -= 5;
                }
                x += 5;

                if (dem1 < 2)
                {
                    veMotDiem(xc + x, yc + y, color);
                    veMotDiem(xc - x, yc + y, color);
                    dem1++;
                }
                else if (dem1 >= 2 && dem1 <= 4)
                {
                    ve4Diem(xc, yc, x, y, color);
                    dem1++;
                }
                else
                {
                    ve4Diem(xc, yc, x, y, color);
                    dem1 = 0;
                }

            }
            x = a;
            y = 0;
            p = b * b * (1 - 2 * a) + a * a;
            ve4Diem(xc, yc, x, y, color);
            while (x > x0)
            {
                if (p < 0)
                {
                    p += (2 * a * a) * (2 * y + 3);
                }
                else
                {
                    p += (2 * a * a) * (2 * y + 3) + 4 * b * b * (1 - x);
                    x -= 5;
                }
                y += 5;
                if (dem2 < 2)
                {
                    veMotDiem(xc + x, yc + y, color);
                    veMotDiem(xc - x, yc + y, color);
                    dem2++;
                }
                else if (dem2 >= 2 && dem2 <= 4)
                {
                    ve4Diem(xc, yc, x, y, color);
                    dem2++;
                }
                else
                {
                    ve4Diem(xc, yc, x, y, color);
                    dem2 = 0;
                }
            }

        }
        public class PointDouble
        {
            public double X, Y;
            public PointDouble(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }

        public PointDouble chuyen3Dsang2D2(Point3D P3D) //Cabinet
        {
            double X = (P3D.X - P3D.Z * ((Math.Sqrt(2)) / 4));
            double Y = (P3D.Y - P3D.Z * ((Math.Sqrt(2)) / 4));
            PointDouble P = new PointDouble(X, Y);
            return P;
        }
        void veHinhNon(int x, int y, int z, int bk, int CC)
        {
            Point3D O3D = new Point3D(x, y, z);
            Point3D A3D = new Point3D(O3D.X, O3D.Y + CC, O3D.Z);
            Point3D B3D = new Point3D(O3D.X - bk, O3D.Y, O3D.Z);
            Point3D C3D = new Point3D(O3D.X + bk, O3D.Y, O3D.Z);

            label_toado1.Text = "TỌA ĐỘ CỦA CÁC ĐIỂM TRÊN HÌNH NÓN:";
            label_toado3.Text = "Tâm O (" + O3D.X + ", " + O3D.Y + ", " + O3D.Z + ")";
            label_toado4.Text = "Điểm A (" + A3D.X + ", " + A3D.Y + ", " + A3D.Z + ")";
            label_toado5.Text = "Điểm B (" + B3D.X + ", " + B3D.Y + ", " + B3D.Z + ")";
            label_toado6.Text = "Điểm C (" + C3D.X + ", " + C3D.Y + ", " + C3D.Z + ")";

            PointDouble O1 = chuyen3Dsang2D2(O3D);
            PointDouble A1 = chuyen3Dsang2D2(A3D);
            PointDouble B1 = chuyen3Dsang2D2(B3D);
            PointDouble C1 = chuyen3Dsang2D2(C3D);

            Point O = doiDiemQuyUocSangManHinh(O1);
            Point A = doiDiemQuyUocSangManHinh(A1);
            Point B = doiDiemQuyUocSangManHinh(B1);
            Point C = doiDiemQuyUocSangManHinh(C1);

            veDuongThang(A, B, Color.Red);
            veDuongThang(A, C, Color.Red);

            veNetDut(A, O, Color.Red);
            veNetDut(O, C, Color.Red);
            bk = bk * 5;
            veEllipse(O.X, O.Y, bk, (int)(CC / 5) * 5, Color.Red);

            System.Drawing.Font f = new System.Drawing.Font("Arial", 13);
            g.DrawString("O", f, new SolidBrush(Color.Black), new Point(O.X - 25, O.Y - 15));
            g.DrawString("A", f, new SolidBrush(Color.Black), new Point(A.X - 10, A.Y - 25));
            g.DrawString("B", f, new SolidBrush(Color.Black), new Point(B.X - 25, B.Y - 15));
            g.DrawString("C", f, new SolidBrush(Color.Black), new Point(C.X + 4, C.Y - 15));

        }
        //=================================================================================

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hinh1button2D_Click(object sender, EventArgs e)
        {
            this.panel1.Refresh();
            trangThaiNut = 1;
            resetLabelToado();
            g = this.panel1.CreateGraphics();
            veChongChong(new SolidBrush(Color.Black), new SolidBrush(Color.Blue), new SolidBrush(Color.Green), new SolidBrush(Color.Red), new SolidBrush(Color.Yellow));
            veDoremon(new SolidBrush(Color.Black), new SolidBrush(Color.White), new SolidBrush(Color.Aqua), new SolidBrush(Color.Red));
        }

        private void hinh2button2D_Click(object sender, EventArgs e)
        {
            this.panel1.Refresh();
            trangThaiNut = 2;
            resetLabelToado();
            g = this.panel1.CreateGraphics();
            g.FillRectangle(new SolidBrush(Color.Cyan), 0, 0, 800, 800);
            g.FillRectangle(new SolidBrush(Color.BurlyWood), 0, 570, 800, 800);
            veDuongThang(new Point(0, 570), new Point(800, 570), Color.Black);
            //ve mat troi
            veMatTroi(0);

            //ve chau
            veChau(new Point(300, 500), Color.SaddleBrown);

            //ve la
            veLa(new Point(390, 495), Color.Green);

            //ve hoa
            veHoa(new Point(390, 495), new Point(350, 400), new Point(380, 350), new Point(420, 400), 1, Color.Green, Color.Red);

        }

        private void hinh3button2D_Click(object sender, EventArgs e)
        {
            trangThaiNut = 3;
            resetLabelToado();
            this.panel1.Refresh();
            g = this.panel1.CreateGraphics();
            int r = 40;
            Color c = Color.Black;
            Color m = Color.Lime;
            veDay();
            VeMay2();
            veNgoiSao();
            toMauConLac();
            toMauNui(m);
            veNui(m);
            Point p1 = new Point(240, 300);
            Point p2 = new Point(320, 300);
            Point p3 = new Point(400, 300);
            Point p4 = doiXungQuaOy(p2);
            Point p5 = doiXungQuaOy(p1);
            veConLac(p1, r, c);//lac 1
            veConLac(p2, r, c);//lac 2
            veConLac(p3, r, c);//lac 3
            veConLac(p4, r, c);//lac 4
            veConLac(p5, r, c);//lac 5
        }

        private void hinh1button3D_Click(object sender, EventArgs e) // hinh hop
        {
            trangThaiNut = 4;
            panel1.Refresh();
            veLuoi3D();
            this.panel4.Visible = true;
            label_bankinh3D.Visible = false;
            bankinh3D.Visible = false;
            label_chieudai3D.Visible = true;
            label_chieurong3D.Visible = true;
            label_chieucao3D.Visible = true;
            chieudai3D.Visible = true;
            chieurong3D.Visible = true;
            chieucao3D.Visible = true;
        }

        private void hinh2button3D_Click(object sender, EventArgs e) // hinh cau
        {
            trangThaiNut = 5;
            panel1.Refresh();
            veLuoi3D();
            this.panel4.Visible = true;
            label_chieudai3D.Visible = false;
            label_chieurong3D.Visible = false;
            label_chieucao3D.Visible = false;
            chieudai3D.Visible = false;
            chieurong3D.Visible = false;
            chieucao3D.Visible = false;
            label_bankinh3D.Visible = true;
            bankinh3D.Visible = true;

        }

        private void hinh3Button3D_Click(object sender, EventArgs e)
        {
            trangThaiNut = 6;
            panel1.Refresh();
            veLuoi3D();
            this.panel4.Visible = true;
            label_bankinh3D.Visible = true;
            bankinh3D.Visible = true;
            label_chieucao3D.Visible = false;
            label_chieurong3D.Visible = false;
            chieudai3D.Visible = false;
            label_chieudai3D.Visible = false;
            chieurong3D.Visible = false;
            label_chieurong3D.Visible = false;
            label_chieucao3D.Visible = true;
            chieucao3D.Visible = true;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            veLuoi3D();
            switch (trangThaiNut)
            {
                case 1:
                    {
                        veHCN(0, 0, 165, 165, new SolidBrush(Color.White));
                        veDoremon(new SolidBrush(Color.Black), new SolidBrush(Color.White), new SolidBrush(Color.Aqua), new SolidBrush(Color.Red));
                        for (int i = 0; i <= 40; i++)
                        {
                            veHCN(0, 0, 165, 105, new SolidBrush(Color.White));
                            p1 = quayMotDiem(p1, O, 20 + "");
                            p2 = quayMotDiem(p2, O, 20 + "");
                            p3 = quayMotDiem(p3, O, 20 + "");
                            veChongChong(new SolidBrush(Color.Black), new SolidBrush(Color.Blue), new SolidBrush(Color.Green), new SolidBrush(Color.Red), new SolidBrush(Color.Yellow));
                            Thread.Sleep(120);
                        }
                    }
                    break;
                case 2:
                    {
                        g = this.panel1.CreateGraphics();
                        g.FillRectangle(new SolidBrush(Color.Cyan), 0, 0, 800, 800);
                        g.FillRectangle(new SolidBrush(Color.BurlyWood), 0, 570, 800, 800);
                        veDuongThang(new Point(0, 570), new Point(800, 570), Color.Black);
                        veChauHoa();
                    }
                    break;
                case 3:
                    timer1.Start();
                    break;
                case 4:
                    {
                        if (x3D.Text == "" || y3D.Text == "" || z3D.Text == "" || chieudai3D.Text == "" || chieurong3D.Text == "" || chieucao3D.Text == "")
                        {
                            MessageBox.Show("Vị trí và kích thước nhập vào không được bỏ trống!", "!!!");
                        }
                        else if (int.Parse(x3D.Text) > 80 || int.Parse(x3D.Text) < -80 || int.Parse(y3D.Text) > 80 || int.Parse(y3D.Text) < -80 || int.Parse(z3D.Text) > 80 || int.Parse(z3D.Text) < -80 || int.Parse(chieudai3D.Text) > 80 || int.Parse(chieudai3D.Text) < -80 || int.Parse(chieurong3D.Text) > 80 || int.Parse(chieurong3D.Text) < -80 || int.Parse(chieucao3D.Text) > 80 || int.Parse(chieucao3D.Text) < -80)
                        {
                            MessageBox.Show("Vị trí và kích thước nhập vào không được lớn hơn 80 và nhỏ hơn -80!", "!!!");
                        }
                        else
                        {
                            resetLabelToado();
                            veHinhHop(int.Parse(x3D.Text), int.Parse(y3D.Text), int.Parse(z3D.Text), int.Parse(chieudai3D.Text), int.Parse(chieurong3D.Text), int.Parse(chieucao3D.Text));
                        }
                    }
                    break;
                case 5:
                    {
                        if (x3D.Text == "" || y3D.Text == "" || z3D.Text == "" || bankinh3D.Text == "")
                        {
                            MessageBox.Show("Vị trí và kích thước nhập vào không được bỏ trống!", "!!!");
                        }
                        else if (int.Parse(x3D.Text) > 80 || int.Parse(x3D.Text) < -80 || int.Parse(y3D.Text) > 80 || int.Parse(y3D.Text) < -80 || int.Parse(z3D.Text) > 80 || int.Parse(z3D.Text) < -80 || int.Parse(bankinh3D.Text) > 80 || int.Parse(bankinh3D.Text) < -80)
                        {
                            MessageBox.Show("Vị trí và kích thước nhập vào không được lớn hơn 80 và nhỏ hơn -80!", "!!!");
                        }
                        else
                        {
                            resetLabelToado();
                            int x = Convert.ToInt32(x3D.Text);
                            int y = Convert.ToInt32(y3D.Text);
                            int z = Convert.ToInt32(z3D.Text);
                            int r = Convert.ToInt32(bankinh3D.Text);
                            label_toado5.Text = "BÁN KÍNH R = " + r;
                            label_toado1.Text = "TÂM HÌNH CẦU TÂM O";
                            label_toado2.Text = "X = " + x;
                            label_toado3.Text = "Y = " + y;
                            label_toado4.Text = "Z = " + z;

                            r = r * 5;
                            Point p = Cabinet(x, y, z);
                            int x1 = 400 + 5 * p.X;
                            int y1 = 400 - 5 * p.Y;
                            Point p1 = new Point(x1, y1);
                            draw(p1, r);
                        }
                    }
                    break;
                case 6:
                    {
                        if (x3D.Text == "" || y3D.Text == "" || z3D.Text == "" || bankinh3D.Text == "" || chieucao3D.Text == "")
                        {
                            MessageBox.Show("Vị trí và kích thước nhập vào không được bỏ trống!", "!!!");
                        }
                        else if (int.Parse(x3D.Text) > 80 || int.Parse(x3D.Text) < -80 || int.Parse(y3D.Text) > 80 || int.Parse(y3D.Text) < -80 || int.Parse(z3D.Text) > 80 || int.Parse(z3D.Text) < -80 || int.Parse(chieucao3D.Text) > 80 || int.Parse(chieucao3D.Text) < -80 || int.Parse(bankinh3D.Text) > 80 || int.Parse(bankinh3D.Text) < -80)
                        {
                            MessageBox.Show("Vị trí và kích thước nhập vào không được lớn hơn 80 và nhỏ hơn -80!", "!!!");
                        }
                        else
                        {
                            resetLabelToado();
                            veHinhNon(int.Parse(x3D.Text), int.Parse(y3D.Text), int.Parse(z3D.Text), int.Parse(bankinh3D.Text), int.Parse(chieucao3D.Text));
                        }
                    }
                    break;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.panel1.Refresh();
            resetLabelToado();
            panel1.BackColor = Color.WhiteSmoke;
            x3D.Text = "";
            y3D.Text = "";
            z3D.Text = "";
            chieudai3D.Text = "";
            chieucao3D.Text = "";
            chieurong3D.Text = "";
            bankinh3D.Text = "";
        }
    }
}
