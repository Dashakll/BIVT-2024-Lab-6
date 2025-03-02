using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_5
    {
        public struct Sportsman
        {
            public string _name;
            public string _surname;
            public int _place;
            public bool _placeSet;

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public int Place
            {
                get
                {
                    if (_place == 0) { return 0; }
                    return _place;
                }
            }
            public bool PlaceSet => _placeSet;

            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
                _placeSet = false;

            }

            public void SetPlace(int place)
            {
                if (!_placeSet)
                {
                    if (place > 0)
                    {
                        _place = place;
                        _placeSet = true;
                    }
                    else { return; }
                }
            }
            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_place}");
            }
        }

        public struct Team
        {
            private string _name;
            private Sportsman[] _sportsmen;
            private int _cnt;

            public string Name { get { return _name; } }
            public Sportsman[] Sportsmen => _sportsmen;


            public int SummaryScore
            {
                get
                {
                    if (_sportsmen.Length == 0 || _sportsmen == null) return 0;
                    int scr = 0;
                    foreach (Sportsman sportsman in _sportsmen)
                    {
                        switch (sportsman.Place)
                        {
                            case 1: scr += 5; break;
                            case 2: scr += 4; break;
                            case 3: scr += 3; break;
                            case 4: scr += 2; break;
                            case 5: scr += 1; break;
                        }
                    }
                    return scr;
                }
            }

            public int TopPlace
            {
                get
                {
                    if (Sportsmen.Length == 0 || _sportsmen == null) return 0;
                    int tp = int.MaxValue;
                    foreach (Sportsman sportsman in _sportsmen)
                    {
                        if (sportsman.Place > 0 && sportsman.Place < tp) { tp = sportsman.Place; }
                    }
                    if (tp == int.MaxValue) return 0;
                    return tp;
                }
            }
            public Team(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[6];
                _cnt = 0;
            }

            public void Add(Sportsman sportsman)
            {
                if (_cnt < _sportsmen.Length) { _sportsmen[_cnt++] = sportsman; }
                else return;
            }

            public void Add(Sportsman[] newSportsmen)
            {
                foreach (Sportsman sportsman in newSportsmen) { Add(sportsman); }
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

                    else if (teams[i - 1].SummaryScore == teams[i].SummaryScore && teams[i - 1].TopPlace <= teams[i].TopPlace)
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
                Console.WriteLine(_name);
                for (int i = 0; i < _cnt; i++) { _sportsmen[i].Print(); }
                Console.WriteLine();
            }
        }
    }
}
