using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Ball
    {
        private int size = 0;
        private int throws = 0;
        private Color ballColor = new Color(50,100,200,255);
        
        public Ball(int size, int throws, Color ballColor)
        {
            this.size = size;
            this.throws = throws;
            this.ballColor = ballColor;
        }

        public int PopBall(int size)
        {
            return size = 0;
        }

        public int Throws()
        {
            if (size > 0)
                return throws++;
            else
                return throws;
        }

        public int Results()
        {
            return throws;
        }
    }
}
