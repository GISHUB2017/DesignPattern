using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel(10);

            Console.WriteLine("当前房间总数：" + hotel.Count);
            Room room1 = new Room(hotel);
            room1.bookRoom();
            Console.WriteLine("当前房间总数：" + hotel.Count);
            room1.checkInRoom();
            Console.WriteLine("当前房间总数：" + hotel.Count);
            room1.checkOutRoom();
            Console.WriteLine("当前房间总数：" + hotel.Count);


            Console.ReadLine();
        }
    }
}
