using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    /*************************抽象产品与工厂***************************/
    public abstract class AbstractFactoty
    {
        public abstract AbstractDrive Drive();
        public abstract AbstractRepair Repair();
    }
    public abstract class AbstractDrive
    {
        public abstract void Drive();
    }
    public abstract class AbstractRepair
    {
        public abstract void Repair();
    }


    /*************************具体产品与工厂***************************/
    public class DriveBMW : AbstractDrive
    {
        public override void Drive()
        {
            Console.WriteLine("会开宝马");
        }
    }

    public class RepairBMW : AbstractRepair
    {
        public override void Repair()
        {
            Console.WriteLine("会修宝马");
        }
    }

    public class DriveAudi : AbstractDrive
    {
        public override void Drive()
        {
            Console.WriteLine("会开奥迪");
        }
    }

    public class RepairAudi : AbstractRepair
    {
        public override void Repair()
        {
            Console.WriteLine("会修奥迪");
        }
    }

    public class PeopleA : AbstractFactoty
    {
        public override AbstractDrive Drive()
        {
            return new DriveBMW();
        }

        public override AbstractRepair Repair()
        {
            return new RepairBMW();
        }
    }

    public class PeopleB : AbstractFactoty
    {
        public override AbstractDrive Drive()
        {
            return new DriveAudi();
        }

        public override AbstractRepair Repair()
        {
            return new RepairAudi();
        }
    }


    public class ClientTest
    {
        AbstractDrive drive;
        AbstractRepair repair;
        public ClientTest(AbstractFactoty factory)
        {
            drive = factory.Drive();
            repair = factory.Repair();
        }
        public void Run()
        {
            drive.Drive();
            repair.Repair();
        }
    }
}
