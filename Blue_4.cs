using System;
using System.Collections.Generic;
using System.Linq;
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

            public string Name => _name;
            public int[] Scores
            {
                get
                {
                    if (_scores == null) return null;
                    int[] new_scr = new int[_scores.Length];
                    for (int i = 0; i < new_scr.Length; i++) { new_scr[i] = _scores[i]; }
                    return new_scr;
                }
            }
            public int TotalScore
            {
                get
                {
                    int score = 0;
                    if (_scores == null) return 0;
                    for (int i = 0; i < _scores.Length; i++) { score += _scores[i]; }
                    return score;
                }
            }

            public Team(string Name)
            {
                _name = Name;
                _scores = new int[0];
            }

            public void PlayMatch(int result)
            {
                if (_scores == null) return;
                var new_scr = new int[_scores.Length + 1];
                for (int i = 0; i < _scores.Length; i++) { new_scr[i] = _scores[i]; }
                new_scr[new_scr.Length - 1] = result;
                _scores = new_scr;
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {TotalScore}");
                Console.WriteLine();
            }
        }
        public struct Group
        {
            private string _name;
            private Team[] _teams;

            public string Name => _name;

            public Team[] Teams => _teams;

            public Group(string Name)
            {
                _name = Name;
                _teams = new Team[12];
            }

            public void Add(Team team)
            {
                if (_teams == null) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    if (_teams[i].Name == null)
                    {
                        _teams[i] = team;
                        break;
                    }
                }
            }

            public void Add(Team[] teams)
            {
                if (_teams == null) return;
                foreach (var tm in teams)
                {
                    Add(tm);
                }
            }

            public void Sort()
            {
                if (_teams == null) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    for (int j = 0; j < _teams.Length - i - 1; j++)
                    {
                        if (_teams[j].TotalScore < _teams[j + 1].TotalScore)
                        {
                            var tm = _teams[j];
                            _teams[j] = _teams[j + 1];
                            _teams[j + 1] = tm;
                        }
                    }
                }
            }

            public static Group Merge(Group group1, Group group2, int size)
            {
                Group new_gr = new Group("Финалисты");
                int i = 0, j = 0;
                while (i < size / 2 && j < size / 2)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore) { new_gr.Add(group1.Teams[i++]); }
                    else { new_gr.Add(group2.Teams[j++]); }
                }
                while (i < size / 2) { new_gr.Add(group1.Teams[i++]); }
                while (j < size / 2) { new_gr.Add(group2.Teams[j++]); }
                return new_gr;

            }

            public void Print()
            {
                Console.Write($"{_name} ");
                for (int i = 0; i < _teams.Length; i++) { _teams[i].Print(); }
                Console.WriteLine();
            }

        }
    }
}
