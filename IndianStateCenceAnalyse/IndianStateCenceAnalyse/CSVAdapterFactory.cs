using System;
using System.Collections.Generic;
using IndianStateCenceAnalyse.POCO;
using System.Text;

namespace IndianStateCenceAnalyse
{
   public class CSVAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA) :
                    return new IndianCensusAdpter().LoadCensusData(csvFilePath, dataHeaders);
                case (CensusAnalyser.Country.US):
                    return new USCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("No such Country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);


            }
        }
    }
}
