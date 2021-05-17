using System; //Виталий Войтов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;




namespace homework_6._2 //Переделать программу Пример использования коллекций для решения следующих задач
{
    
    class Program
    {
        static void Print(List<student> Db)
        {
            for (int i = 0; i < Db.Count; i++)
            {
                Console.WriteLine($"{i,3}. {Db[i]}");
            }
            Console.WriteLine();
        }
        
        static int A(List<student> Db)
        {
            int result = 0;
            foreach(var e in Db)
            {
                if (e.course == 5 || e.course == 6) result++;
            }
            return result;
        }

        static Dictionary<int, int> B(List<student> Db)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for(int i = 0; i <= 6; i++)
            {
                result.Add(i, 0);
            }

            foreach(var e in Db)
            {
                if (e.age >= 18 && e.age <= 20) result[e.course]++;
            }
            return result;
        }

        static void C(List<student> Db)
        {
            for(int i = 0; i < Db.Count - 1; i++)
            {
                int minAge = Db[i].age;
                int pos = i;
                for(int j = i; j < Db.Count; j++)
                {
                    if(Db[j].age < minAge)
                    {
                        minAge = Db[j].age;
                        pos = j;
                    }

                    student t = Db[i];
                    Db[i] = Db[pos];
                    Db[pos] = t;
                }
            }

        }

        static void Sort(List<student> Db, int startPosition, int endPosition)
        {
            for(int i = startPosition; i < endPosition - 1; i++)
            {
                int minCourse = Db[i].course;
                int pos = i;
                for(int j = i+1; j < endPosition; j++)
                {
                    if(Db[j].course < minCourse)
                    {
                        minCourse = Db[j].course;
                        pos = j;
                    }

                    student t = Db[i];
                    Db[i] = Db[pos];
                    Db[pos] = t;
                }
            }

        }

        static void D(List<student> Db)
        {
            int start = 0;

            int i = 0;
            for(i = 0; i < Db.Count; i++)
            {
                if (Db[i].age != Db[start].age)
                {
                    Console.WriteLine($"\n {start} {i}\n");
                    Sort(Db, start, i);
                    start = i;
                }
            }

            Console.WriteLine($"\n {start} {i}\n");

        }
        static void Main(string[] args)
        {
            List<student> students = GenerateList.Generate(20);

            Print(students);

            Console.WriteLine($"A: {A(students)}");

            Console.WriteLine($"\nB:");
            foreach(var e in B(students))
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
            Console.Clear();

            Print(students);

            C(students);

            Print(students);

            Console.ReadLine();


            D(students);

            Print(students);

            Console.ReadLine();
        }
    }
}

        //static int myDelegat(student st1, student st2)
        //{
        //    return String.Compare(st1.firstName, st2.firstName);
        //}
        //static void Main(string[] args)
        //{
        //    int bakalavr = 0;
        //    int magistr = 0;
        //    int countCourse = 0;

        //    List<student> list = new List<student>();


        //    StreamWriter sw = new StreamWriter("student.csv");
        //    Random r = new Random();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        sw.WriteLine($"firstName{i}; lastName{i}; univercity{" VGAVM"}; faculty{" veterinary"}; department{" veterinary medicine"}; {r.Next(20, 100)}; course {r.Next(1, 6)}; group {r.Next(1, 12)}; city{" Vitebsk"}");
        //    }
        //    sw.Close();

        //    StreamReader sr = new StreamReader("student.csv");
        //    while (!sr.EndOfStream)
        //    {
        //        try
        //        {
        //            string[] s = sr.ReadLine().Split(';');

        //            list.Add(new student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

        //            if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
        //            if (int.Parse(s[6]) == 5 && int.Parse(s[6]) == 6) countCourse++;

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");

        //            if (Console.ReadKey().Key == ConsoleKey.Escape) return;
        //        }
        //    }
        //    sr.Close();
        //    list.Sort(new Comparison<student>(myDelegat));
        //    Console.WriteLine("Всего студентов:" + list.Count);
        //    Console.WriteLine("Магистров:{0}", magistr);
        //    Console.WriteLine("Бакалавров:{0}", bakalavr);
        //    Console.WriteLine("Студентов 5-6 курсов:{0}", countCourse);
        //    foreach (var v in list) Console.WriteLine(v.firstName);