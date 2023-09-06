using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WeatherParser
{
    public static class Saver
    {
        public static DataTable SaveData(List<Region> regions)
        {
            var dt = BuildTable(regions);
            SaveTable(dt, "data.xlsx");
            return dt;
        }

        public static DataTable BuildTable(List<Region> regions)
        {
            DataTable dt = new DataTable();
            //
            dt.Columns.Add("Регион");
            dt.Columns.Add("Город");
            dt.Columns.Add("Дата");
            dt.Columns.Add("Мин. темп.");
            dt.Columns.Add("Макс. темп.");
            dt.Columns.Add("Средняя темп.");
            dt.Columns.Add("Влажность");
            dt.Columns.Add("Ветер");
            //
            foreach(Region region in regions)
            {
                foreach (var town in region.Towns)
                {
                    foreach (var weather in town.WeatherList)
                    {
                        dt.Rows.Add();
                        dt.Rows[dt.Rows.Count - 1][0] = region.Name;
                        dt.Rows[dt.Rows.Count - 1][1] = town.Name;
                        dt.Rows[dt.Rows.Count - 1][2] = weather.Date;
                        dt.Rows[dt.Rows.Count - 1][3] = weather.TemperatureMin;
                        dt.Rows[dt.Rows.Count - 1][4] = weather.TemperatureMax;
                        dt.Rows[dt.Rows.Count - 1][5] = weather.Temperature;
                        dt.Rows[dt.Rows.Count - 1][6] = weather.Humidity;
                        dt.Rows[dt.Rows.Count - 1][7] = weather.Wind;
                    }
                }
            }
            //
            return dt;
        }

        public static DataTable SaveTable(DataTable dt, string path)
        {
            // Запись в файл Excel
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "Отчет");
            wb.SaveAs(path);
            return dt;
        }
    }
}
