﻿using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers.RP5
{
    public static class Parser_RP5
    {
        public static Town Parse(IHtmlDocument angle, string townName)
        {
            //
            Town town = new Town()
            { 
                Name = townName
            };
            //
            if (angle == null) return town;
            // Таблица с данными
            var divs = angle.QuerySelector(".forecastTable");
            //
            if (divs == null) return town;
            //
            var weatherTable = ParseToWeatherTable(divs);
            //
            town.Days = Parse(weatherTable);
            //
            return town;
        }

        private static List<Day> Parse(WeatherTable weatherTable)
        {
            List<Day> days = new List<Day>();
            // Добавляем все дни
            for (int i = 0; i < weatherTable.День_недели.Count; i++)
            {
                days.Add(new Day());
                days[days.Count - 1].День_недели = weatherTable.День_недели[i];
            }
            // Счетчик дня
            int dayCounter = 0;
            // Первый элемент - название, поэтому со второго
            for (int i = 1; i < weatherTable.Местное_время.Count; i++)
            {
                // Добавляем к текущему дню
                days[dayCounter].Add(weatherTable, i);
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



        private static WeatherTable ParseToWeatherTable(IElement divs)
        {
            // 
            WeatherTable table = new WeatherTable();
            // Строки таблицы
            var rows = divs.QuerySelectorAll("tr");
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
            // 3.
            foreach (IElement div in rows[2].QuerySelectorAll(".cc_0"))
            {
                table.Облачность.Add(div.TextContent.Trim());
            }
            // 4.
            foreach (IElement div in rows[3].QuerySelectorAll(".pr_0"))
            {
                table.Осадки.Add(div.TextContent.Trim());
            }
            // 5.
            foreach (IElement div in rows[4].QuerySelectorAll("td"))
            {
                table.Туман.Add(div.TextContent.Trim());
            }
            // 6.
            foreach (IElement div in rows[5].QuerySelectorAll(".t_0"))
            {
                table.Температура.Add(div.TextContent.Trim());
            }
            // 7.
            foreach (IElement div in rows[6].QuerySelectorAll(".t_0"))
            {
                table.Ощущается_как.Add(div.TextContent.Trim());
            }
            // 8.
            foreach (IElement div in rows[7].QuerySelectorAll(".p_0"))
            {
                table.Давление.Add(div.TextContent.Trim());
            }
            // 9.
            foreach (IElement div in rows[8].QuerySelectorAll(".wv_0"))
            {
                table.Ветер_Скорость.Add(div.TextContent.Trim());
            }
            // 10.
            foreach (IElement div in rows[9].QuerySelectorAll(".wv_0"))
            {
                table.Ветер_Порывы.Add(div.TextContent.Trim());
            }
            // 11.
            foreach (IElement div in rows[10].QuerySelectorAll("td"))
            {
                table.Ветер_Направление.Add(div.TextContent.Trim());
            }
            //
            return table;
        }

    }
}