using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Room
    {
        public static int FREEMTIME_STATE = 0;  //空闲状态

        public static int BOOKED_STATE = 1;     //已预订状态 

        public static int CHECKIN_STATE = 2;    //入住状态 


        int state = FREEMTIME_STATE;     //初始状态
        public Hotel hotel;
        public Room(Hotel hotel)
        {
            this.hotel = hotel;
        }
        /** 
         * @desc 预订 
         * @return void 
         */
        public void bookRoom()
        {  
            if(state == FREEMTIME_STATE){   //空闲可预订  
                if(hotel.Count > 0){  
                    Console.WriteLine("空闲房间，完成预订...");  
                    state =  BOOKED_STATE;     //改变状态：已预订  
                    hotel.Count --;  
                    //房间预订完了,提示客户没有房源了  
                    if(hotel.Count == 0){  
                        Console.WriteLine("不好意思,房间已经预订完,欢迎您下次光临...");  
                    }  
                }  
                else{  
                    Console.WriteLine("不好意思,已经没有房间了....");  
                }  
            }  
            else if(state == BOOKED_STATE){  
                Console.WriteLine("该房间已经被预订了...");  
            }  
            else if(state == CHECKIN_STATE){
                Console.WriteLine("该房间已经有人入住了...");  
            }  
        }

        /** 
         * @desc 入住 
         * @return void 
         */
        public void checkInRoom()
        {  
            if(state == FREEMTIME_STATE){  
                if(hotel.Count > 0){  
                    Console.WriteLine("空闲房间，入住...");  
                    state =  CHECKIN_STATE;     //改变状态：已预订  
                    hotel.Count --;  
                    //房间预订完了,提示客户没有房源了  
                    if(hotel.Count == 0){  
                       Console.WriteLine("不好意思,房间已经预订完,欢迎您下次光临...");  
                    }  
                }  
                else{  
                    Console.WriteLine("不好意思,已经没有房间了....");  
                }  
              
            }  
            else if(state == BOOKED_STATE){  
                state = CHECKIN_STATE; 
                Console.WriteLine("入住....");   
            }  
            else if(state == CHECKIN_STATE){
                Console.WriteLine("该房间已经入住了...");  
            }  
        }

        /** 
         * @desc 退订 
         * @return void 
         */
        public void unsubscribeRoom()
        {  
            if(state == FREEMTIME_STATE){  
            }  
            else if(state == CHECKIN_STATE){  
              
            }  
            else if(state == BOOKED_STATE){
                Console.WriteLine("已退订房间...");  
                state = FREEMTIME_STATE;  
                hotel.Count ++;  
            }  
        }

        /** 
         * @desc 退房 
         * @return void 
         */
        public void checkOutRoom()
        {  
            if(state == FREEMTIME_STATE){  
              
            }  
            else if(state == BOOKED_STATE){  
              
            }  
            else if(state == CHECKIN_STATE){
                Console.WriteLine("已退房..");  
                state = FREEMTIME_STATE;  
                hotel.Count++;  
            }  
        }  
    }
}
