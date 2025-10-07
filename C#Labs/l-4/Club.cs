using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__L4
{

    namespace C__L4
    {
        internal class Club
        {
            public int Id { get; set; }
            public string Name { get; set; }

            private List<Emp> Members { get; set; } = new List<Emp>();

            public void AddEmp(Emp emp)
            {
               
                
                    Members.Add(emp);
                    Console.WriteLine($"{emp.Name} joined Club {Name}");

                    emp.OnFired += RemoveEmp;
                
            }

            private void RemoveEmp(Emp emp)
            {
              
                
                    Members.Remove(emp);
                    Console.WriteLine($"{emp.Name} removed from Club {Name}");
                
            }

            public void PrintAll()
            {
                Console.WriteLine($"Club {Name}, Members = {Members.Count}");
                foreach (var emp in Members)
                    Console.WriteLine(emp);
            }
        }
    }


}

