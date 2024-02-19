using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WeatherParser.Common
{
    public static class Saver
    {
        public static void SaveData(List<Region> regions)
        {
            foreach (Region region in regions)
            {
                var dt = BuildTable(region);
                SaveTable(dt, $"{region.Name}.xlsx");
            }
        }

        public static DataTable BuildTable(Region region)
        {
            DataTable dt = new DataTable();
            //
            dt.Columns.Add("Город");
            dt.Columns.Add("День: Температура");
            dt.Columns.Add("День: Облачность");
            dt.Columns.Add("День: Явление погоды");
            dt.Columns.Add("День: Направление ветра");
            dt.Columns.Add("День: Сила ветра");
            dt.Columns.Add("День: Атм. давление");
            //
            dt.Columns.Add("Ночь: Температура");
            dt.Columns.Add("Ночь: Облачность");
            dt.Columns.Add("Ночь: Явление погоды");
            dt.Columns.Add("Ночь: Направление ветра");
            dt.Columns.Add("Ночь: Сила ветра");
            dt.Columns.Add("Ночь: Атм. давление");
            //
            foreach (var town in region.Towns)
            {
                if (town.Days.Count == 0) continue;
                //
                Day tomorrow = town.Days.First(d => d.День_недели.Contains("Завтра"));
                //
                dt.Rows.Add();
                dt.Rows[dt.Rows.Count - 1][0] = town.Name;
                // День
                dt.Rows[dt.Rows.Count - 1][1] = tomorrow.Weathers_RP5[2].View.Температура;
                dt.Rows[dt.Rows.Count - 1][2] = tomorrow.Weathers_RP5[2].View.Облачность;
                dt.Rows[dt.Rows.Count - 1][3] = tomorrow.Weathers_RP5[2].View.Осадки;
                dt.Rows[dt.Rows.Count - 1][4] = tomorrow.Weathers_RP5[2].View.Ветер_Направление;
                dt.Rows[dt.Rows.Count - 1][5] = tomorrow.Weathers_RP5[2].View.Ветер_Скорость;
                dt.Rows[dt.Rows.Count - 1][6] = tomorrow.Weathers_RP5[2].View.Давление;
                // Ночь
                dt.Rows[dt.Rows.Count - 1][7] = tomorrow.Weathers_RP5[0].View.Температура;
                dt.Rows[dt.Rows.Count - 1][8] = tomorrow.Weathers_RP5[0].View.Облачность;
                dt.Rows[dt.Rows.Count - 1][9] = tomorrow.Weathers_RP5[0].View.Осадки;
                dt.Rows[dt.Rows.Count - 1][10] = tomorrow.Weathers_RP5[0].View.Ветер_Направление;
                dt.Rows[dt.Rows.Count - 1][11] = tomorrow.Weathers_RP5[0].View.Ветер_Скорость;
                dt.Rows[dt.Rows.Count - 1][12] = tomorrow.Weathers_RP5[0].View.Давление;
            }

            //
            return dt;
        }

        public static DataTable SaveTable(DataTable dt, string path)
        {
            // Запись в файл Excel
            XLWorkbook wb = new XLWorkbook();
            var ws = wb.Worksheets.Add(dt, "Отчет");
            ws.Columns().AdjustToContents();
            wb.SaveAs(path);
            return dt;
        }
    }
}
