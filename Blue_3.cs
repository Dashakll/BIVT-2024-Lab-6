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
            private string _name;
            private string _surname;
            private int[] _penaltyTimes;
            public string Name => _name;
            public string Surname => _surname;
            public int[] PenaltyTimes
            {
                get
                {
                    if (_penaltyTimes == null) return null;
                    int[] copy = new int[_penaltyTimes.Length];
                    Array.Copy(_penaltyTimes, copy, _penaltyTimes.Length);
                    return copy;
                }
            }
            public int TotalTime
            {
                get

                {
                    if (_penaltyTimes == null) return 0;
                    else { return _penaltyTimes.Sum(); }
                }
            }

            public bool IsExpelled
            {
                get
                {
                    if (_penaltyTimes == null || _penaltyTimes.Length == 0) return false;
                    for (int i = 0; i < _penaltyTimes.Length; i++)
                    {
                        if (_penaltyTimes[i] == 10) return true;
                    }
                    return false;
                }
            }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _penaltyTimes = new int[0];

            }

            public void PlayMatch(int time)
            {
                if (_penaltyTimes == null) return;
                if (_penaltyTimes.Length == 0)
                {
                    int[] pT = new int[1];
                    pT[0] = time;
                    _penaltyTimes = new int[1];
                    Array.Copy(pT, _penaltyTimes, pT.Length);
                }
                else
                {
                    int[] pT = new int[_penaltyTimes.Length + 1];
                    pT[pT.Length - 1] = time;
                    for (int i = 0; i < _penaltyTimes.Length; i++) { pT[i] = _penaltyTimes[i]; }
                    _penaltyTimes = new int[_pT.Length];
                    Array.Copy(pT, _penaltyTimes, pT.Length);
                }
            }

            public static void Sort(Participant[] array)
            {
                if (array.Length == 0 || array == null) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalTime > array[j + 1].TotalTime) 
                        { 
                            (array[j], array[j + 1]) = (array[j + 1], array[j]); 
                        }
                    }
                }
            }

            public void Print()
            {
                Console.Write($"{_name}, {_surname}, {TotalTime}, {IsExpelled}");
                Console.WriteLine();
            }
        }
    }
}
