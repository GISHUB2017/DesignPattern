using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2
{
    public class CheckInState:State
    {
        Room hotelManagement;
        public CheckInState(Room hotelManagement)
        {
            this.hotelManagement = hotelManagement;
        }

        public void bookRoom() 
        {
            Console.WriteLine("该房间已经入住了...");  
        }

        public void checkInRoom() 
        {
            Console.WriteLine("该房间已经入住了...");  
        }

        public void checkOutRoom() 
        {
            Console.WriteLine("退房成功....");  
            hotelManagement.setState(hotelManagement.getFreeTimeState());     //状态变成空闲  
        }

        public void unsubscribeRoom()
        {
            //不需要做操作  
        }  
    }
}
