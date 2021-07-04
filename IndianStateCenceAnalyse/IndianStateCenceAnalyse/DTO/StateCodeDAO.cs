using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCenceAnalyse.POCO
{
   public class StateCodeDAO
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        public StateCodeDAO(string V1, string v2, string v3, string v4)
        {
            this.serialNumber = Convert.ToInt32(V1);
            this.stateName = v2;
            this.tin = Convert.ToInt32(v3);
            this.stateCode = v4;
        }
    }
}
