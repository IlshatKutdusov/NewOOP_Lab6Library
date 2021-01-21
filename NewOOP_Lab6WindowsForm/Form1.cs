using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab6Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int redcolor = 0, greencolor = 0, bluecolor = 0;

        private int i = -1, k = -1, p, kcircle = -1, ktriangle = -1, krectangle = -1, kellipse = -1, kparallelogram = -1;

        private MyList<Figure> list = new MyList<Figure>();

        private Circle circle;
        private Triangle triangle;
        private Rectangle rectangle;
        private Ellipse ellipse;
        private Parallelogram parallelogram;
        private Random randomint = new Random();

        private void UpDate()
        {
            pictureBox1.Image = null;
            for (int i = 0; i < list.Count(); i++)
            {
                list[i].Show(pictureBox1);
            }
        }

        private void EnableFunc()
        {
            if (button2.Enabled == false)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;
            }
        }

        private void ShowHide(int v)
        {
            if (v == 1)
            {
                foreach (Figure figure in list)
                {
                    if (checkBox1.Checked == true)
                    {
                        if (figure is Circle)
                        {
                            if ((figure is Ellipse) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox2.Checked == true)
                    {
                        if (figure is Triangle)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox3.Checked == true)
                    {
                        if (figure is Rectangle)
                        {
                            if ((figure is Parallelogram) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox4.Checked == true)
                    {
                        if (figure is Ellipse)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox5.Checked == true)
                    {
                        if (figure is Parallelogram)
                        {
                            figure.Visibility();
                        }
                    }
                }
            }
            if (v == 2)
            {
                foreach (Figure figure in list)
                {
                    if (checkBox6.Checked == true)
                    {
                        if (figure is Circle)
                        {
                            if ((figure is Ellipse) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox7.Checked == true)
                    {
                        if (figure is Triangle)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox8.Checked == true)
                    {
                        if (figure is Rectangle)
                        {
                            if ((figure is Parallelogram) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox9.Checked == true)
                    {
                        if (figure is Ellipse)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox10.Checked == true)
                    {
                        if (figure is Parallelogram)
                        {
                            figure.Visibility();
                        }
                    }
                }
            }
        }

        private void MoveFigure(int dx, int dy, PictureBox picBox)
        {
            foreach (Figure figure in list)
            {
                if (checkBox1.Checked == true)
                {
                    if (figure is Circle)
                    {
                        if ((figure is Ellipse) == false)
                        {
                            figure.MoveTo(dx, dy, picBox);
                        }
                    }
                }
                if (checkBox2.Checked == true)
                {
                    if (figure is Triangle)
                    {
                        figure.MoveTo(dx, dy, picBox);
                    }
                }
                if (checkBox3.Checked == true)
                {
                    if (figure is Rectangle)
                    {
                        if ((figure is Parallelogram) == false)
                        {
                            figure.MoveTo(dx, dy, picBox);
                        }
                    }
                }
                if (checkBox4.Checked == true)
                {
                    if (figure is Ellipse)
                    {
                        figure.MoveTo(dx, dy, picBox);
                    }
                }
                if (checkBox5.Checked == true)
                {
                    if (figure is Parallelogram)
                    {
                        figure.MoveTo(dx, dy, picBox);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 20; j++)
            {
                p = randomint.Next(0, 5);
                switch (p)
                {
                    case 0:
                        circle = new Circle();
                        circle.Show(pictureBox1);
                        list.Add(circle);
                        break;
                    case 1:
                        triangle = new Triangle();
                        triangle.Show(pictureBox1);
                        list.Add(triangle);
                        break;
                    case 2:
                        rectangle = new Rectangle();
                        rectangle.Show(pictureBox1);
                        list.Add(rectangle);
                        break;
                    case 3:
                        ellipse = new Ellipse();
                        ellipse.Show(pictureBox1);
                        list.Add(ellipse);
                        break;
                    case 4:
                        parallelogram = new Parallelogram();
                        parallelogram.Show(pictureBox1);
                        list.Add(parallelogram);
                        break;
                    default:
                        MessageBox.Show("Ошибка! Вне границ выбора фигур!");
                        break;
                }
                System.Threading.Thread.Sleep(10);
            }
            EnableFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true)
            {
                ShowHide(1);
                UpDate();
                MoveFigure(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
            }
            else
            {
                MessageBox.Show("Нужно выбрать тип фигуру!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true)
            {
                ShowHide(2);
                UpDate();
            }
            else
            {
                MessageBox.Show("Нужно выбрать тип фигур!");
            }
        }
    }
}

















