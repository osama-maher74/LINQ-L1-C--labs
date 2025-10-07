using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__L4;
namespace C__L4
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private List<Emp> EmpList { get; set; } = new List<Emp>();

        public void AddEmp(Emp emp)
        {
            
            
                EmpList.Add(emp);
                Console.WriteLine($"{emp.Name} joined Department {Name}");

                emp.OnFired += RemoveEmp;
            
        }

        private void RemoveEmp(Emp emp)
        {
           
            
                EmpList.Remove(emp);
                Console.WriteLine($"{emp.Name} removed from Department {Name}");
            
        }

        public void PrintAll()
        {
            Console.WriteLine($"Department {Name}, Number of Emp = {EmpList.Count}");
            foreach (var emp in EmpList)
            {
                emp.print();
            }
        }

        public override string ToString()
        {
            return $"ID:{Id} Name:{Name} Number of Emp {EmpList.Count}";
        }

        public void print()
        {
            Console.WriteLine(this);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            Department d = (Department)obj;
            return Id == d.Id && Name == d.Name;
        }
    }
}
