using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class MovieBuffer
    {
        private int[] buffer;

        public MovieBuffer()
        {
            buffer = new int[16];
        }


        public MovieBuffer(int capacity)
        {
            buffer = new int[capacity];
        }

        public void Add(int data)
        {
            int index = 16;
            buffer[index] = data;

            if (buffer.Length < index)
            {
                int[] buffer2 = new int[buffer.Length * 2];

                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer2[i] = buffer[i];
                }

                buffer = buffer2;
            }
        }

    }
}
