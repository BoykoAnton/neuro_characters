using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neuro_characters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Neuro WEB by A.B.";
            button1.Text = "Распознать";
            groupBox1.Text = "Обучение";
            label1.Text = "Введите букву для изучения";
            label2.Text = "Откройте файл .bmp";
            label3.Text = "Изучить?";
            button2.Text = "Открыть";
            button3.Text = "Изучить!";
            pictureBox1.BackColor = Color.Aqua;
            update();
        }

        public void update()
        {
            const int SIZE_NEURO = 33;
            neuron[] neuro_web = new neuron[SIZE_NEURO];
            char tmp = 'А';
            for (int i = 0; i < SIZE_NEURO; i++)
            {
                neuro_web[i] = new neuron(tmp.ToString(), 0);
                tmp = (char)((int)(tmp) + 1);
            }
        }
    }
}
