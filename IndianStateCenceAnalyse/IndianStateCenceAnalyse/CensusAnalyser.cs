using System;
using System.Collections.Generic;
using System.Linq;
using IndianStateCenceAnalyse.POCO;
using Newtonsoft.Json;
using System.Text;

namespace IndianStateCenceAnalyse
{
   public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
