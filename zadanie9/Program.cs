using System;
using Studentlib;
namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            int s;
            s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    st.Add();
                    break;
                case 2:
                    st.Del();
                    break;
                case 3:
                    st.Change();
                    break;
                case 4:
                    st.ShowFio();
                    break;
                case 5:
                    st.ShowId();
                    break;
                case 6:
                    st.ShowData_r();
                    break;
                case 7:
                    st.ShowA();
                    break;
                case 8:
                    st.ShowS();
                    break;
                case 9:
                    st.Phoisk();
                    break;
                case 10:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
