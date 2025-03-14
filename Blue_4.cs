using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Blue_4
    {
        public struct Team
        {
            // поля
            private string _name;
            private int[] _scores;

            // свойства
            public string Name => _name;
            public int[] Scores => _scores;
            public int TotalScore
            {
                get
                {
                    if (_scores == null) return 0;
                    return _scores.Sum();
                }
            }

            // конструкторы
            public Team(string name)
            {
                _name = name;
                _scores = new int[0];
            }

            // методы 
            public void PlayMatch(int result)
            {
                if (_scores == null) return;
                int[] pl = new int[_scores.Length + 1];
                for (int i = 0; i < _scores.Length; i++) { pl[i] = _scores[i]; }
                pl[pl.Length - 1] = result;
                _scores = pl;
            }

            public void Print()
            {
                Console.WriteLine($"{_name}: {TotalScore}");
            }
        }

        public struct Group
        {
            // поля
            private string _name;
            private Team[] _teams;
            private int _index;

            // свойства
            public string Name => _name;
            public Team[] Teams => _teams;

            // конструкторы
            public Group(string name)
            {
                _name = name;
                _teams = new Team[12];
                _index = 0;
            }

            // методы
            public void Add(Team team)
            {
                if (_teams == null) return;
                if (_index < _teams.Length)
                {
                    _teams[_index] = team;
                    _index++;
                }
            }

            public void Add(Team[] teams)
            {
                if (teams.Length == 0 || _teams == null || teams == null) return;
                foreach (var team in teams) { Add(team); }
            }

            public void Sort()
            {
                if (_teams.Length == 0 || _teams == null) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    for (int j = 0; j < _teams.Length - i - 1; j++)
                    {
                        if (_teams[j].TotalScore < _teams[j + 1].TotalScore) { (_teams[j], _teams[j + 1]) = (_teams[j + 1], _teams[j]); }
                    }
                }
            }

            public static Group Merge(Group group1, Group group2, int size)
            {
                Group res = new Group("Финалисты");
                int i = 0, g = 0, t = 0, j = 0;
                while (j < size && i < size)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        res.Add(group1.Teams[i]);
                        i++;
                    }
                    else
                    {
                        res.Add(group2.Teams[j]);
                        j++;
                    }
                }
                while (g < size)
                {
                    res.Add(group1.Teams[g]);
                    g++;
                }
                while (t < size)
                {
                    res.Add(group2.Teams[t]);
                    t++;
                }
                return res;
            }

            public void Print()
            {
                Console.WriteLine(_name);
                foreach (Team p in _teams) { p.Print(); }
                Console.WriteLine();
            }
        }
    }
}
