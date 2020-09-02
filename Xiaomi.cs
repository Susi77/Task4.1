using System;
using System.Collections.Generic;
using System.Text;

namespace MobiHier
{
    public class Xiaomi:IMobile
    {
        protected bool Chip = true;

        public string CPU() 
        {
            return ("They have Octa-core CPU . ");
        }

        public string RAM()

        {
            return ("They have 2GB,4GB,6GB,8GB,12GB RAM . ");
        }

        public string OperationSystem()
        {
            return ("They works with Android . ");
        }

        public string Camera() 
        {
         return("They have cameras ." );
        }

        public string InternalMemory()
        {

            return ("It has 8GB,16GB,32GB,64GB,128GB,256GB internal memory .");

        }

        public string SIM()
        {
            return ("They have at least one SIM card. ");
        }

       
    }

    public class Note9s : Xiaomi 
    
    {
        public bool UseProtectedMember() 
        {
            return this.Chip;
        }

        public new string CPU()
        {
            return ("It has Octa-core CPU . ");
        }

        public new string RAM()

        {
            return ("It has 4GB,6GB RAM . ");
        }

        public new string OperationSystem()
        {
            return ("It works with Android 10 . ");
        }

        public new string Camera()
        {
            return ("It has 2 cameras .");
        }

        public new string InternalMemory()
        {

            return ("It has 64GB,128GB internal memory");

        }

        public new string SIM()
        {
            return ("It has Dual SIM !");
        }


    }
}
