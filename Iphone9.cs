using System;
using System.Collections.Generic;
using System.Text;

namespace MobiHier
{
   public class Iphone9 : Apple

    {
        

        public new string Camera()
        {
            return ("It has one camera .");
        }

        public new string CPU()
        {
            return ("It has Apple A12Z Bionic CPU .");
        }

        public new string OperationSystem()
        {
            return ("It works with IOS. ");
        }

        public new string RAM()

        {
            return ("It has 2GB RAM. ");
        }

        public new string SIM()
        {
            return ("It has a SIM card!");
        }

        public override string Chip()
        {
            return base.Chip();
        }

        public new string InternalMemory()
        {

            return ("It has 32GB,64GB,128GB,256GB internal memory . ");

        }
    }
}
