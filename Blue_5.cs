using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_5
    {
        public struct Sportsman
        {
            private string _name;
            private string _surname;
            private int _place;

            public string Name => _name;
            public string Surname => _surname;
            public int Place => _place;

            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _place = 0;
            }

            public void SetPlace(int place)
            {
                if (_place != 0) return;
                _place = place;
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_place}");
                Console.WriteLine();
            }
        }


        public struct Team
        {
            private string _name;
            private Sportsman[] _sportsmen;
            private int _ind;
            public string Name => _name;
            public Sportsman[] Sportsmen => _sportsmen;

            public int SummaryScore
            {
                get
                {
                    if (_sportsmen == null) return 0;
                    int sm = 0;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        switch (_sportsmen[i].Place)
                        {
                            case 1:
                                {
                                    sm += 5;
                                    break;
                                }
                            case 2:
                                {
                                    sm += 4;
                                    break;
                                }
                            case 3:
                                {
                                    sm += 3;
                                    break;
                                }
                            case 4:
                                {
                                    sm += 2;
                                    break;
                                }
                            case 5:
                                {
                                    sm += 1;
                                    break;
                                }
                            default:
                                {
                                    sm += 0;
                                    break;
                                }

                        }
                    }
                    return sm;

                }
            }
            public int TopPlace
            {
                get
                {
                    if (_sportsmen == null) return 0;
                    int min_sp = 18;
                    foreach (Sportsman sportsman in _sportsmen)
                    {
                        if (sportsman.Place != 0 && sportsman.Place < min_sp) { min_sp = sportsman.Place; }
                    }
                    return min_sp;
                }
            }
            public Team(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[6];
                _ind = 0;
            }
            public void Add(Sportsman sportsman)
            {
                if (_sportsmen == null || _ind == 6) return;
                _sportsmen[_ind] = sportsman;
                _ind++;

            }
            public void Add(Sportsman[] sportsmen)
            {
                if (sportsmen == null) return;
                foreach (var sportsman in sportsmen) { Add(sportsman); }
            }

            public static void Sort(Team[] teams)
            {
                if (teams == null || teams.Length <= 1) return;
                for (int i = 0; i < teams.Length; i++)
                {
                    for (int j = 0; j < teams.Length - i - 1; j++)
                    {
                        if (teams[j + 1].SummaryScore > teams[j].SummaryScore) { (teams[j], teams[j + 1]) = (teams[j + 1], teams[j]); }
                        else if (teams[j].SummaryScore == teams[j + 1].SummaryScore && teams[j].TopPlace > teams[j + 1].TopPlace) { (teams[j], teams[j + 1]) = (teams[j + 1], teams[j]); }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{_name}, {SummaryScore}, {TopPlace}");
                foreach (var sportsman in _sportsmen) { sportsman.Print(); }
                Console.WriteLine();

            }
        }
    }
}
