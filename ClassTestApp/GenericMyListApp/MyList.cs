using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMyListApp
{
    class MyList<template>
    {
        private template[] array;
        public MyList() { array = new template[3]; }

        public template this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public int Length
        {
            get { return array.Length; }
        }
    }
}

    

