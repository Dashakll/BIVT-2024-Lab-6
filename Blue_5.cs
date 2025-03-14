using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Blue_5
    {
        public struct Sportsman
        {
            // поля
            private string _name;
            private string _surname;
            private int _place;

            // свойства
            public string Name => _name;
            public string Surname => _surname;
            public int Place => _place;

            // конструкторы
            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }

            // методы
            public void SetPlace(int place)
            {
                if (_place != 0) return;
                _place = place;
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_place}");
            }
        }

        public struct Team
        {
            // поля
            private string _name;
            private Sportsman[] _sportsmen;
            private int _count;

            // свойства 
            public string Name => _name;
            public Sportsman[] Sportsmen
            {
                get
                {
                    if (_sportsmen.Length == 0 || _sportsmen == null) return null;
                    Sportsman[] cp = new Sportsman[_sportsmen.Length];
                    for (int i = 0; i < _sportsmen.Length; i++) { cp[i] = _sportsmen[i]; }
                    return cp;
                }
            }
            private int Count => _count;
            public int SummaryScore
            {
                get
                {
                    if (_sportsmen == null || _sportsmen.Length == 0) return 0;
                    int sm = 0;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        switch (_sportsmen[i].Place)
                        {
                            case 1: sm += 5; break;
                            case 2: sm += 4; break;
                            case 3: sm += 3; break;
                            case 4: sm += 2; break;
                            case 5: sm += 1; break;
                        }
                    }
                    return sm;
                }
            }
            public int TopPlace
            {
                get
                {
                    if (_sportsmen.Length == 0 || _sportsmen == null) return 0;
                    int maxP = 18;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        if (_sportsmen[i].Place < maxP && _sportsmen[i].Place > 0) maxP = _sportsmen[i].Place;
                    }
                    return maxP;
                }
            }

            // конструкторы
            public Team(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[6];
                _count = 0;
            }

            // методы
            public void Add(Sportsman sportsman)
            {
                if (_sportsmen.Length == 0 || _count >= _sportsmen.Length || _sportsmen == null) return;
                _sportsmen[_count] = sportsman;
                _count++;
            }

            public void Add(Sportsman[] sportsman)
            {
                if (_sportsmen.Length == 0 || sportsman.Length == 0 || _count >= _sportsmen.Length || _sportsmen == null || sportsman == null) return;
                int n = 0;
                while (_count < _sportsmen.Length && n < sportsman.Length)
                {
                    _sportsmen[_count] = sportsman[n];
                    _count++;
                    n++;
                }
            }

            public static void Sort(Team[] teams)
            {
                if (teams.Length == 0 || teams == null) return;
                for (int i = 1, j = 2; i < teams.Length;)
                {
                    if (i == 0 || teams[i - 1].SummaryScore > teams[i].SummaryScore)
                    {
                        i = j;
                        j++;
                    }
                    else if (teams[i - 1].TopPlace <= teams[i].TopPlace && teams[i - 1].SummaryScore == teams[i].SummaryScore)
                    {
                        i = j;
                        j++;
                    }
                    else
                    {
                        Team t = teams[i];
                        teams[i] = teams[i - 1];
                        teams[i - 1] = t;
                        i--;
                    }
                }
            }
            public void Print()
            {
                for (int i = 0; i < _sportsmen.Length; i++)
                {
                    Console.WriteLine($"{_name} {SummaryScore} {TopPlace}");
                }
            }
        }
    }
}
