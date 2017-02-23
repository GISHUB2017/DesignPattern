using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {


            StoreOrBranch store = new StoreOrBranch("朝阳总店");
            StoreOrBranch brach = new StoreOrBranch("东城分店");
            JoinInStore jstore = new JoinInStore("海淀加盟店一");
            JoinInStore jstore1 = new JoinInStore("上地加盟店二");

            brach.Add(jstore);
            brach.Add(jstore1);
            store.Add(brach);

            store.PayByCard();
            Console.ReadKey();
        }


        public abstract class Storefront
        {
            //店名
            protected string storeName = string.Empty;
            public string StoreName
            {
                get
                {
                    return storeName;
                }
            }

            //添加店面
            public abstract void Add(Storefront store);
            //删除店面
            public abstract void Remove(Storefront store);

            //定义所有部件公用的行为 刷卡行为
            public abstract void PayByCard();
        }

        public class StoreOrBranch : Storefront
        {
            //构造函数
            public StoreOrBranch() { }
            public StoreOrBranch(string storeName)
            {
                this.storeName = storeName;
            }
            List<Storefront> myStoreList = new List<Storefront>();
            //刷卡消费
            public override void PayByCard()
            {
                Console.WriteLine("店面{0}的积分已累加进该会员卡", storeName);
                foreach (Storefront sf in myStoreList)
                {
                    sf.PayByCard();
                }
            }

            //增加店面
            public override void Add(Storefront store)
            {
                myStoreList.Add(store);
            }

            //解除店面
            public override void Remove(Storefront store)
            {
                myStoreList.Remove(store);
            }
        }

        public class JoinInStore : Storefront
        {
            //构造函数
            public JoinInStore() { }
            public JoinInStore(string storeName)
            {
                this.storeName = storeName;
            }
            //刷卡消费
            public override void PayByCard()
            {
                Console.WriteLine("店面{0}的积分已累加进该会员卡", storeName);
            }

            public override void Add(Storefront store)
            {
                throw new NotImplementedException();
            }

            public override void Remove(Storefront store)
            {
                throw new NotImplementedException();
            }
        }


    }
}



