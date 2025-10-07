using System.Security.Cryptography;

namespace L_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            
            Ball b1 = new Ball() { Postion=new Point()};
            
            Player player1 = new Player() { Id=1,Name =  "salah" };
            Player player2 = new Player() { Id=2,Name =  "salah2" };
            Player player3 = new Player() { Id=3,Name =  "salah3" };
            Player player4 = new Player() { Id=4,Name =  "salah4" };
            Ref r1= new Ref() {Id=1,Name="ref1" };
            b1.OnPositionChanged += player1.MovePlayer;
            b1.OnPositionChanged += player2.MovePlayer;
            b1.OnPositionChanged += player3.MovePlayer;
            b1.OnPositionChanged += player4.MovePlayer;
            b1.OnPositionChanged += r1.MoveRef;
             
            b1.setPostion(10, 20);
            
            b1.OnPositionChanged += player4.MovePlayer;
            b1.setPostion(100, 200);
        
            b1.OnPositionChanged += player4.MovePlayer;
           


        }
    }
}
