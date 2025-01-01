using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_1
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;

        // constructor take size to create struct Arrays
        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }

        // this give us ability to treate Struct like array
        public long this[string name]
        {
            set {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;
                }
            }
            get {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
                return -1;
            }
        }
        public string this[long number]
        {
            set {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                        names[i] = value;
                }
            }
            get {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                        return names[i];
                }
                return "";
            }
        }


        // create functions to manage the struct
        public void AddPerson(string name,long number,int index)
        {
            names[index] = name;
            numbers[index] = number;
        }
        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
            }
            return -1;
        }
        public void updateNumber(string name,long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                     numbers[i]=number;
            }
        }
    }
}
