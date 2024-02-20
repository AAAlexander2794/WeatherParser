using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WeatherParser.Common;

namespace WeatherParser.Parsers.RP5
{
    public static class Parser_RP5
    {
        public static Town Parse(IHtmlDocument? angle, Town town)
        {
            //
            if (angle == null) return town;
            // Таблица с данными
            var divs = angle.QuerySelector(".forecastTable");
            //
            if (divs == null) return town;
            //// DEBUG
            //string str = "";
            //if (town.Name == "Луганск")
            //{ str = "stop"; }
            //
            var weatherTable = ParseToWeatherTable(divs);
            //
            town.Days = Parse(weatherTable, town);
            //
            return town;
        }

        private static List<Day> Parse(WeatherTable weatherTable, Town town)
        {
            List<Day> days = new List<Day>();
            // Добавляем все дни
            for (int i = 0; i < weatherTable.День_недели.Count; i++)
            {
                days.Add(new Day() { Town = town });
                days[days.Count - 1].День_недели = weatherTable.День_недели[i];
            }
            // Счетчик дня
            int dayCounter = 0;
            // Первый элемент - название, поэтому со второго
            for (int i = 1; i < weatherTable.Местное_время.Count; i++)
            {
                // Добавляем к текущему дню
                Add(days[dayCounter], weatherTable, i);
                // Последний столбец суток - 21 час
                if (weatherTable.Местное_время[i] == "21")
                {
                    // Переходим в новый день, т.к. следующий столбец нового дня
                    dayCounter++;
                }
            }
            //
            return days;
        }

        public static void Add(Day day, WeatherTable table, int i)
        {
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
            if (table.Туман.Count - 1 < i)
            {
                weatherView.Туман = "";
            }
            else
            {
                weatherView.Туман = table.Туман[i];
            }
            //
            Weather weather = new Weather(weatherView);
            //
            day.Weathers_RP5.Add(weather);
        }


        private static WeatherTable ParseToWeatherTable(IElement divs)
        {
            // 
            WeatherTable table = new WeatherTable();
            // Строки таблицы
            var rows = divs.QuerySelectorAll("tr");
            // Первые две строки должны присутствовать в этом порядке, поэтому их обрабатываем
            // 1. Все дни недели
            foreach (IElement div in rows[0].QuerySelectorAll(".forecastDate > td"))
            {
                table.День_недели.Add(div.TextContent.Trim());
            }
            // 2.
            foreach (IElement div in rows[1].QuerySelectorAll(".forecastTime > td"))
            {
                table.Местное_время.Add(div.TextContent.Trim());
            }
            // Остальные строки могут быть, а могут и не быть, поэтому по каждой идем и смотрим на title.
            for (int i = 2; i < rows.Length; i++)
            {
                // Если первая ячейка строки содержит определенный текст, относим ее к определенному элементу погоды
                if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("Облачность"))
                {
                    // 3.
                    table.Облачность.Add("Облачность, %");
                    foreach (IElement div in rows[i].QuerySelectorAll("div.cc_0 > div"))
                    {
                        string text = "";
                        if (div.HasAttribute("onmouseover"))
                        {
                            text = GetBetweenStrings(div.GetAttribute("onmouseover"), "<b>", "</b>");
                        }
                        table.Облачность.Add(text);
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("Осадки"))
                {
                    // 4.
                    table.Осадки.Add("Осадки");
                    foreach (IElement div in rows[i].QuerySelectorAll("div.pr_0"))
                    {
                        string text = "";
                        if (div.HasAttribute("onmouseover"))
                        {
                            string? divValue = div.GetAttribute("onmouseover");
                            text = GetBetweenStrings(divValue, "this, '", " (");
                        }
                        table.Осадки.Add(text);
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("Туман"))
                {
                    // 5.
                    foreach (IElement div in rows[i].QuerySelectorAll("td"))
                    {
                        table.Туман.Add(div.TextContent.Trim());
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("Температура"))
                {
                    // 6.
                    foreach (IElement div in rows[i].QuerySelectorAll(".t_0"))
                    {
                        table.Температура.Add(div.TextContent.Trim());
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("Ощущается"))
                {
                    // 7.
                    foreach (IElement div in rows[i].QuerySelectorAll("td"))
                    {
                        table.Ощущается_как.Add(div.TextContent.Trim());
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("Давление"))
                {
                    // 8.
                    foreach (IElement div in rows[i].QuerySelectorAll(".p_0"))
                    {
                        table.Давление.Add(div.TextContent.Trim());
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("скорость"))
                {
                    // 9.
                    foreach (IElement div in rows[i].QuerySelectorAll(".wv_0"))
                    {
                        table.Ветер_Скорость.Add(div.TextContent.Trim());
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("порывы"))
                {
                    // 10.
                    table.Ветер_Порывы.Add("Порывы, м/с");
                    foreach (IElement div in rows[i].QuerySelectorAll("div.wv_0"))
                    {
                        table.Ветер_Порывы.Add(div.TextContent.Trim());
                    }
                }
                else if (rows[i].QuerySelectorAll("td")[0].TextContent.Contains("направление"))
                {
                    // 11.
                    foreach (IElement div in rows[i].QuerySelectorAll("td"))
                    {
                        table.Ветер_Направление.Add(div.TextContent.Trim());
                    }
                }
            }
            //
            return table;
        }

        private static string GetBetweenStrings(string? text, string startString, string endString)
        {
            if (text == null) return "";
            int pFrom = text.IndexOf($"{startString}") + $"{startString}".Length;
            int pTo = text.LastIndexOf($"{endString}");
            if (pTo < 0 || pTo < pFrom) return "";
            String result = text.Substring(pFrom, pTo - pFrom);
            return result;
        }

    }
}
