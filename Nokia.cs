using System;
using System.Collections.Generic;
using System.Text;

namespace MobiHier
{
    public class Nokia : IMobile
    {
        private string Chip = "It has chip . ";

        public string Camera()
        {
            return("They have cameras . ");
        }

        public string CPU()
        {
            return("They have Octa-core CUP . ");
        }

        public string OperationSystem()
        {
           return("They work with Android operation system . ");
        }

        public string RAM()

        {
            return ("They have 2GB,4GB,6GB,8GB,12GB RAM . ");
        }

        public string InternalMemory()
        {

            return ("They have 8GB,16GB,32GB,64GB,128GB,256GB internal memory . ");

        }

        public string SIM()
        {
            return ("They have one or 2 SIM cards . ");
        }
        

        public class NokiaX6 : Nokia 
        {

            public string UsePrivateMember() 
            {
                return this.Chip;
            }

            public new string Camera()
            {
                return ("It has 2 cameras . ");
            }

            public new string CPU()
            {
                return ("It has Octa-core CPU. ");
            }

            public new string OperationSystem()
            {
                return ("It works with Android 8.1 . ");
            }

            public new string RAM()

            {
                return ("It has  4GB,6GB RAM . ");
            }

            public new string InternalMemory()
            {

                return ("It has 32GB,64GB . ");

            }

            public new string SIM()
            {
                return ("It has hybrid Dual SIM . ");
            }

        }

    }
}
