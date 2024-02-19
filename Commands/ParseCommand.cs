using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WeatherParser.Common;
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
            var regions = Parser.Do();
            Saver.SaveData(regions);
           
            List<Town> towns = new List<Town>();

            foreach (var region in regions)
            {
                foreach (var town in region.Towns)
                {
                    towns.Add(town);
                    
                }
            }
            
            _viewModel.Towns = new ObservableCollection<Town>(towns);

            MessageBox.Show("Готово.");
        }
    }
}
