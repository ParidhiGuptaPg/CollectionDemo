using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondday9_7_21
{
    abstract class RBI
    {
        internal string rule = "Customer should have aadhar card";
        //Abstract Method
        abstract public int HomeLoan();

        abstract public int EduLoan();

        //Non Abstract Method

        internal void Rules()
        {
            Console.WriteLine("Rules to be followed by all bank:{0}", rule);
        }


    }
    abstract class SBI : RBI
    {
        //SBI abstract method
        abstract public void SBICustomer();

        //RBI Abstract Method
        public override int HomeLoan()
        {
            return 8;
        }


        public override int EduLoan()
        {
            return 10;
        }


    }

    class SBIBranch : SBI
    {
        public override void SBICustomer()
        {
            Console.WriteLine("It has 1 Lakh customer");
        }
    }
    class AbstractEg
    {
        static void Main()
        {
            //object cant be created for abstract class
            // RBI r = new RBI();

            /*   SBI sbiobj = new SBI();
 
               Console.WriteLine("SbiHomeLoan:{0}",sbiobj.HomeLoan());
               Console.WriteLine("SbiEDULoan:{0}", sbiobj.EduLoan());
 
               sbiobj.Rules();*/
            /*  SBIBranch sBIBranchobj = new SBIBranch();
              Console.WriteLine("SbiHomeLoan:{0}",sBIBranchobj.EduLoan());
              Console.WriteLine("SbiEDULoan:{0}",sBIBranchobj.HomeLoan()); 
              sBIBranchobj.SBICustomer();
              sBIBranchobj.Rules();*/

            //run time Polymorphism

            //reference of parent class
            RBI rbiobj = new SBIBranch();
            //Object of child class 
            Console.WriteLine("SbiHomeLoan:{0}", rbiobj.EduLoan());
            Console.WriteLine("SbiEDULoan:{0}", rbiobj.HomeLoan());

            SBI sbiobj = new SBIBranch();
            sbiobj.SBICustomer();

            sbiobj.Rules();
            rbiobj.Rules();
        }
    }
}