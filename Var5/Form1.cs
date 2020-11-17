using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_5;

namespace Var5
{
    public partial class Form1 : Form
    {
        // описали глобальный объект класса Triangle
        /*Lib_5.Triangle triangle;*/
        Lib_5.Equilateral equilateral;
        public Form1()
        {
            InitializeComponent();
        }
        // о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Ефимкина Марина. ИСП-31. Вариант 5:Создать класс Triangle (треугольник) с полями-сторонами. Создать необходимые методы и свойства. Определить метод вычисления периметра." +
                " Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения размеров треугольника в 2 раза.");
        }
        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        // периметр
        private void периметрToolStripMenuItem_Click(object sender, EventArgs e)
        {
                double s;
                // вызываем функцию из класса
                s = equilateral.GetS();
                // выводим на форму
                textBoxPerimetr.Text = Convert.ToString(Math.Round(s, 3));
        }
        // сброс
        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // пересоздаем объект со стандартными значениями
            equilateral = new Equilateral();
            // обновляем текущие значения
            textBoxStoronaA.Text = equilateral.A.ToString();
            // очищаем поля ввода 
            textBoxA.Clear();
        }
        // при загрузке формы создаем объект со стандартными значениями
        private void Form1_Load(object sender, EventArgs e)
        {
            // создаем объект со стандартными значениями
            /*triangle = new Triangle();*/
            equilateral = new Equilateral();
            // выводим текущие значения
            textBoxStoronaA.Text = equilateral.A.ToString();
        }
        // изменить значения
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxA.Text, out int a))
            {
                // обращаемся к свойству
                equilateral.A = a;
                // выводим текущие значения
                textBoxStoronaA.Text = equilateral.A.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка конвертации");
            }
        }
    }
}
