using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_1;
using static Lab_6.Blue_2;
using static Lab_6.Blue_3;
using static Lab_6.Blue_4;
using static Lab_6.Blue_5;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Blue1
            /* Blue_1.Response[] responses;
            int.TryParse(Console.ReadLine(), out var count);
            responses = new Blue_1.Response[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Кандидат номер {i + 1}:");
                 responses[i] = new Blue_1.Response(Console.ReadLine(), Console.ReadLine());
            }
            
            foreach (var response in responses)
            {
                 response.CountVotes(responses);
                 Console.WriteLine($"{response.Name} {response.Surname} {response.Votes}");
            } */



            // Blue2
            /* Blue_2.Participant[] participants = new Blue_2.Participant[]
            {
                new Blue_2.Participant("Александр", "Петров"),
                new Blue_2.Participant("Артем", "Луговой"),
                new Blue_2.Participant("Мария", "Свиридова "),
                new Blue_2.Participant("Марина", "Свиридова"),
                new Blue_2.Participant("Игорь", "Смирнов"),
                new Blue_2.Participant("Александр", "Петров")
            };
            participants[0].Jump(new int[]{11,0,8,7,12});
            participants[0].Jump(new int[]{2,3,10,13,16});
            participants[1].Jump(new int[]{18,17,20,7,11});
            participants[1].Jump(new int[]{3,7,12,19,2});
            participants[2].Jump(new int[]{17,13,2,19,2});
            participants[2].Jump(new int[]{10,0,0,6,5});
            participants[3].Jump(new int[]{18,1,10,5,20});
            participants[3].Jump(new int[]{19,1,5,1,18});
            participants[4].Jump(new int[]{15,7,14,19,15});
            participants[4].Jump(new int[]{5,13,16,18,16});
            participants[5].Jump(new int[]{2,17,5,11,3});
            participants[5].Jump(new int[]{7,18,3,5,3});
            Blue_2.Participant.Sort(participants);
            Console.WriteLine("Name\tSurname\t\tTotal_score");
            foreach (var participant in participants) participant.Print(participant); */



            // Blue3

            /* Blue_3.Participant[] participants = new Blue_3.Participant[]
        {
            new Blue_3.Participant("Инна", "Понамарева"),
            new Blue_3.Participant("Юрий", "Ушаков"),
            new Blue_3.Participant("Дмитрий", "Иванов"),
            new Blue_3.Participant("Иван", "Кристиан"),
            new Blue_3.Participant("Татьяна", "Ушакова"),
            new Blue_3.Participant("Александра", "Козлова"),
            new Blue_3.Participant("Дарья", "Павлова"),
            new Blue_3.Participant("Мирослав", "Лисицын"),
            new Blue_3.Participant("Юлия", "Чехова"),
            new Blue_3.Participant("Дарья", "Лисицына"),
        };
            foreach (var x in new int[] { 2, 2, 10, 2, 0, 0, 0, 5, 2, 5 }) participants[0].PlayMatch(x);
            foreach (var x in new int[] { 0, 10, 10, 0, 5, 5, 2, 10, 10, 10 }) participants[1].PlayMatch(x);
            foreach (var x in new int[] { 2, 5, 5, 2, 0, 10, 5, 2, 0, 0 }) participants[2].PlayMatch(x);
            foreach (var x in new int[] { 2, 10, 2, 5, 2, 2, 10, 10, 5, 0 }) participants[3].PlayMatch(x);
            foreach (var x in new int[] { 5, 2, 0, 10, 10, 2, 10, 5, 0, 2 }) participants[4].PlayMatch(x);
            foreach (var x in new int[] { 5, 2, 5, 0, 0, 10, 5, 5, 2, 10 }) participants[5].PlayMatch(x);
            foreach (var x in new int[] { 0, 2, 0, 2, 0, 10, 5, 0, 2, 10 }) participants[6].PlayMatch(x);
            foreach (var x in new int[] { 0, 2, 2, 10, 10, 2, 5, 2, 5, 0 }) participants[7].PlayMatch(x);
            foreach (var x in new int[] { 0, 10, 5, 10, 5, 5, 5, 2, 5, 2 }) participants[8].PlayMatch(x);
            foreach (var x in new int[] { 5, 2, 5, 0, 10, 10, 0, 0, 0, 2 }) participants[9].PlayMatch(x);
            Blue_3.Participant.Sort(participants);
            foreach (var participant in participants) participant.Print();
        } */

            // Blue4
            /* Blue_4.Team[] teams = new Blue_4.Team[]
            {
                new Blue_4.Team("Энергия"),
                new Blue_4.Team("Спартак"),
                new Blue_4.Team("Барс"),
                new Blue_4.Team("Нефтехим"),
                new Blue_4.Team("Байкал"),
                new Blue_4.Team("Василек"),
                new Blue_4.Team("Урал"),
                new Blue_4.Team("Быки"),
                new Blue_4.Team("Метеор"),
                new Blue_4.Team("Быки"),
                new Blue_4.Team("ЦСКА"),
                new Blue_4.Team("Русь")            
            };
            foreach (var x in new int[] { 1, 0, 0, 0, 3, 0, 1, 0, 1, 3, 0, 0 }) teams[0].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 1, 3, 3, 1, 0, 3, 0, 3, 1, 3, 3, 0, 1, 1, 1, 1, 0, 1 }) teams[1].PlayMatch(x);
            foreach (var x in new int[] { 0, 3, 0, 0, 3, 1, 0, 1, 0, 3, 0, 0, 3, 1, 1, 3, 0, 1, 0, 0 }) teams[2].PlayMatch(x);
            foreach (var x in new int[] { 3, 1, 1, 0, 1, 0, 1, 3, 1, 3, 1, 0, 1, 1, 0, 1, 3, 3, 3, 0 }) teams[3].PlayMatch(x);
            foreach (var x in new int[] { 1, 0, 1, 0, 0, 1, 3, 1, 3, 3, 3, 1, 3, 3, 0, 1, 0, 0, 0, 0 }) teams[4].PlayMatch(x);
            foreach (var x in new int[] { 1, 3, 3, 3, 3, 3, 1, 3, 3, 0, 1, 3, 3, 0, 1, 0, 0, 3, 0, 3 }) teams[5].PlayMatch(x);
            foreach (var x in new int[] { 0, 1, 3, 1, 1, 0, 0, 0, 3, 3, 1, 3, 3, 3, 0, 0, 3, 3, 3, 0 }) teams[6].PlayMatch(x);
            foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) teams[7].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) teams[8].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) teams[9].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[10].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) teams[11].PlayMatch(x);
            Blue_4.Group group1 = new Blue_4.Group("Группа 1");
            foreach (var team in teams) { group1.Add(team); }
            group1.Sort();
            Console.WriteLine("Группа 1 после сортировки:"); group1.Print();
            Console.WriteLine();

            Blue_4.Team[] tms = new Blue_4.Team[] 
            {
            new Blue_4.Team("Локомотив"),
            new Blue_4.Team("СКА"),
            new Blue_4.Team("Энергия"),
            new Blue_4.Team("Нефтехим"),
            new Blue_4.Team("Ак-барс"),
            new Blue_4.Team("Барс"),
            new Blue_4.Team("СПБ"),
            new Blue_4.Team("Быки"),
            new Blue_4.Team("Метеор"),
            new Blue_4.Team("Быки"),
            new Blue_4.Team("ЦСКА"),
            new Blue_4.Team("Русь") 
            };

            foreach (var x in new int[] { 1, 1, 3, 0, 3, 0, 1, 0, 3, 3, 3, 3 }) tms[0].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 1, 0, 3, 1, 0, 3, 1, 3, 1, 3, 3, 1, 1, 1, 0, 3, 1, 1 }) tms[1].PlayMatch(x);
            foreach (var x in new int[] { 1, 1, 3, 3, 0, 0, 3, 3, 1, 0, 3, 0, 0, 1, 0, 3, 1, 1, 0, 1 }) tms[2].PlayMatch(x);
            foreach (var x in new int[] { 1, 3, 3, 1, 1, 3, 3, 1, 3, 3, 1, 1, 0, 3, 0, 3, 1, 3, 1, 1 }) tms[3].PlayMatch(x);
            foreach (var x in new int[] { 0, 3, 1, 1, 1, 0, 3, 1, 0, 3, 0, 0, 1, 3, 3, 1, 1, 3, 0, 0 }) tms[4].PlayMatch(x);
            foreach (var x in new int[] { 3, 1, 0, 0, 3, 1, 0, 1, 3, 0, 0, 1, 3, 0, 0, 0, 3, 0, 3, 1 }) tms[5].PlayMatch(x);
            foreach (var x in new int[] { 0, 1, 1, 3, 0, 1, 3, 0, 3, 3, 0, 0, 0, 3, 3, 1, 1, 0, 3, 1 }) tms[6].PlayMatch(x);
            foreach (var x in new int[] { 3, 3, 1, 0, 3, 3, 0, 3, 3, 3, 1, 0 }) tms[7].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 0, 0, 1, 3, 0, 0, 3, 0, 3 }) tms[8].PlayMatch(x);
            foreach (var x in new int[] { 3, 0, 0, 3, 3, 1, 3, 1, 3, 1, 3, 1 }) tms[9].PlayMatch(x);
            foreach (var x in new int[] { 0, 0, 0, 1, 1, 3, 1, 0, 1, 0, 0, 0 }) tms[10].PlayMatch(x);
            foreach (var x in new int[] { 1, 1, 1, 3, 0, 3, 3, 0, 3, 3, 3, 1 }) tms[11].PlayMatch(x);
            Blue_4.Group group2 = new Blue_4.Group("Группа 2");
            foreach (var team in tms) { group2.Add(team); }
            group2.Sort();
            Console.WriteLine("Группа 2 после сортировки:"); group2.Print();
            Group.Merge(group1, group2, 12).Print(); */

            // Blue5
            /* Blue_5.Sportsman[] Sportsmen = new Blue_5.Sportsman[]
            {
                new Blue_5.Sportsman("Мирослав", "Распутин"),
                new Blue_5.Sportsman("Игорь", "Павлов"),
                new Blue_5.Sportsman("Полина", "Свиридова"),
                new Blue_5.Sportsman("Савелий", "Луговой"),
                new Blue_5.Sportsman("Николай", "Козлов"),
                new Blue_5.Sportsman("Юлия", "Сидорова"),
                new Blue_5.Sportsman("Полина", "Луговая"),
                new Blue_5.Sportsman("Светлана", "Иванова"),
                new Blue_5.Sportsman("Александр", "Петров"),
                new Blue_5.Sportsman("Игорь", "Распутин"),
                new Blue_5.Sportsman("Савелий", "Свиридов"),
                new Blue_5.Sportsman("Мария", "Свиридова"),
                new Blue_5.Sportsman("Дмитрий", "Свиридов"),
                new Blue_5.Sportsman("Светлана", "Козлова"),
                new Blue_5.Sportsman("Екатерина", "Луговая"),
                new Blue_5.Sportsman("Степан", "Жарков"),
                new Blue_5.Sportsman("Степан", "Распутин"),
                new Blue_5.Sportsman("Дарья", "Свиридова") };

            int[] places = { 12, 2, 17, 13, 5, 6, 7, 8, 9, 10, 11, 1, 4, 14, 15, 16, 3, 18 };

            for (int i = 0; i < Sportsmen.Length; i++) { Sportsmen[i].SetPlace(places[i]); }

            Blue_5.Team[] teams = new Blue_5.Team[]
            {
                new Blue_5.Team("Локомотив"),
                new Blue_5.Team("Динамо"),
                new Blue_5.Team("Спартак") };

            teams[0].Add(new Sportsman[] { Sportsmen[0], Sportsmen[1], Sportsmen[2], Sportsmen[3], Sportsmen[4], Sportsmen[5] });
            teams[1].Add(new Sportsman[] { Sportsmen[6], Sportsmen[7], Sportsmen[8], Sportsmen[9], Sportsmen[10], Sportsmen[11] });
            teams[2].Add(new Sportsman[] { Sportsmen[12], Sportsmen[13], Sportsmen[14], Sportsmen[15], Sportsmen[16], Sportsmen[17] });

            Blue_5.Team.Sort(teams);

            Console.WriteLine("Результаты соревнований:");
            foreach (var team in teams)
            {
                Console.WriteLine($"Команда: {team.Name}, Очки: {team.SummaryScore}, Лучший результат: {team.TopPlace}");
                team.Print();
            } */

        }
    }
}
