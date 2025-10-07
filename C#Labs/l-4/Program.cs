using System.Runtime.CompilerServices;
using C__L4.C__L4;

namespace C__L4
{
    public static class ExeList
    {
        public static List<string> Find0(this List<string> l1, Func<string, bool> condition)
        {
            var result = new List<string>();
            foreach (var item in l1)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }
            return result;

        }
        public static List<string> Find(this List<string> L)
        {
            List<string> result = new List<string>();

            foreach (var l in L)
            {
                if (l.Length > 3)
                    result.Add(l);   
            }

            return result;
        }

        public static List<string> Find2(this List<string> L)
        {
            List<string> result = new List<string>();

            foreach (var l in L)
            {
                if (l[0]=='e')
                    result.Add(l);   
            }

            return result;
        }
        public static List<string> Find3(this List<string> L)
        {
            List<string> result = new List<string>();
          
            foreach (var l in L)
            {
                int lastelment = l.Length - 1;
                if (l[lastelment]=='e')
                    result.Add(l);   
            }

            return result;
        }
        public static List<string> Find4(this List<string> L,char c)
        {
            List<string> result = new List<string>();
          
            foreach (var l in L)
            {
                for (int i = 0; i < l.Length; i++)
                {
                    if (l[i] == c)
                        result.Add(l);
                }
               
            }

            return result;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "osama",
                "osam",
                "osamamm",
                "ose",
                "osamav",
                "esamxav"
            };

            
            List<string> res = list.Find2();
            
            foreach (var l in res)
            {
                Console.WriteLine(l);
            }

            var StartWithA = ExeList.Find0(list, x => x[0] == 'a');
            var EndWithE = ExeList.Find0(list, x => x[1] == 'e');
            var LengthGreaterThan3 = ExeList.Find0(list, x => x.Length > 3);
            var ContainsE = ExeList.Find0(list, x => x.Contains("e"));

            Department d1 = new Department() { Id = 1, Name = "software" };

            Club sportsClub = new Club { Id = 1, Name = "Sports Club" };

            Emp e1=new Emp() {Id=1,Name="mo",Age=20 };
            Emp e2=new Emp() {Id=1,Name="mo",Age=20 };
            Emp e3 = new Emp { Id = 101, Name = "Osama", Age = 25 };
            Emp e4 = new Emp { Id = 102, Name = "Ahmed", Age = 30 };
            Emp e11 = new Emp { Id = 101, Name = "Osama", Age = 25 };
            Emp e12 = new Emp { Id = 102, Name = "Ahmed", Age = 30 };


            if (e1.Equals(e2))
                Console.WriteLine("true");
            else
              Console.WriteLine("false");
            
            
            d1.AddEmp(e11);
            d1.AddEmp(e12);
            sportsClub.AddEmp(e11);
            sportsClub.AddEmp(e12);

            d1.PrintAll();
            sportsClub.PrintAll();

            e11.AddAbsence();
            e11.AddAbsence();
            e11.AddAbsence();
            e11.AddAbsence(); 

            d1.PrintAll();
            sportsClub.PrintAll();

        }
    }
}
