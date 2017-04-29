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
        public Form1()//initialization
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

        public void update()//main func
        {
            const int SIZE_NEURO = 32;//count neurons
            neuron[] neuro_web = new neuron[SIZE_NEURO];//creating array of neurons
            char tmp = 'А';//tmp var

            for (int i = 0; i < SIZE_NEURO; i++)//initialization neuro web
            {
                neuro_web[i] = new neuron(tmp.ToString(), 0);//creating neuro
                tmp = (char)((int)(tmp) + 1);//next character
                neuro_web[i].load_memory();//load memory for each neuron
            }
            

            //pictureBox1.Image = (Image)neuro_web[8].memory;
            //label3.Text = neuro_web[31].name;
        }
    }
}
