using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherParser.Common;
using WeatherParser.ViewModels;

namespace WeatherParser.Commands
{
    public class SaveDataCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly ViewModel _viewModel;

        public SaveDataCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Берем только завтрашний день: ночь (03 часа) и день (15 часов)
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            Saver.SaveData(_viewModel.Regions.ToList());
            Logger.Add("Файлы созданы");
        }
    }
}
