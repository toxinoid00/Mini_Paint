using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//authors : Muhammad Husain Fadhlullah
//NIM : 141524017
//3A-D4 Teknik Informatika Politeknik Negeri Bandung
//Komputer Grafik

namespace Mini_Paint
{
    public partial class Form1 : Form
    {
        Point start_point;
        Point end_point;
        int zoom;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs     e)
        {
            zoom = Convert.ToInt16(tb_zoom.Text);
                if (start_point != null & end_point != null)
                {
                    //modul draw line - bresenham
                    if (rb_bresenham.Checked)//Bresenha algorithm for lines
                    {
                        Point point1 = new Point(start_point.X, start_point.Y);
                        Point point2 = new Point(end_point.X, end_point.Y);
                        //for 360 works:
                        bool rotation = Math.Abs(point2.Y - point1.Y) > Math.Abs(point2.X - point1.X);
                        if (rotation == true)
                        {
                            //turn rotate of line - change x and y
                            Point tmp = new Point(point1.X, point1.Y);
                            point1 = new Point(tmp.Y, tmp.X);

                            tmp = point2;
                            point2 = new Point(tmp.Y, tmp.X);
                        }
                        int deltaX = Math.Abs(point2.X - point1.X);
                        int deltaY = Math.Abs(point2.Y - point1.Y);
                        int mistake = 0;
                        int deltaMistake = deltaY;
                        int stepY = 0;
                        int stepX = 0;
                        int y = point1.Y;
                        int x = point1.X;

                        //Determines the direction of movement Y
                        if (point1.Y < point2.Y)
                        {
                            stepY = 1;
                        }
                        else
                        {
                            stepY = -1;
                        }

                        //Determines the direction of movement X
                        if (point1.X < point2.X)
                        {
                            stepX = 1;
                        }
                        else
                        {
                            stepX = -1;
                        }

                        int tmpX = 0;
                        int tmpY = 0;
                        while (x != point2.X) //moving on x coordinate
                        {
                            x += stepX;
                            mistake += deltaMistake;
                            if ((2 * mistake) > deltaX) //mistake - moving y coordinate
                            {
                                y += stepY;
                                mistake -= deltaX;
                            }
                            //rotate coordinate if I change earlier
                            if (rotation == true)
                            {
                                tmpX = y;
                                tmpY = x;
                            }
                            else
                            {
                                tmpX = x;
                                tmpY = y;
                            }
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(tmpX * zoom, tmpY * zoom, 4, 4));
                        }
                    }
                    //modul draw line - native
                    if (rb_native.Checked)
                    {
                        Point point1 = new Point(start_point.X, start_point.Y);
                        Point point2 = new Point(end_point.X, end_point.Y);
                        int Dx = point2.X - point1.X;
                        int Dy = point2.Y - point1.Y;
                        float m;
                        if ((point2.X - point1.X) == 0)
                        {
                            m = point1.X;
                        }
                        else
                        {
                            m = (point2.Y - point1.Y) / (point2.X - point1.X);
                        }
                        float c = point1.Y - (m * point1.X);
                        float x = point1.X, y = point1.Y;
                        float x2 = x;
                        float y2 = y;
                        y2 = (m * x2) + c;
                        x2 = (y2 - c) / m;
                        int stepX = 0;
                        int stepY = 0;
                        if (point1.Y < point2.Y)
                        {
                            stepY = 1;
                        }
                        else
                        {
                            stepY = -1;
                        }

                        //Determines the direction of movement X
                        if (point1.X < point2.X)
                        {
                            stepX = 1;
                        }
                        else
                        {
                            stepX = -1;
                        }
                        if (point1.X < point2.X)
                        {
                            while (x2 <= point2.X && y2 <= point2.Y)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle((int)x2 * zoom, (int)x2 * zoom, 4, 4));
                                x2 += stepX;
                                y2 += stepY;
                            }
                        }
                        else
                        {
                            while (x2 >= point2.X && y2 >= point2.Y)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle((int)x2 * zoom, (int)x2 * zoom, 4, 4));
                                x2 += stepX;
                                y2 += stepY;
                            }
                        }

                    }
                    //modul draw circle
                    if (rb_circle.Checked)
                    {
                        if (cb_aa_circle.Checked)
                        {
                            int offset_x = start_point.X;
                            int offset_y = start_point.Y;
                            Color color = Color.Black;
                            int r = (int)Math.Sqrt(Math.Pow(start_point.X - end_point.X, 2) + Math.Pow(start_point.Y - end_point.Y, 2));//polmer
                            int x = r;
                            int y = -1;
                            double t = 0;
                            while (x - 1 > y)
                            {
                                y++;
                                double current_distance = distance(r, y);
                                if (current_distance < t)
                                {
                                    x--;
                                }
                                //shades
                                int transparency = new_color(current_distance);
                                int alpha = transparency;
                                int alpha2 = 127 - transparency;
                                Color c2 = Color.FromArgb(255, color.R, color.G, color.B);
                                Color c3 = Color.FromArgb(alpha2, color.R, color.G, color.B);
                                Color c4 = Color.FromArgb(alpha, color.R, color.G, color.B);

                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((x + offset_x) * zoom, (y + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((x + offset_x - 1) * zoom, (y + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((x + offset_x + 1) * zoom, (y + offset_y) * zoom, 4, 4));

                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((y + offset_x) * zoom, (x + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((y + offset_x) * zoom, (x + offset_y - 1) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((y + offset_x) * zoom, (x + offset_y + 1) * zoom, 4, 4));

                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((offset_x - x) * zoom, (y + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((offset_x - x + 1) * zoom, (y + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((offset_x - x - 1) * zoom, (y + offset_y) * zoom, 4, 4));

                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((offset_x - y) * zoom, (x + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((offset_x - y) * zoom, (x + offset_y - 1) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((offset_x - y) * zoom, (x + offset_y + 1) * zoom, 4, 4));

                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((x + offset_x) * zoom, (offset_y - y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((x + offset_x - 1) * zoom, (offset_y - y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((x + offset_x + 1) * zoom, (offset_y - y) * zoom, 4, 4));

                                //UP
                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((y + offset_x) * zoom, (offset_y - x) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((y + offset_x) * zoom, (offset_y - x - 1) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((y + offset_x) * zoom, (offset_y - x + 1) * zoom, 4, 4));

                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((offset_x - y) * zoom, (offset_y - x) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((offset_x - y) * zoom, (offset_y - x - 1) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((offset_x - y) * zoom, (offset_y - x + 1) * zoom, 4, 4));

                                e.Graphics.FillRectangle(new SolidBrush(c2), new Rectangle((offset_x - x) * zoom, (offset_y - y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c3), new Rectangle((offset_x - x - 1) * zoom, (offset_y - y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(c4), new Rectangle((offset_x - x + 1) * zoom, (offset_y - y) * zoom, 4, 4));
                                t = current_distance;
                            }
                        }
                        else {
                            int offset_x = start_point.X;
                            int offset_y = start_point.Y;
                            Color color = Color.Black;
                            int r = (int)Math.Sqrt(Math.Pow(start_point.X - end_point.X, 2) + Math.Pow(start_point.Y - end_point.Y, 2));//polmer
                            int x = r;
                            int y = -1;
                            double t = 0;
                            while (x - 1 > y)
                            {
                                y++;
                                double current_distance = distance(r, y);
                                if (current_distance < t)
                                {
                                    x--;
                                }

                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((x + offset_x) * zoom, (y + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((y + offset_x) * zoom, (x + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - x) * zoom, (y + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - y) * zoom, (x + offset_y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((x + offset_x) * zoom, (offset_y - y) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((y + offset_x) * zoom, (offset_y - x) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - y) * zoom, (offset_y - x) * zoom, 4, 4));
                                e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - x) * zoom, (offset_y - y) * zoom, 4, 4));

                                t = current_distance;
                            }
                        }
                    }
                    //modul draw line - dda
                    if (rb_dda.Checked)
                    {

                        //double rotasi = -0.25 * Math.PI;
                        Color color = Color.Black;
                        Pen myPen = new Pen(Color.Black);
                        int Xawal = start_point.X;
                        int Yawal = start_point.Y;
                        int Xakhir = end_point.X;
                        int Yakhir = end_point.Y;
                        int Dx = Xakhir - Xawal;
                        int Dy = Yakhir - Yawal;
                        float r;
                        int k;
                        float xI, yI, x = Xawal, y = Yawal;
                        double x1 = Xawal, y1 = Yawal;
                        if (Math.Abs(Dx) > Math.Abs(Dy))
                        {
                            r = Math.Abs(Dx);
                        }
                        else
                        {
                            r = Math.Abs(Dy);
                        }
                        xI = Dx / r;
                        yI = Dy / r;
                    //int[,] a = new int[3, 1];
                    //a = Rotasi((int)x, (int)y);
                    if (rb_rotasi.Checked)
                    {
                        xI = Dx / r;
                        yI = Dy / r;
                        double rotasi = -Convert.ToDouble(tb_rotasi.Text) / 180 * Math.PI;
                        for (k = 0; k < r; k++)
                        {
                            x += xI;
                            y += yI;
                            x1 += xI * Math.Cos(rotasi) - yI * Math.Sin(rotasi);
                            y1 += xI * Math.Sin(rotasi) + yI * Math.Cos(rotasi);
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((int)(x * zoom), (int)(y * zoom), 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((int)(x1 * zoom), (int)(y1 * zoom), 4, 4));
                        }
                    }
                    if (rb_translasi.Checked)
                    {
                        xI = Dx / r;
                        yI = Dy / r;
                        int new_x = Convert.ToInt16(tb_translasi_x.Text);
                        int new_y = Convert.ToInt16(tb_translasi_y.Text);
                        x1 = new_x + start_point.X;
                        y1 = new_x + start_point.Y;
                        for (k = 0; k < r; k++)
                        {
                            x += xI;
                            y += yI;
                            x1 += xI;
                            y1 += yI;

                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((int)(x * zoom), (int)(y * zoom), 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((int)(x1 * zoom), (int)(y1 * zoom), 4, 4));
                        }
                    }
                    if (rb_dilatasi.Checked)
                    {
                        xI = Dx / r;
                        yI = Dy / r;
                        for (k = 0; k < r * Convert.ToInt16(tb_dilatasi.Text); k++)
                        {
                            x += xI;
                            y += yI;
                            x1 += xI;
                            y1 += yI;

                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((int)(x * zoom), (int)(y * zoom), 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((int)(x1 * zoom), (int)(y1 * zoom), 4, 4));
                        }
                    }
                    else
                    {
                        xI = Dx / r;
                        yI = Dy / r;
                        for (k = 0; k < r; k++)
                        {
                            x += xI;
                            y += yI;
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((int)(x * zoom), (int)(y * zoom), 4, 4));
                        }
                        //e.Graphics.DrawLine(myPen, Xawal, Yawal, a[0, 0], a[1, 0]);
                    }

                }
                    //modul draw polygon
                    if (rb_polygon.Checked)
                    {
                    if (rb_floodfill.Checked)
                    {
                        using (Bitmap bitmap = new Bitmap(1000, 1000))
                        {
                            using (Graphics g = Graphics.FromImage(bitmap))
                            {
                                int num_points = Convert.ToInt16(nud_polygon.Value);
                                PointF[] pts = new PointF[num_points];
                                Pen myPen = new Pen(Color.Black);
                                Color color = Color.Black;
                                double rx = getRadiusX(start_point.X * zoom, end_point.X * zoom);
                                double ry = getRadiusY(start_point.Y * zoom, end_point.Y * zoom);
                                double cx = start_point.X * zoom;
                                double cy = start_point.Y * zoom;
                                double alpha = -Math.PI / 2; //starting point
                                double theta = 2 * Math.PI / num_points;
                                //rotasi
                                //Rumus SMA :
                                //Pi = O + R * (d / R) ^ mod[i, 2] * (cos(2 π / n + π / n * i),sin(2 π / n + π / n * i)); i = 0,1,….2n - 1
                                for (int i = 0; i < num_points; i++)
                                {
                                    pts[i] = new PointF(
                                        (float)(cx + rx * Math.Cos(alpha)),
                                        (float)(cy + ry * Math.Sin(alpha)));
                                    alpha += theta;
                                }
                                g.DrawPolygon(myPen, pts);
                            }
                            FloodFill(bitmap, 200, 200, Color.Yellow);

                            e.Graphics.DrawImage(bitmap, 0, 0);
                        }
                    }
                    else
                    {
                        int num_points = Convert.ToInt16(nud_polygon.Value);
                        PointF[] pts = new PointF[num_points];
                        Pen myPen = new Pen(Color.Black);
                        Color color = Color.Black;
                        double rx = getRadiusX(start_point.X * zoom, end_point.X * zoom);
                        double ry = getRadiusY(start_point.Y * zoom, end_point.Y * zoom);
                        double cx = start_point.X * zoom;
                        double cy = start_point.Y * zoom;
                        double alpha = -Math.PI / 2; //starting point
                        double theta = 2 * Math.PI / num_points;
                        //rotasi
                        //Rumus SMA :
                        //Pi = O + R * (d / R) ^ mod[i, 2] * (cos(2 π / n + π / n * i),sin(2 π / n + π / n * i)); i = 0,1,….2n - 1
                        for (int i = 0; i < num_points; i++)
                        {
                            pts[i] = new PointF(
                                (float)(cx + rx * Math.Cos(alpha)),
                                (float)(cy + ry * Math.Sin(alpha)));
                            alpha += theta;
                        }
                        e.Graphics.DrawPolygon(myPen, pts);
                    }

                    }
                    //modul draw star
                    if (rb_star.Checked)
                    {
                        int num_points = Convert.ToInt16(nud_polygon.Value);
                        PointF[] pts = new PointF[num_points];
                        Pen myPen = new Pen(Color.Black);
                        Color color = Color.Black;
                        int rx = getRadiusX(start_point.X * zoom, end_point.X * zoom);
                        int ry = getRadiusY(start_point.Y * zoom, end_point.Y * zoom);
                        int cx = start_point.X * zoom;
                        int cy = start_point.Y * zoom;
                        double alpha = -Math.PI / 2; //starting point
                        double theta = 4 * Math.PI / num_points;
                        //rotasi
                        //Rumus SMA :
                        //Pi = O + R * (d / R) ^ mod[i, 2] * (cos(2 π / n + π / n * i),sin(2 π / n + π / n * i)); i = 0,1,….2n - 1
                        for (int i = 0; i < num_points; i++)
                        {
                            pts[i] = new PointF(
                                (float)(cx + rx * Math.Cos(alpha)),
                                (float)(cy + ry * Math.Sin(alpha)));
                            alpha += theta;
                        }
                        e.Graphics.DrawPolygon(myPen, pts);
                    }
                    //modul draw elips
                    if (rb_elips.Checked)
                    {
                        Color color = Color.Black;
                        int offset_x = start_point.X;
                        int offset_y = start_point.Y;
                        int radiusX = getRadiusX(start_point.X, end_point.X);
                        int radiusY = getRadiusY(start_point.Y, end_point.Y);
                        double d;
                        int x = 0;
                        int y = radiusY;
                        d = Math.Pow(radiusY, 2) - Math.Pow(radiusX, 2) * radiusY + 0.25 * Math.Pow(radiusX, 2);
                        while (2 * Math.Pow(radiusY, 2) * x < 2 * Math.Pow(radiusX, 2) * y)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x + x) * zoom, (offset_y + y) * zoom, 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - x) * zoom, (offset_y + y) * zoom, 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x + x) * zoom, (offset_y - y) * zoom, 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - x) * zoom, (offset_y - y) * zoom, 4, 4));
                            if (d < 0)
                            {
                                d = d + 2 * (Math.Pow(radiusY, 2) * x + Math.Pow(radiusY, 2)) + Math.Pow(radiusY, 2);
                            }
                            else
                            {
                                d = d + 2 * (Math.Pow(radiusY, 2) * x + Math.Pow(radiusY, 2)) - 2 * (Math.Pow(radiusX, 2) * y - Math.Pow(radiusX, 2)) + Math.Pow(radiusY, 2);
                                y--;
                            }
                            x++;
                        }
                        d = Math.Pow(radiusY, 2) * Math.Pow((x + 0.5), 2) + Math.Pow(radiusX, 2) * Math.Pow((y - 1), 2) - Math.Pow(radiusY, 2) * Math.Pow(radiusX, 2);
                        while (y > 0)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x + x) * zoom, (offset_y + y) * zoom, 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - x) * zoom, (offset_y + y) * zoom, 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x + x) * zoom, (offset_y - y) * zoom, 4, 4));
                            e.Graphics.FillRectangle(new SolidBrush(color), new Rectangle((offset_x - x) * zoom, (offset_y - y) * zoom, 4, 4));
                            if (d > 0)
                            {
                                d = d - 2 * (Math.Pow(radiusX, 2) * y - Math.Pow(radiusX, 2)) + Math.Pow(radiusX, 2);
                            }
                            else
                            {
                                d = d + 2 * (Math.Pow(radiusY, 2) * x + Math.Pow(radiusY, 2)) - (Math.Pow(radiusX, 2) * y - Math.Pow(radiusX, 2)) + Math.Pow(radiusX, 2);
                                x++;
                            }
                            y--;
                        }
                    }
                }
        }

        //declare starting point
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            zoom = Convert.ToInt16(tb_zoom.Text);
            if (e.Button == MouseButtons.Left)
            {
                start_point = new Point(e.X / zoom, e.Y / zoom);
                l_x1.Text = Convert.ToString(start_point.X);
                l_y1.Text = Convert.ToString(start_point.Y);
            }
        }
        //declare end point
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                end_point = new Point(e.X / zoom, e.Y / zoom);
                l_x2.Text = Convert.ToString(end_point.X);
                l_y2.Text = Convert.ToString(end_point.Y);
                pictureBox1.Invalidate();
            }
        }
        //distance
        double distance(int x, int y)
        {
            double real_point = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(y, 2));
            return (Math.Ceiling(real_point) - real_point);
        }
        //new color for anti-aliasing
        int new_color(double i)
        {
            return (int)Math.Round((i * 127));
        }
        //getRadiusX
        int getRadiusX(int x1, int x2)
        {
            return Math.Abs(x2 - x1);
        }
        //getRadiusY
        int getRadiusY(int y1, int y2)
        {
            return Math.Abs(y2 - y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            zoom = Convert.ToInt16(tb_zoom.Text);
            if (start_point != null & end_point != null)
            {
                if (tb_translasi_x != null && tb_translasi_y != null)
                {

                    clearscreen();
                }
                if (tb_dilatasi != null)
                {

                    clearscreen();
                }
                if (tb_shearing_x != null && tb_shearing_y != null)
                {

                    clearscreen();
                }
                if (tb_rotasi != null)
                {

                    clearscreen();
                }
            }
        }
        private void clearscreen()
        {
            tb_dilatasi.Text = "";
            tb_rotasi.Text = "";
            tb_shearing_x.Text = "";
            tb_shearing_y.Text = "";
            tb_translasi_x.Text = "";
            tb_translasi_y.Text = "";
        }
        private int[,] Translasi(int x, int y)
        {
                int[,] a1 = new int[3, 3];
                a1[0, 0] = 1;
                a1[0, 1] = 0;
                a1[0, 2] = Convert.ToInt16(tb_translasi_x.Text);
                a1[1, 0] = 0;
                a1[1, 1] = 1;
                a1[1, 2] = Convert.ToInt16(tb_translasi_y.Text);
                a1[2, 0] = 0;
                a1[2, 1] = 0;
                a1[2, 2] = 1;

                int[,] a2 = new int[3, 1];
                a2[0, 0] = x;
                a2[1, 0] = y;
                a2[2, 0] = 1;

                int[,] a3 = new int[3, 1];
                a3[0, 0] = a1[0, 0] * a2[0, 0] + a1[0, 1] * a2[1, 0] + a1[0, 2] * a2[2, 0];
                a3[1, 0] = a1[1, 0] * a2[0, 0] + a1[1, 1] * a2[1, 0] + a1[1, 2] * a2[2, 0];
                a3[2, 0] = 1;
            
            return a3;
        }
        private int[,] Dilatasi(int x, int y)
        {
            int[,] a1 = new int[3, 3];
            a1[0, 0] = Convert.ToInt16(tb_dilatasi.Text);
            a1[0, 1] = 0;
            a1[0, 2] = 0;
            a1[1, 0] = Convert.ToInt16(tb_dilatasi.Text);
            a1[1, 1] = 0;
            a1[1, 2] = 0;
            a1[2, 0] = 0;
            a1[2, 1] = 0;
            a1[2, 2] = 1;

            int[,] a2 = new int[3, 1];
            a2[0, 0] = x;
            a2[1, 0] = y;
            a2[2, 0] = 1;

            int[,] a3 = new int[3, 1];
            a3[0, 0] = a1[0, 0] * a2[0, 0] + a1[0, 1] * a2[1, 0] + a1[0, 2] * a2[2, 0];
            a3[1, 0] = a1[1, 0] * a2[0, 0] + a1[1, 1] * a2[1, 0] + a1[1, 2] * a2[2, 0];
            a3[2, 0] = 1;

            return a3;
        }
        private int[,] Rotasi(int x, int y)
        {
            int[,] a1 = new int[3, 3];
            a1[0, 0] = (int)Math.Cos(Math.PI/Convert.ToDouble(tb_rotasi.Text));
            a1[0, 1] = (int)Math.Sin(Math.PI / Convert.ToDouble(tb_rotasi.Text));
            a1[0, 2] = 0;
            a1[1, 0] = -(int)Math.Sin(Math.PI / Convert.ToDouble(tb_rotasi.Text));
            a1[1, 1] = (int)Math.Cos(Math.PI / Convert.ToDouble(tb_rotasi.Text));
            a1[1, 2] = 0;
            a1[2, 0] = 0;
            a1[2, 1] = 0;
            a1[2, 2] = 1;

            int[,] a2 = new int[3, 1];
            a2[0, 0] = x;
            a2[1, 0] = y;
            a2[2, 0] = 1;

            int[,] a3 = new int[3, 1];
            a3[0, 0] = a1[0, 0] * a2[0, 0] + a1[0, 1] * a2[1, 0] + a1[0, 2] * a2[2, 0];
            a3[1, 0] = a1[1, 0] * a2[0, 0] + a1[1, 1] * a2[1, 0] + a1[1, 2] * a2[2, 0];
            a3[2, 0] = 1;

            return a3;
        }
        private int[,] Shearing(int x, int y)
        {
            int[,] a1 = new int[3, 3];
            a1[0, 0] = 1;
            a1[0, 1] = Convert.ToInt16(tb_shearing_x.Text);
            a1[0, 2] = 0;
            a1[1, 0] = Convert.ToInt16(tb_shearing_y.Text);
            a1[1, 1] = 1;
            a1[1, 2] = 0;
            a1[2, 0] = 0;
            a1[2, 1] = 0;
            a1[2, 2] = 1;

            int[,] a2 = new int[3, 1];
            a2[0, 0] = x;
            a2[1, 0] = y;
            a2[2, 0] = 1;

            int[,] a3 = new int[3, 1];
            a3[0, 0] = a1[0, 0] * a2[0, 0] + a1[0, 1] * a2[1, 0] + a1[0, 2] * a2[2, 0];
            a3[1, 0] = a1[1, 0] * a2[0, 0] + a1[1, 1] * a2[1, 0] + a1[1, 2] * a2[2, 0];
            a3[2, 0] = 1;

            return a3;
        }
        void FloodFill(Bitmap bitmap, int x, int y, Color color)
        {
            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1),
                new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }

        private void tb_rotasi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}