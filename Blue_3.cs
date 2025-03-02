using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        public struct Participant
        {
            // поля
            private string _name;
            private string _surname;
            private int[] _penaltyTimes;
            private int _pldmtchsnm;

            // свойства
            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int[] PenaltyTimes
            {
                get
                {
                    int[] c = new int[_penaltyTimes.Length];
                    for (int k = 0; k < c.Length; k++)
                        c[k] = _penaltyTimes[k];
                    return c;
                }
            }
            public int TotalTime
            {
                get
                {
                    int totalTime = 0;
                    for (int i = 0; i < _penaltyTimes.Length; i++) { totalTime += _penaltyTimes[i]; }
                    return totalTime;
                }
            }
            public bool IsExpelled
            {
                get
                {
                    for (int i = 0; i < _penaltyTimes.Length; i++)
                    {
                        if (_penaltyTimes[i] == 10) { return true; }
                    }
                    return false;
                }
            }

            // конструкторы
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTimes = new int[10];
                _pldmtchsnm = 0;
            }

            // методы
            public void PlayMatch(int time)
            {
                if (_pldmtchsnm >= _penaltyTimes.Length) return;
                _penaltyTimes[_pldmtchsnm] = time;
                _pldmtchsnm++;
            }
            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j + 1].TotalTime < array[j].TotalTime)
                        {
                            Participant t = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
            public void Print()
            {
                Console.WriteLine($"{_name} {_surname}");
                for (int i = 0; i < _penaltyTimes.Length; i++) { Console.Write($"{_penaltyTimes[i],4}"); }
                Console.WriteLine();
                Console.WriteLine($"{TotalTime}");
            }
        }
    }
}
