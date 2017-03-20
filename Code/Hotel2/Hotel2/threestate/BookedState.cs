﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2
{
    public class BookedState : State
    {
        Room hotelManagement;

        public BookedState(Room hotelManagement)
        {
            this.hotelManagement = hotelManagement;
        }

        public void bookRoom() 
        {
            Console.WriteLine("该房间已近给预定了...");  
        }

        public void checkInRoom() 
        {
            Console.WriteLine("入住成功...");   
            hotelManagement.setState(hotelManagement.getCheckInState());         //状态变成入住  
        }

        public void checkOutRoom()
        {
            //不需要做操作  
        }

        public void unsubscribeRoom() 
        {
            Console.WriteLine("退订成功,欢迎下次光临...");  
            hotelManagement.setState(hotelManagement.getFreeTimeState());   //变成空闲状态  
        }  
    }
}
