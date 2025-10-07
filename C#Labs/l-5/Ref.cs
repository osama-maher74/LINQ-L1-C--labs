using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_5
{
    internal class Ref
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"id={Id} Name={Name}";
        }
        public void MoveRef(Object sender, PositionChangedEventArgs e)
        {
            Ball b1 = sender as Ball;
            Console.WriteLine($"from Ref {this} Ball Position Changed to {b1.Postion}");

        }
    }
}
