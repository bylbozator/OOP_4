using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Создаем объект Graphics для рисования на форме
            Graphics g = e.Graphics;

            // Задаем цвета для карандаша и кисти
            Color penColor = Color.Black;
            Color brushColor = Color.Blue;

            // Создаем объект карандаша с заданным цветом и толщиной линии
            Pen pen = new Pen(penColor, 2);

            // Рисуем крышу домика - треугольник с координатами вершин
            Point[] roofPoints = { new Point(150, 100), new Point(200, 50), new Point(250, 100) };
            g.DrawPolygon(pen, roofPoints);

            // Рисуем стены домика - прямоугольник с заданными координатами и размерами
            Rectangle walls = new Rectangle(150, 100, 100, 100);
            g.DrawRectangle(pen, walls);

            // Рисуем окно - прямоугольник с заданными координатами и размерами
            Rectangle window = new Rectangle(170, 120, 30, 30);
            g.DrawRectangle(pen, window);

            // Рисуем дверь - прямоугольник с заданными координатами и размерами
            Rectangle door = new Rectangle(210, 150, 30, 50);
            g.DrawRectangle(pen, door);

            // Создаем объект кисти с заданным цветом
            SolidBrush brush = new SolidBrush(brushColor);

            // Закрашиваем окно и дверь кистью
            g.FillRectangle(brush, window);
            g.FillRectangle(brush, door);

            // Изменяем цвет карандаша на красный
            pen.Color = Color.Red;

            // Рисуем дымоход - прямая линия с заданными координатами
            g.DrawLine(pen, 200, 50, 200, 30);

            // Изменяем стиль линии на штрих-пунктирный
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

            // Рисуем трубу на дымоходе - эллипс с заданными координатами и размерами
            Rectangle chimney = new Rectangle(190, 20, 20, 10);
            g.DrawEllipse(pen, chimney);
        }
    }
}




