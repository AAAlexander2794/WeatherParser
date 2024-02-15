using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers.RP5
{
    public class Day
    {
        public string День_недели { get; set; } = "";

        /// <summary>
        /// Список моментов дня, на которые спрогнозирована погода.
        /// </summary>
        public List<Weather> Weathers { get; set; } = new List<Weather>();

        ///// <summary>
        ///// Список данных о погоде за один день в виде списков нескольких значений.
        ///// </summary>
        //public WeatherTable Table { get; set; } = new WeatherTable();

        

        public void Add(WeatherTable table, int i)
        {
            //Table.Ветер_Направление.Add(table.Ветер_Направление[i]);
            //Table.Ветер_Порывы.Add(table.Ветер_Порывы[i]);
            //Table.Ветер_Скорость.Add(table.Ветер_Скорость[i]);
            //Table.Давление.Add(table.Давление[i]);
            ////Table.День_недели.Add(table.День_недели[i]);
            //Table.Местное_время.Add(table.Местное_время[i]);
            //Table.Облачность.Add(table.Облачность[i]);
            //Table.Осадки.Add(table.Осадки[i]);
            //Table.Ощущается_как.Add(table.Ощущается_как[i]);
            //Table.Температура.Add(table.Температура[i]);
            //Table.Туман.Add(table.Туман[i]);

            //
            WeatherView weatherView = new WeatherView();
            //
            weatherView.Ветер_Направление = table.Ветер_Направление[i];
            weatherView.Ветер_Порывы = table.Ветер_Порывы[i];
            weatherView.Ветер_Скорость = table.Ветер_Скорость[i];
            weatherView.Давление = table.Давление[i];
            //weatherView.День_недели = table.День_недели[i];
            weatherView.Местное_время = table.Местное_время[i];
            weatherView.Облачность = table.Облачность[i];
            weatherView.Осадки = table.Осадки[i];
            weatherView.Ощущается_как = table.Ощущается_как[i];
            weatherView.Температура = table.Температура[i];
            weatherView.Туман = table.Туман[i];
            //
            Weather weather = new Weather(weatherView);
            //
            Weathers.Add(weather);
        }

        #region

        ///// <summary>
        ///// 
        ///// </summary>
        //public WeatherTable Single { get; set; } = new WeatherTable();

        ///// <summary>
        ///// На основе <see cref="Table"/> строит 
        ///// </summary>
        ///// <returns></returns>
        //public WeatherTable CalculateSingle()
        //{
        //    //
        //    Single.День_недели.Add(Table.День_недели[0]);
        //    //

        //    for (int i = 0; i < Table.Местное_время.Count; i++)
        //    {
        //        if (Table.Местное_время[i] == "15")
        //        {
        //            return CalculateSingle(i);
        //        }
        //    }
        //    //
        //    return CalculateSingle(Table.Местное_время.Count - 1);
        //}

        //private WeatherTable CalculateSingle(int i)
        //{
        //    //
        //    Single.Ветер_Направление.Add(Table.Ветер_Направление[i]);
        //    Single.Ветер_Порывы.Add(Table.Ветер_Порывы[i]);
        //    Single.Ветер_Скорость.Add(Table.Ветер_Скорость[i]);
        //    Single.Давление.Add(Table.Давление[i]);
        //    //Single.День_недели.Add(Table.День_недели[i]);
        //    Single.Местное_время.Add(Table.Местное_время[i]);
        //    Single.Облачность.Add(Table.Облачность[i]);
        //    Single.Осадки.Add(Table.Осадки[i]);
        //    Single.Ощущается_как.Add(Table.Ощущается_как[i]);
        //    Single.Температура.Add(Table.Температура[i]);
        //    Single.Туман.Add(Table.Туман[i]);
        //    //
        //    return Single;
        //}

        #endregion
    }
}
