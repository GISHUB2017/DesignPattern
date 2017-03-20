using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2
{
    class Program
    {
        static void Main(string[] args)
        {
            //有3间房  
            Room[] rooms = new Room[2];  
            //初始化  
            for(int i = 0 ; i < rooms.Length; i++){  
                rooms[i] = new Room();  
            }  
            //第一间房  
            rooms[0].bookRoom();    //预订  
            rooms[0].checkInRoom();   //入住  
            rooms[0].bookRoom();    //预订  
            Console.WriteLine(rooms[0]);  
            Console.WriteLine("---------------------------");  
          
            //第二间房  
            rooms[1].checkInRoom();  
            rooms[1].bookRoom();  
            rooms[1].checkOutRoom();  
            rooms[1].bookRoom();
            Console.WriteLine(rooms[1]);

            Console.ReadLine();
        }
    }
}
