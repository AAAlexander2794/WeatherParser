using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherParser.Common;
using WeatherParser.Processors;
using WeatherParser.ViewModels;

namespace WeatherParser.Commands
{
    public class LoadDataCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly ViewModel _viewModel;

        public LoadDataCommand(ViewModel viewModel)
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
                    town.HtmlDocument = Loader.GetHtml(town.Link_RP5);
                    //
                    Logger.Add($"Скачан {town.Name}.");
                }
            }
            //
            Logger.Add($"Скачаны данные по городам.");
        }
    }
}
