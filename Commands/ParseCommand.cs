using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WeatherParser.Common;
using WeatherParser.Parsers.RP5;
using WeatherParser.ViewModels;

namespace WeatherParser.Commands
{
    public class ParseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly ViewModel _viewModel;

        public ParseCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            // Скачиваем html-страницы для каждого города
            foreach (var region in _viewModel.Regions)
            {
                //
                foreach (var town in region.Towns)
                {
                    town.HtmlDocument = Parser.GetHtml(town.Link_RP5);
                    //
                    Logger.Add($"Скачан {town.Name}");
                }
            }
            // Парсим уже скачанные страницы
            foreach (var region in _viewModel.Regions)
            {
                //
                foreach (var town in region.Towns)
                {
                    Parser_RP5.Parse(town.HtmlDocument, town);
                    //
                    Logger.Add($"Обработан {town.Name}");
                }
            }

            MessageBox.Show("Готово.");
        }
    }
}
