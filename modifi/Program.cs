using System;

namespace modifi
{
   



    
        
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Graphic2D graphic2D = new Graphic2D();
            Graphic3D graphic3D = new Graphic3D();
            Console.WriteLine("Graphic2D:"+"X="+graphic2D.X+" Y="+graphic2D.Y);
            Console.WriteLine("Graphic3D:"+"X="+graphic3D.X+" Y="+graphic3D.Y+" Z="+graphic3D.Z);

        }
    }
}