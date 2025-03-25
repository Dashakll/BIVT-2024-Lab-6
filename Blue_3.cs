using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int[] _pT;

            public string Name => _name;
            public string Surname => _surname;
            public int[] PenaltyTimes
            {
                get
                {
                    if (_pT == null) return null;
                    int[] cp = new int[_pT.Length];
                    for (int i = 0; i < cp.Length; i++) { cp[i] = _pT[i]; }
                    return cp;
                }
            }

            public int TotalTime
            {
                get
                {
                    if (_pT == null) return 0;
                    int counter = 0;
                    for (int i = 0; i < _pT.Length; i++) { counter += _pT[i]; }
                    return counter;
                }
            }


            public bool IsExpelled
            {
                get
                {
                    bool b = true;
                    if (_pT == null) return true;
                    for (int i = 0; i < _pT.Length; i++)
                    {
                        if (_pT[i] == 10)
                        {
                            b = false;
                            break;
                        }
                    }
                    return b;
                }
            }


            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _pT = new int[0];
            }


            public void PlayMatch(int time)
            {
                if (_pT == null) return;
                int[] new_pT = new int[_pT.Length + 1];
                for (int i = 0; i < new_pT.Length - 1; i++) { new_pT[i] = _pT[i]; }
                new_pT[_pT.Length] = time;
                _pT = new_pT;
            }

            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalTime > array[j + 1].TotalTime) { (array[j], array[j + 1]) = (array[j + 1], array[j]); }
                    }
                }
            }


            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {TotalTime} {IsExpelled}");
                Console.WriteLine();
            }
        }
    }
}
