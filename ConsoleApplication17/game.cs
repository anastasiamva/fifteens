using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fifteens
{
    class game
    {
        public int[,] field;

        public game(int size)
        {
            this.field = new int[size, size];
        }

        public void Fillig(Random gen)
        {
            int[] numbers = new int[field.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = gen.Next(0, field.Length);
                int y = numbers[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (numbers[i] == numbers[j])
                        {
                            numbers[i] = gen.Next(0, field.Length);
                            j = 0;
                            y = numbers[i];
                        }
                        y = numbers[i];
                    }
                }
                //Console.WriteLine("{0},{1}",numbers[i],i);
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = numbers[i * field.GetLength(0) + j];

                }
            }
        }
        public void Printing()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("{0}\t", field[i, j]);

                }
                Console.WriteLine();
            }
        }
        public int this[int x, int y]
        {
            get
            {
                return this.field[x, y];
            }
            set
            {
                this.field[x, y] = value;
            }
        }


        private int[] GetLocation(int value)
        {
            int[] address = new int[2];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == value)
                    {
                        address[0] = i;
                        address[1] = j;
                    }
                }
            }
            return address;
        }

        public bool Shift(int value)
        {
            int[] addressofvalue = GetLocation(value);
            int[] addressofzero = GetLocation(0);
            int x = addressofvalue[0];
            int y = addressofvalue[1];
            int x0 = addressofzero[0];
            int y0 = addressofzero[1];
            if (Math.Abs(x - x0) + Math.Abs(y - y0) == 1)
            {
                int temp = this[x, y];
                this[x, y] = this[x0, y0];
                this[x0, y0] = temp;
                return true;
            }
            else return false;

        }
        public bool CheckingSequence()
        {
            int[] numbers = new int[field.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = i + 1;
                }
            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] != numbers[i * field.GetLength(0) + j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}

