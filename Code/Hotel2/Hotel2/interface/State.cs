using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2
{
    public interface State
    {
         /**  
         * @desc 预订房间  
         * @return void  
         */  
        void bookRoom();  
      
        /**  
         * @desc 退订房间  
         * @return void  
         */  
        void unsubscribeRoom();  
      
        /**  
         * @desc 入住  
         * @return void  
         */  
       void checkInRoom();  
      
        /**  
         * @desc 退房  
         * @return void  
         */  
        void checkOutRoom();  
      
    }  
}
