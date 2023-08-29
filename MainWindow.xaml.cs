using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var regions = Parser.Do();
            Saver.SaveData(regions);
            string text = "";
            foreach (var region in regions)
            {
                foreach (var town in region.Towns)
                {
                    text += town.Name + "\n";
                    foreach (var w in town.WeatherList)
                    {
                        text += w.ToString() + "\n\n";
                    }
                    text += "\n";
                }
            }
            tbResult.Text = text;
            //File.WriteAllText("data.html", text);
            MessageBox.Show("Готово.");
        }
    }
}
