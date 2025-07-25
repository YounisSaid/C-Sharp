namespace DEMO
{
    internal class Program
    {
        public struct PhoneBook
        {
            public string[]  Names;
            public long[]  Numbers;
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

            public void AddNumber(string name, long number,int Position)
            {
                if(Position >=0 && Position < _size)
                {
                    Names[Position] = name;
                    Numbers[Position] = number;
                }
             
            }
            public long GetNumber(int Position)
            {
                for(int i = 0; i < _size; i++)
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

        static void Main(string[] args)
        {
           PhoneBook phoneBook = new PhoneBook();
            phoneBook = new PhoneBook(5); // Initialize with size 5
            phoneBook.AddNumber("Alice", 1234567890, 0);
            phoneBook.AddNumber("Bob", 9876543210, 1);
            phoneBook.AddNumber("Charlie", 5555555555, 2);
            long number = phoneBook.GetNumber(1);
            Console.WriteLine($"Number at position 1: {number}");
            phoneBook.UpdateNumber(1, 1111111111);
            Console.WriteLine($"Updated number at position 1: {phoneBook.GetNumber(1)}");
            phoneBook[2] = 2222222222; // Using indexer to set number at position 2
            Console.WriteLine($"Number at position 2 using indexer: {phoneBook[2]}");

            Car car1 = new Car(1, "Toyota", 120);



        }
    }
}
