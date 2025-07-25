using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public struct PhoneBook
    {
        public string[] Names;
        public long[] Numbers;
        private int _size;
        public PhoneBook(int size)
        {
            _size = size;
            Names = new string[size];
            Numbers = new long[size];
        }
        public int Size
        {
            get { return _size; }
        }

        public void AddNumber(string name, long number, int Position)
        {
            if (Position >= 0 && Position < _size)
            {
                Names[Position] = name;
                Numbers[Position] = number;
            }

        }
        public long GetNumber(int Position)
        {
            for (int i = 0; i < _size; i++)
            {
                if (i == Position)
                {
                    return Numbers[i];
                }
            }
            return -1; // Return -1 if position is invalid
        }

        public void UpdateNumber(int Position, long newNumber)
        {
            if (Position >= 0 && Position < _size)
            {
                Numbers[Position] = newNumber;
            }
        }

        public long this[int index]
        {
            get
            {
                if (index >= 0 && index < _size)
                {
                    return Numbers[index];
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index >= 0 && index < _size)
                {
                    Numbers[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }
    }
}
