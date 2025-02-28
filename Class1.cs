using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Blue_1
    {
        public struct Response
        {
            // поля
            private string _name;
            private string _surname;
            private int _votes;

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
            public int Votes
            {
                get
                {
                    if (_votes == 0) return 0;
                    return _votes;
                }
            }

            // Конструкторы
            public Response(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _votes = 0;
            }
            // методы
            public int CountVotes(Response[] responses)
            {
                if (responses.Length == 0 || responses == null)
                    return 0;
                foreach (var resp in responses)
                {
                    if (resp.Name == _name && resp.Surname == _surname)
                        _votes++;
                }
                return _votes;
            }
            public void Print()
            {
                Console.WriteLine($"{_name}, {_surname}, {_votes}");
            }
        }
    }
}
