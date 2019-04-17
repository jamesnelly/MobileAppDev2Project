using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project.ViewModels
{
    class TimeConvert : INotifyPropertyChanged
    {
        public List<Time> TimeList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public TimeConvert()
        {
            TimeList = GetTime().OrderBy(t => t.Name).ToList();
        }

        public class Time
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Rate { get; set; }
        }

        public List<Time> GetTime()
        {
            var times = new List<Time>()
        {
            new Time(){ID = 1, Name="Second's To Minutes",Rate = 0.01666667 },
            new Time(){ID = 2, Name="Minutes To Hour's",Rate = 0.01666667 },
            new Time(){ID = 3, Name="Hour's To Days",Rate = 0.0416667 },
            new Time(){ID = 4, Name="Days's To Week",Rate = 0.142857 },
            new Time(){ID = 5, Name="Week's To Years",Rate = 0.0191781 }
        };
            return times;
        }

        public Time _SelectedTime { get; set; }
        public Time SelectedTime
        {
            get { return _SelectedTime; }
            set
            {
                if (_SelectedTime != value)
                {
                    _SelectedTime = value;
                      MYTime = "You Selected : " + _SelectedTime.Name;
                      Result = (Input * _SelectedTime.Rate);
                       
                }
            }
        }

        private string _MYTime { get; set; }
        public string MYTime
        {
            get { return _MYTime; }
            set
            {
                if (_MYTime != value)
                {
                    _MYTime = value;
                    OnPropertyChanged();
                }
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
    }
}
