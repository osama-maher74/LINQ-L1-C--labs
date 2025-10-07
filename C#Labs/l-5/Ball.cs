using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_5
{


    class PositionChangedEventArgs
    {

        public int DeltaX { get; set; }
        public int DeltaY { get; set; }

    }

    internal class Ball
    {
        Point postion;
        public event EventHandler<PositionChangedEventArgs> OnPositionChanged;
        internal Point Postion
        {
            get => postion; set
            {

                postion = value;
            }
        }
        public void setPostion(int x, int y)
        { 
            PositionChangedEventArgs E =new PositionChangedEventArgs() {DeltaX=postion.X-x ,DeltaY=postion.Y-y};
            postion.X = x-postion.X;
            postion.Y = y-postion.Y;
            OnPositionChanged.Invoke( this,E);
        
        }
        public override string? ToString()
        {
            return $" Ball Position ={postion}";
        }
    }
}
