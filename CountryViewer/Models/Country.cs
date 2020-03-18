using System;
using System.Collections.Generic;


namespace CountryViewer.Models
{
    public class CountryModel
    {
        

        public CountryModel()
        {
            Currencies = new List<CurrencyModel>();
            Languages = new List<Language>();
           
        }

        public CountryModel(string alpha3Code, string name, int population, string flag, string[] timeZones, string capital, List<CurrencyModel> currencies, string[] borders, List<Language> languages)
        {
            Alpha3Code = alpha3Code ?? throw new ArgumentNullException(nameof(alpha3Code));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Population = population;
            Flag = flag ?? throw new ArgumentNullException(nameof(flag));
            TimeZones = timeZones ?? throw new ArgumentNullException(nameof(timeZones));
            Capital = capital ?? throw new ArgumentNullException(nameof(capital));
            Currencies = currencies ?? throw new ArgumentNullException(nameof(currencies));
            Borders = borders ?? throw new ArgumentNullException(nameof(borders));
            Languages = languages ?? throw new ArgumentNullException(nameof(languages));
        }



        //Alpha3code
        public string Alpha3Code { get; set; }
        //country name
        public string Name { get; set; }
        //population
        public int Population { get; set; }
        //public string Languages { get; set; }
        //flag
        public string Flag { get; set; }
        //timezone
        public string[] TimeZones { get; set; }
        //capital
        public string Capital { get; set; }
        //currency
        public List<CurrencyModel> Currencies { get; set; }
        ////bordering countries
        //private string[] Borders;
        public string[] Borders { get; set; }

        public List<Language> Languages { get; set; }


    }

    public class CurrencyModel
    {

        public string Code { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }
    }

    public class Language
    {
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
    }



}
