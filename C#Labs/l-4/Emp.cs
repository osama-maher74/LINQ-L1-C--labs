using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__L4;
namespace C__L4
{
    internal class Emp
    {

        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public int AbsentDays { get; private set; } = 0;

        public event Action<Emp>? OnFired;

        public void AddAbsence()
        {
            AbsentDays++;
            if (AbsentDays > 3)
            {
                Console.WriteLine($"{Name} exceeded 3 absence days -> Fired!");
                OnFired?.Invoke(this);  
            }
        }

        public override string ToString()
        {
            return $"ID:{Id} Name:{Name} Age{Age}";
        }

        public void print()
        {
            Console.WriteLine(this);
        }
        public override bool Equals(object? obj)
        {
            // return base.Equals(obj);

            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;
            Emp e = (Emp)obj;
            return Id == e.Id && Age == e.Age && Name == e.Name;
        }
    }
}
