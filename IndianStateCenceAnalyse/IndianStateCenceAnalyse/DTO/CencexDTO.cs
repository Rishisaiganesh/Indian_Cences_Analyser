using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCenceAnalyse.POCO
{
    public class CencexDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string statecode;
        public long population;
        public long area;
        public long density;
        public long housingunits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;
        public CencexDTO(StateCodeDAO stateCodeDao)
        {
            this.serialNumber = stateCodeDao.serialNumber;
            this.stateName = stateCodeDao.stateName;
            this.tin = stateCodeDao.tin;
            this.statecode = stateCodeDao.stateCode;

        }
        public CencexDTO(CencexDAO cencexdad)
        {
            this.state = cencexdad.state;
            this.population = cencexdad.population;
            this.area = cencexdad.area;
            this.density = cencexdad.density;
        }

    }
}
