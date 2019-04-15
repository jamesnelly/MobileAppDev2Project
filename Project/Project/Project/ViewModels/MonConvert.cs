using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project
{
    public class Money : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public List<Currency> CurrencyList { get; set; }

        public Currency _SelectedCurrency { get; set; }
        public Currency SelectedCurency
        {
            get { return _SelectedCurrency; }
            set
            {
                if (_SelectedCurrency != value)
                {
                    _SelectedCurrency = value;
                    MYCurency = "You Selected : " + _SelectedCurrency.Name;
                    Convert = "you selected : " + _SelectedCurrency.Rate;
                    Result = (Input * _SelectedCurrency.Rate);
                }
            }
        }

        private string _MYCurrency { get; set; }
        public string MYCurency
        {
            get { return _MYCurrency; }
            set
            {
                if (_MYCurrency != value)
                {
                    _MYCurrency = value;
                    OnPropertyChanged();
                }
            }
        }

        public Money()
        {
            CurrencyList = GetCurrencies().OrderBy(t => t.Name).ToList();
        }

        public class Currency
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Rate { get; set; }
        }

        double result;
        public double Result
        {
            get { return result; }
            set
            {
                if (result == value)

                return;
                result = value;

                OnPropertyChanged(nameof(Result));
                OnPropertyChanged(nameof(Input));
                // PropertyChanged(this, new PropertyChangedEventArgs("Result"));
                // PropertyChanged(this, new PropertyChangedEventArgs("Input"));



            }
            
        }

        double input;
        public double Input
        {
            get { return input; }
            set
            {
               // input = value;
                if (input == value)
                
                    return;
                    input = value;
                OnPropertyChanged(nameof(Input));
                OnPropertyChanged(nameof(Result));
              
                // PropertyChanged(this, new PropertyChangedEventArgs("Input"));
                //PropertyChanged(this, new PropertyChangedEventArgs("Result"));
            }
        }

        // PropertyChangedEventHandler

        //public ObservableCollection<string> Rate { get; set; } = new ObservableCollection<string>();


        public List<Currency> GetCurrencies()
        {
            var currencies = new List<Currency>()
        {
            new Currency(){ID = 1, Name="Euro To Pound",Rate = 0.85 },
            new Currency(){ID = 2, Name="Euro To US Dollar",Rate = 1.12 },
            new Currency(){ID = 3, Name="Euro To Yen",Rate = 125.50 }
        };
            return currencies;
        }
    }
}
