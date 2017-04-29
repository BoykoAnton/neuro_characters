﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuro_characters
{
    class neuron
    {
        private const int SIZE = 29;
        public string name;
        public int [,] input = new int[SIZE, SIZE];
        public int [,] memory = new int[SIZE, SIZE];
        public int weight;
    }
}
