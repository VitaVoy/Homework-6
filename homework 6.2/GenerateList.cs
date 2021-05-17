using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._2
{
    class GenerateList
    {
        static public List<student> Generate(int count = 100)
        {
            List<student> result = new List<student>();
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                result.Add(new student($"Имя_{i + 1}", $"Фамилия_{i + 1}", $"Университет_{" VGAVM"}", $"Факультет_{" veterinary"}", $"Отделение_{" veterinary medicine"}", r.Next(20, 100), r.Next(1, 6), r.Next(1, 12), $"Город_{" Vitebsk"}"));
            }
            return result;
        }
    }
}
