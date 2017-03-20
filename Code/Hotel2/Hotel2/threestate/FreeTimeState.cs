using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2
{
    public class FreeTimeState : State
    {
        Room hotelManagement;

        public FreeTimeState(Room hotelManagement)
        {
            this.hotelManagement = hotelManagement;
        }


        public void bookRoom() 
        {  
            Console.WriteLine("您已经成功预订了...");  
            hotelManagement.setState(hotelManagement.getBookedState());   //状态变成已经预订  
        }

        public void checkInRoom()
        {
            Console.WriteLine("您已经成功入住了...");  
            hotelManagement.setState(hotelManagement.getCheckInState());   //状态变成已经入住  
        }

        public void checkOutRoom()
        {
            //不需要做操作  
        }

        public void unsubscribeRoom()
        {
            //不需要做操作  
        }  
    }
}
