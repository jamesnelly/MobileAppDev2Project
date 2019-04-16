using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Project.ViewModels
{
    class SpeedConvert : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        // using binding to convert 
        // kilometers to miles 
        /// </summary>
        private double KmToMile;
        public double kmtomile
        {
            get { return KmToMile; }
            set
            {
                KmToMile = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("kmtomile"));
                    PropertyChanged(this, new PropertyChangedEventArgs("kmtoMileAnswer"));
                }
            }
        }

        private double KMRate = 0.621371;
        public double kmrate
        {
            get { return KMRate; }
            set
            {
                KMRate = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("kmrate"));
                    PropertyChanged(this, new PropertyChangedEventArgs("kmtoMileAnswer"));
                }
            }
        }
        //Calculation for the conversion
        public double kmtoMileAnswer
        {
            set { string s = KmToMile + " * " + KMRate * (kmtomile * kmrate); }
            get { return kmtomile * kmrate; }
        }

        /// <summary>
        // using binding to convert 
        // miles to kilometers 
        /// </summary>

        private double MileToKM;
        public double miletokm
        {
            get { return MileToKM; }
            set
            {
                MileToKM = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("miletokm"));
                    PropertyChanged(this, new PropertyChangedEventArgs("MileToKMAnswer"));
                }
            }
        }

        private double MRate = 1.60;
        public double mrate
        {
            get { return MRate; }
            set
            {
                MRate = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("mrate"));
                    PropertyChanged(this, new PropertyChangedEventArgs("MileToKMAnswer"));
                }
            }
        }
        //Calculation for the conversion
        public double MileToKMAnswer
        {
            set { string s = MileToKM + " * " + MRate * (miletokm * mrate); }
            get { return miletokm * mrate; }
        }
    }
}
