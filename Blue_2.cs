using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_2
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int[,] _marks;
            private int _counter;

            public string Name => _name;
            public string Surname => _surname;
            public int[,] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    int[,] new_array = new int[2, 5];
                    for (int i = 0; i < new_array.GetLength(0); i++)
                    {
                        for (int j = 0; j < new_array.GetLength(1); j++) { new_array[i, j] = _marks[i, j]; }
                    }
                    return new_array;
                }
            }

            public int TotalScore
            {
                get
                {
                    if (_marks == null) return 0;
                    int scr = 0;
                    for (int i = 0; i < _marks.GetLength(0); i++)
                    {
                        for (int j = 0; j < _marks.GetLength(1); j++) { scr += _marks[i, j]; }
                    }
                    return scr;
                }
            }

            public Participant(string Name, string Surname)
            {
                _name = Name;
                _surname = Surname;
                _marks = new int[2, 5];
                _counter = 0;
            }

            public void Jump(int[] result)
            {
                if (_marks == null || _marks.GetLength(1) == 0 || _marks.GetLength(0) == 0 || result == null || result.Length == 0 || _counter > 1) return;
                if (_counter == 0)
                {
                    for (int i = 0; i < 5; i++) { _marks[0, i] = result[i]; }
                    _counter++;
                }
                else if (_counter == 1)
                {
                    for (int i = 0; i < 5; i++) { _marks[1, i] = result[i]; }
                    _counter++;
                }
            }

            public static void Sort(Participant[] array)
            {
                if (array == null) return;
                for (int i = 1, j = 2; i < array.Length;)
                {
                    if (array[i].TotalScore <= array[i - 1].TotalScore || i == 0)
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        Participant arr = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = arr;
                        i--;
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {TotalScore}");
                Console.WriteLine();
            }


        }
    }
}
