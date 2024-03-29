﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WeatherParser.Commands;
using WeatherParser.Common;
using WeatherParser.Parsers.RP5;
using WeatherParser.Processors;

namespace WeatherParser.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> LogRecords { get => Logger.LogRecords; }

        private ObservableCollection<Region> _regions = 
            new ObservableCollection<Region>(DefaultRegions.CreateRegions());
        /// <summary>
        /// Регионы
        /// </summary>
        public ObservableCollection<Region> Regions
        {
            get => _regions;
            set
            {
                _regions = value;
                OnPropertyChanged();
            }
        }

        private Region? _currentRegion;

        public Region? CurrentRegion
        {
            get => _currentRegion;
            set
            {
                _currentRegion = value;
                OnPropertyChanged();
            }
        }

        //private ObservableCollection<Town> _towns = new ObservableCollection<Town>();
        ///// <summary>
        ///// Города
        ///// </summary>
        //public ObservableCollection<Town> Towns { get => _towns; set
        //    {
        //        _towns = value;
        //        OnPropertyChanged();
        //    }
        //}

        private Town? _currentTown;
        /// <summary>
        /// Текущий город
        /// </summary>
        public Town? CurrentTown { get => _currentTown;
        set
            {
                _currentTown = value;
                OnPropertyChanged();
            }
        }

        private Day? _currentDay;
        /// <summary>
        /// Текущий день
        /// </summary>
        public Day? CurrentDay { get => _currentDay;
        set
            {
                _currentDay = value;
                OnPropertyChanged();
            }
        }

        private Weather? _currentWeather_rp5;
        /// <summary>
        /// Текущая погода (РП5)
        /// </summary>
        public Weather? CurrentWeather_rp5
        {
            get => _currentWeather_rp5;
            set
            {
                _currentWeather_rp5 = value;
                OnPropertyChanged();
            }
        }

        #region Команды

        public LoadDataCommand LoadDataCommand { get; set; }

        public ParseCommand ParseCommand { get; set; }

        public SaveDataCommand SaveDataCommand { get; set; }

        #endregion Команды

        public ViewModel()
        {
            LoadDataCommand = new LoadDataCommand(this);
            ParseCommand = new ParseCommand(this);
            SaveDataCommand = new SaveDataCommand(this);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
