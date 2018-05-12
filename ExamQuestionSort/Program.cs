using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TypesofSortQuestion.Question.SortByTopicClass;

namespace TypesofSortQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam Exam = new Exam();


            Exam.Add(new Question1());

            Exam.Add(new Question2());

            Exam.Add(new Question3());

            Exam.Add(new Question4());

            Exam.Add(new Question5());

            Exam.Add(new Question6());

            Exam.Add(new Question7());

            Exam.Add(new Question8());

            Exam.Add(new Question9());

            Exam.Add(new Question10());

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Sort by question\n2.Sort by hardship level\n3.sort by topic\n4.Sort by score\n5.Sort by Id\n6.Sort by Even Id\n7.Sort by odd Id");
                var number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        SortByQuestion(Exam);
                        break;
                    case 2:
                        SortByHardshipLevel(Exam);
                        break;
                    case 3:
                        SortByTopic(Exam);
                        break;
                    case 4:
                        SortByScore(Exam);
                        break;
                    case 5:
                        SortById(Exam);
                        break;
                    case 6:
                        SortByEvenId(Exam);
                        break;
                    case 7:
                        SortByOddId(Exam);
                        break;
                }
                Console.ReadKey();
            }
        }

        private static void SortById(Exam Exam)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sorting by Id");
            Exam.Sort(Question.SortMetric.Id);

            foreach (Question Question in Exam)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($" {Question.Id}.{ Question.Txt} ");
            }

        }

        private static void SortByQuestion(Exam Exam)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sorting by Question\n");
            Exam.Sort();

            foreach (Question Question in Exam)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($" {Question.Id}.{Question.Txt}");
            }
        }
        private static void SortByEvenId(Exam Exam)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sorting by Id");
            Exam.Sort(Question.SortMetric.Id);

            foreach (Question Question in Exam)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (Question.Id % 2 == 0)
                {
                    Console.WriteLine($" {Question.Id}.{ Question.Txt} ");
                }

            }

        }

        private static void SortByOddId(Exam Exam)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sorting by Id");
            Exam.Sort(Question.SortMetric.Id);

            foreach (Question Question in Exam)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (Question.Id % 2 != 0)
                {
                    Console.WriteLine($" {Question.Id}.{ Question.Txt} ");
                }

            }

        }

        private static void SortByScore(Exam Exam)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sorting by Score");
            Exam.Sort(Question.SortMetric.Score);

            foreach (Question Question in Exam)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($" {Question.Id}.{ Question.Txt} \t\t ------|Score = {Question.Score}");
            }

        }

        private static void SortByTopic(Exam Exam)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sorting by Topic\n");
            Exam.Sort(Question.SortMetric.Topic);

            foreach (Question Question in Exam)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($" {Question.Id}.{ Question.Txt} \t\t ------|Topic = {Question.Topic}");
            }
        }

        private static void SortByHardshipLevel(Exam Exam)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sorting by HardshipLevel\n");
            Exam.Sort(Question.SortMetric.HardshipLevel);

            foreach (Question Question in Exam)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($" {Question.Id}.{Question.Txt} \t\t ------|HardshipLevel = {Question.HardshipLevel}");
            }
        }
    }
}
