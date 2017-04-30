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
        const int SIZE_NEURO = 32;//count neurons
        string fileToLearn, letterToLearn;
        neuron[] neuro_web = new neuron[SIZE_NEURO];//creating array of neurons

        public Form1()//initialization
        {
            //output different text:
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

            char tmp = 'А';//tmp var

            for (int i = 0; i < SIZE_NEURO; i++)//output all letters
            {
                listBox1.Items.Insert(i,tmp.ToString() + "= 0");
                tmp = (char)((int)(tmp) + 1);
            }

            update();
        }

        public void update()//main func
        {
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

        public string calculate(Bitmap forCheck)//func for search true char
        {
            int result = 0,
                max = 0;

            for (int i = 0; i < SIZE_NEURO; i++)//calculate each neuron
            {
                neuro_web[i].calc(forCheck); //calc neuron number i
            }

            listBox1.Items.Clear();//clear list for results

            for (int i = 0; i < SIZE_NEURO; i++)//search true letter
            {
                //print weigth of neurons:
                
                listBox1.Items.Insert(i, neuro_web[i].name + "  =  " + neuro_web[i].weight);
                
                if (neuro_web[i].weight > max)
                {
                    max = neuro_web[i].weight;//weight of true letter
                    result = i;//number of true neuron
                }
            }
            
            return neuro_web[result].name;//return name of true neuron
        }

        public void learn()
        {

        }

        private void button1_Click(object sender, EventArgs e)//click on button "Raspoznat`"
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap tmp = (Bitmap)Image.FromFile(openFileDialog1.FileName, true);//load bmp 
                pictureBox1.Image = (Image) tmp;//show bmp
                label3.Text = calculate(tmp);//TMP
            }
        }

        private void button2_Click(object sender, EventArgs e)//open file to learn
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Bitmap tmp = (Bitmap)Image.FromFile(openFileDialog2.FileName, true);//load bmp 
                pictureBox1.Image = (Image)tmp;//show bmp
                fileToLearn = openFileDialog2.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)//learn letter
        {
            letterToLearn = textBox1.Text;
            learn();
        }
    }
}