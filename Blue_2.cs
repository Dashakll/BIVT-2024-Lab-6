using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Blue_2
    {
        public struct Participant
        {
            // поля
            private string _name;
            private string _surname;
            private int[,] _marks;

            // свойства
            public string Name => _name;
            public string Surname => _surname;
            public int[,] Marks
            {
                get
                {
                    if (_marks == null) return null;
                    int[,] cpmarks = new int[2, 5];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            cpmarks[i, j] = _marks[i, j];
                        }
                    }
                    return cpmarks;
                }
            }
            public int TotalScore
            {
                get
                {
                    int n = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++) { n += _marks[i, j]; }
                    }
                    return n;
                }
            }

            // структуры

            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[2, 5];
            }
            // методы

            public void Jump(int[] result)
            {
                if (_marks == null || result == null) return;
                for (int i = 0; i < 2; i++)
                {
                    if (_marks[i, 0] == 0)
                    {
                        for (int j = 0; j < 5; j++) { _marks[i, j] = result[j]; }
                        return;
                    }
                }
            }

            public static void Sort(Participant[] array)
            {
                if (array.Length == 0 || array == null) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalScore < array[j + 1].TotalScore)
                        {
                            Participant t = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = t;
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine(_name + " " + _surname);
                for (int i = 0; i < _marks.GetLength(0); i++)
                {
                    for (int j = 0; j < _marks.GetLength(1); j++) { Console.WriteLine(_marks[i, j]); }
                    Console.WriteLine();
                }
                Console.WriteLine(TotalScore);
            }
        }
    }
}
