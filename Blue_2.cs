using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_2
    {
        public struct Participant
        {
            // поля
            private string _name;
            private string _surname;
            private int _ind;
            private int[,] _marks;

            // свойства
            public string Name
            {
                get
                {
                    if (_name == null) return null;
                    return _name;
                }
            }
            public string Surname
            {
                get
                {
                    if (_surname == null) return null;
                    return _surname;
                }
            }
            public int[,] Marks
            {
                get
                {
                    if (_marks == null) 
                        return default(int[,]);
                    int[,] Markss = new int[2, 5];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++) { Markss[i, j] = _marks[i, j]; }
                    }
                    return Markss;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_marks == null) { return 0; }
                    int total_score = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++) { total_score += _marks[i, j]; }
                    }
                    return total_score;
                }
            }
            // Конструкторы
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _marks = new int[2, 5];
                _ind = 0;
            }
            // методы
            public void Jump(int[] result)
            {
                if (_marks == null || _marks.GetLength(0) == 0 || _marks.GetLength(1) == 0 || result == null || result.Length == 0 || _ind > 1) 
                    return;
                for (int i = 0; i < result.Length; i++) { _marks[_ind, i] = result[i]; }
                _ind++;
            }
            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].TotalScore < array[j + 1].TotalScore) { (array[j], array[j + 1]) = (array[j + 1], array[j]); } 
                    }
                }
            }
            public void Print(Participant participant)
            {
                Console.WriteLine($"{participant.Name}\t{participant.Surname}\t\t{participant.TotalScore}");
            }
        }
    }
}
