using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace neuro_characters
{
    class neuron
    {

        private const int SIZE = 29;
        public string name;
        public int[,] input = new int[SIZE, SIZE];
        //public int[,] memory = new int[SIZE, SIZE];
        public Bitmap memory;
        public int weight;

        public neuron()
        {

        }

        public neuron(string name)
        {
            this.name = name;    
        }

        public neuron(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public void load_memory()
        {
            const string FOLDER_RES = "D:\\GitHub\\neuro_characters\\neuro_characters\\res\\";
            Bitmap tmp = (Bitmap)Image.FromFile(FOLDER_RES + name + ".bmp", true);
            memory = tmp;
        }
    }
}
