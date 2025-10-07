using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_5
{
    internal class Player
    {
        public int  Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"id={Id} Name={Name}";
        }
        public void MovePlayer(Object sender,PositionChangedEventArgs e)
        {
            Ball b1 =  sender as Ball;
            Console.WriteLine($"from player {this} Ball Position Changed to {b1.Postion}");
        
        }
    
    
    }
}
