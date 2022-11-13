using System;
using System.IO;

namespace fileIO
{
    class program
    {
        static void Main(string[] args)
        { 
        string rootpath = @"C:\Users\Chetan\Source\Repos";
        string[] dirs = Directory.GetDirectories(rootpath,"*",SearchOption.TopDirectoryOnly);

       
           foreach(string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            Console.ReadLine();
            
            
           
            
            
            

            
        }
        
          
              
        
    }
}