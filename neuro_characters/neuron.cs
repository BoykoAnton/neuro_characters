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

        private const int SIZE = 30;
        public string name;
        //public int[,] input = new int[SIZE, SIZE];
        //public int[,] memory = new int[SIZE, SIZE];
        public Bitmap input;
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

        public void calc(Bitmap ainput)
        {
            this.load_memory();
            Color pxInput,
                  pxMemory;
            float m, n;
            this.input = ainput;

            for (int x = 0; x < SIZE; x++)
            {
                for (int y = 0; y < SIZE; y++)
                {
                    pxInput = input.GetPixel(x, y);
                    pxMemory = memory.GetPixel(x, y);
                    m = pxInput.R;
                    n = pxMemory.R;
                    
                    if (Math.Abs(m - n) < 20)
                    {
                        if (m < 250)
                        {
                            weight++;
                        }
                    }
                }
            }
        }

        public void learn(Bitmap toLearn)
        {

        }
    }
}
