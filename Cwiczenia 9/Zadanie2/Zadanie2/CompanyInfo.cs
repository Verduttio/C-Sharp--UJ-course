using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Zadanie2
{
    class CompanyInfoGrid
    {
        public string Name { get; set; }
        public double Rate { get; set; }
        public double Change { get; set; }

        private Label lRate;
        private Label lChange;
        private Grid colorChange;

        private Random rnd = new Random();

        public CompanyInfoGrid(string name, double rate, double change, Label labelRate, Label labelChange, Grid color)
        {
            Name = name;
            Rate = rate;
            Change = change;
            lRate = labelRate;
            lChange = labelChange;
            colorChange = color;
            StartExchange();
        }

        public void StartExchange()
        {
            var task = Task.Run(() => ExchangeLogic());
        }

        public void ExchangeLogic()
        {
            while (true)
            {
                Change = GetRandomNumber(-1, 1);
                Rate += Change;
                UpadateLabels();
                UpdateColor(Change);
                Thread.Sleep(5000);
            }
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            return rnd.NextDouble() * (maximum - minimum) + minimum;
        }

        public void UpadateLabels()
        {
            lChange.Dispatcher.Invoke(() => { lChange.Content = String.Format("{0:0.##}", Change) + " PLN"; });
            lRate.Dispatcher.Invoke(() => { lRate.Content = String.Format("{0:0.##}", Rate) + " PLN"; });
        }

        public void UpdateColor(double change)
        {
            if (change > 0) colorChange.Dispatcher.Invoke(() => { colorChange.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 255, 12)); });
            else colorChange.Dispatcher.Invoke(() => { colorChange.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(238, 13, 13)); });
        }

    }
}
