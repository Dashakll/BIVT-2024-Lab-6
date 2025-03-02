using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_4
    {
        public struct Team
        {
            private string _name;
            private int[] _scores;

            // свойства
            public string Name { get { return _name; } }
            public int[] Scores
            {
                get
                {
                    if (_scores.Length == 0 || _scores == null) return null;
                    int[] c = new int[_scores.Length];
                    for (int i = 0; i < c.Length; i++) { c[i] = _scores[i]; }
                    return c;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_scores == null || _scores.Length == 0) return 0;
                    int cnt = 0;
                    for (int i = 0; i < _scores.Length; i++) { cnt += _scores[i]; }
                    return cnt;
                }
            }
            // конструкторы
            public Team(string name)
            {
                _name = name;
                _scores = null;
            }
            // методы
            public void PlayMatch(int result)
            {
                if (_scores == null)
                {
                    int[] _s = new int[1];
                    _s[0] = result;
                    _scores = _s;
                }

                else
                {
                    int[] s = new int[_scores.Length + 1];
                    s[s.Length - 1] = result;
                    for (int i = 0; i < _scores.Length; i++) { s[i] = _scores[i]; }
                    _scores = s;
                }
            }
            public void Print()
            {
                Console.WriteLine($"{this._name} {this.TotalScore}");
            }
        }
        public struct Group
        {
            // поля
            private string _name;
            private Team[] _teams;
            private int _cnt;

            // свойства
            public string Name { get { return _name; } }
            public Team[] Teams
            {
                get
                {
                    if (_teams.Length == 0 || _teams == null) return null;
                    Team[] c = new Team[_teams.Length];
                    for (int i = 0; i < c.Length; i++) { c[i] = _teams[i]; }
                    return c;
                }
            }
            public int Cnt { get { return _cnt; } }

            // конструкторы
            public Group(string name)
            {
                _name = name;
                _teams = new Team[12];
                _cnt = 0;
            }
            // методы
            public void Add(Team team)
            {
                if (_teams.Length == 0 || _teams == null || _cnt >= _teams.Length) return;
                _teams[_cnt] = team;
                _cnt++;
            }
            public void Add(Team[] teams)
            {
                if (_teams.Length == 0 || teams.Length == 0 || _teams  == null || teams == null || _cnt >= _teams.Length) return;
                int i = 0;
                while (_cnt < _teams.Length && i < teams.Length)
                {
                    _teams[_cnt] = teams[i];
                    i++;
                    _cnt++;
                }
            }
            public void Sort()
            {
                if (_teams.Length == 0 || _teams == null) return;
                for (int i = 1, j = 2; i < _teams.Length;)
                {
                    if (i == 0 || (_teams[i - 1].TotalScore >= _teams[i].TotalScore))
                    {
                        i = j;
                        j++;
                    }

                    else
                    {
                        Team tmp = _teams[i];
                        _teams[i] = _teams[i - 1];
                        _teams[i - 1] = tmp;
                        i--;
                    }
                }
            }
            public static Group Merge(Group group1, Group group2, int size)
            {
                Group result = new Group("Финалисты");
                int s = size / 2, i = 0, j = 0;
                while (i < s && j < s)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        result.Add(group1.Teams[i]);
                        i++;
                    }

                    else
                    {
                        result.Add(group2.Teams[j]);
                        j++;
                    }
                }

                while (i < s)
                {
                    result.Add(group1.Teams[i]);
                    i++;
                }

                while (j < s)
                {
                    result.Add(group2.Teams[i]);
                    j++;
                }

                return result;
            }
            public void Print()
            {
                Console.WriteLine(_name);
                for (int i = 0; i < _cnt; i++) { _teams[i].Print(); }
            }
        }
    }
}
