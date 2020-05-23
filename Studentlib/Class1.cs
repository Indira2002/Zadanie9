using System;
using System.Collections.Generic;
namespace Studentlib
{
    public class Student
    {
        public string id;
        public string fio;
        public string group;
        public string data_r;
        public string vozrast;
        static List<Student> List = new List<Student>();

        static void Add(string id, string fio, string data_r, string group,string vozrast)
        {
            List.Add(new Student() { id = id, fio = fio, data_r = data_r, group = group, vozrast = vozrast });
        }


        static void Del(string id)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].id == id) List.RemoveAt(i);
            }
        }

        static void Change(string id, string fio, string data_r, string group, string vozrast)
        {

            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].id == id)
                {
                    List[i].fio = fio;
                    List[i].data_r = data_r;
                    List[i].group = group;
                    List[i].vozrast = vozrast;
                }
            }

        }

        static void ShowFio()
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + List[i].fio);
            }
            Console.WriteLine();
        }

        static void ShowId(string id)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].id == id)
                {
                    Console.WriteLine(List[i].id);
                    Console.WriteLine(List[i].fio);
                    Console.WriteLine(List[i].data_r);
                    Console.WriteLine(List[i].group);
                    Console.WriteLine(List[i].vozrast);
                }

            }
            Console.WriteLine();
        }
        static void ShowData_r(string id)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].id == id)
                {
                    Console.WriteLine(List[i].data_r);
                }

            }
            Console.WriteLine();
        }
        static void ShowA(string vozrast)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if((List[i].vozrast == "18")||(List[i].vozrast == "19") || (List[i].vozrast == "18") || (List[i].vozrast == "20") || (List[i].vozrast == "21"))
                {
                    Console.WriteLine("a");
                }
            }
        }
        static void ShowS(string vozrast)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if ((List[i].vozrast == "17")|| (List[i].vozrast == "16") || (List[i].vozrast == "15") || (List[i].vozrast == "14"))
                {
                    Console.WriteLine("s");
                }
            }
        }
        public void Phoisk()
        {
            Console.WriteLine("Введите фио:");
            string i = Console.ReadLine();
            bool ft = false;
            foreach (var student in List)
            {
                Student st = (Student)student;
                if (i == st.fio)
                {
                    List.Add(st);
                    ft = true;
                }
            }
            if (!ft)
            {
                Console.WriteLine("Ошибка!");
                return;

            }
            foreach (var student in List)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
