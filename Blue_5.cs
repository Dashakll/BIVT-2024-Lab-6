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
            private int _counter;

            public string Name => _name;
            public Sportsman[] Sportsmen
            {
                get
                {
                    if (_sportsmen == null) return null;
                    return _sportsmen;
                }
            }
            public int SummaryScore
            {
                get
                {
                    int sm = 0;
                    if (_sportsmen == null) return 0;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        if (_sportsmen[i].Place == 1) sm += 5;
                        if (_sportsmen[i].Place == 2) sm += 4;
                        if (_sportsmen[i].Place == 3) sm += 3;
                        if (_sportsmen[i].Place == 4) sm += 2;
                        if (_sportsmen[i].Place == 5) sm += 1;
                    }
                    return sm;
                }
            }

            public int TopPlace
            {
                get
                {
                    if (_sportsmen == null) return 18;
                    int max_rez = 18;
                    for (int i = 0; i < _sportsmen.Length; i++)
                    {
                        if (_sportsmen[i].Place > 0 && _sportsmen[i].Place < max_rez) { max_rez = _sportsmen[i].Place;}
                    }
                    return max_rez;
                }
            }


            public Team(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[6];
                _counter = 0;
            }


            public void Add(Sportsman sportsman)
            {
                if (_sportsmen == null || _counter >= 6) return;
                _sportsmen[_counter] = sportsman;
                _counter++;
            }
            public void Add(Sportsman[] sportsman)
            {
                if (_sportsmen == null || _counter >= 6) return;
                foreach (var sp in sportsman) { Add(sp); }
            }

            public static void Sort(Team[] teams)
            {
                for (int i = 0; i < teams.Length; i++)
                {
                    for (int j = 0; j < teams.Length - i - 1; j++)
                    {
                        if (teams[j].SummaryScore < teams[j + 1].SummaryScore) { (teams[j], teams[j + 1]) = (teams[j + 1], teams[j]); }
                        else if (teams[j].TopPlace > teams[j + 1].TopPlace && teams[j].SummaryScore == teams[j + 1].SummaryScore ) { (teams[j], teams[j + 1]) = (teams[j + 1], teams[j]); }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine(_name);
                for (int i = 0; i < _counter; i++) { _sportsmen[i].Print(); }
            }
        }
    }
}
