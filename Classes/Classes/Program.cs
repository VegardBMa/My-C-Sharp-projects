using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int red = 20;
            Color ballColor = new Color(red, 20, 200, 255);
            Ball ball = new Ball(0, 0, ballColor);
            
        }
    }
}
