using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigint_task
{
    class BigInt
    {
        private string _bigInt ;

        public BigInt()
        {

        }

        public BigInt(string numString)
        {
            _bigInt = numString;
        }

        public BigInt(long numLong)
        {
            _bigInt = Convert.ToString(numLong);
        }
        public BigInt(int numInt) : this((long)numInt) { }

        public BigInt(byte numByte) : this((long)numByte) { }

        #region implicit


        public static implicit operator BigInt(long numLong)
        {
            return new BigInt(numLong);
        }

        public static implicit operator BigInt(int numInt)
        {
            return new BigInt(numInt);
        }

        public static implicit operator BigInt(byte numByte)
        {
            return new BigInt(numByte);
        }

        public static implicit operator BigInt(string numString)
        {
            return new BigInt(numString);
        }

        #endregion
        public char[] Add(string number)
        {
            StringBuilder sum = new StringBuilder();
            int n1 = _bigInt.Length;
            int n2 = number.Length;
            int carry = 0;
            int largest = (n1 > n2) ? n1 : n2;
            if (n1 > n2)
            {
                number = number.PadLeft(n1, '0');
            }
            else
            {
                _bigInt = _bigInt.PadLeft(n2, '0');
            }
            for (int i = largest - 1; i >= 0; i--)
            {
                int value = (carry + (_bigInt[i] - 48) + ((number[i]) - 48)) % 10;
                sum.Append(value);
                carry = (carry + (_bigInt[i] - 48) + ((number[i]) - 48)) / 10;
            }
            char[] c = sum.ToString().ToCharArray();
            Array.Reverse(c);
            return c;
        }
        public char[] Add(long number)
        {
            string number_long = Convert.ToString(number);
            return this.Add(number_long);
        }

        public char[] Subtraction(string number)
        {
            StringBuilder sub = new StringBuilder();
            int n1 = _bigInt.Length;
            int n2 = number.Length;
            int largest = (n1 > n2) ? n1 : n2;
            if (n1 > n2)
            {
                number = number.PadLeft(n1, '0');
            }
            else
            {
                _bigInt = _bigInt.PadLeft(n2, '0');
            }

            int remainder = 0;
            for (int i = largest - 1; i >= 0; i--)
            {
                if (((_bigInt[i] - 48) - remainder) < (number[i] - 48))
                {
                    int value = ((_bigInt[i] - 48) + 10) - (number[i] - 48) - remainder;
                    remainder = 1;
                    sub.Append(value);
                }
                else
                {
                    int value = (_bigInt[i] - 48) - (number[i] - 48) - remainder;
                    remainder = 0;
                    sub.Append(value);
                }

            }
            char[] c = sub.ToString().ToCharArray();
            Array.Reverse(c);
            return c;
        }
        public char[] Subtraction(long number)
        {
            string number_long = Convert.ToString(number);
            return this.Subtraction(number_long);
        }
        public void Multiply(string number)
        {
            
            int n1 = _bigInt.Length;
            int n2 = number.Length;
            int[] multi = new int[n1 + n2 - 1];
            int n = multi.Length;
            int transfer = 0;
            
            for (int i = n1 - 1; i >= 0; i--)
            {
                for (int j = n2 - 1; i >= 0; i--)
                {
                    int total = (_bigInt[i]) * (number[j]) + transfer;
                    transfer = 0;
                    if (total > 9)
                    {
                        multi[n-1] = total % 10;
                        transfer = total / 10;
                    }
                    else
                    {
                        multi[n-1] = total;
                       
                    }
                }
            }
            foreach(int elem in multi)
            {
                Console.Write(elem);
            }
            
        }
        public void Multiply(long number)
        {
            string number_long = Convert.ToString(number);
            Multiply(number_long);
        }


        }
    }


   


