using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Project.ViewModels
{
    class TempConvert : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        // using binding to convert 
        // kilometers to miles 
        /// </summary>
        private double CelToFar;
        public double celtofar
        {
            get { return CelToFar; }
            set
            {
                CelToFar = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("celtofar"));
                    PropertyChanged(this, new PropertyChangedEventArgs("celTofarAnswer"));
                }
            }
        }

        private double CelRate = 1.8;
        public double celrate
        {
            get { return CelRate; }
            set
            {
                CelRate = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("celrate"));
                    PropertyChanged(this, new PropertyChangedEventArgs("celTofarAnswer"));
                }
            }
        }
        //Calculation for the conversion
        public double celTofarAnswer
        {
            set { string s = CelToFar + " * " + CelRate * ((celtofar * celrate) + 32); }
            get { return (celtofar * celrate) +32; }
        }

        /// <summary>
        // using binding to convert 
        // miles to kilometers 
        /// </summary>

        private double FartoCel = 32;
        public double fartocel
        {
            get { return FartoCel; }
            set
            {
                FartoCel = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("fartocel"));
                    PropertyChanged(this, new PropertyChangedEventArgs("FarToCelAnswer"));
                }
            }
        }

        private double FarRate = 32;
        public double farrate
        {
            get { return FarRate; }
            set
            {
                 FarRate = value;
                //check if changed
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("farrate"));
                    PropertyChanged(this, new PropertyChangedEventArgs("FarToCelAnswer"));
                }
            }
        }
        //Calculation for the conversion
        public double FarToCelAnswer
        {
            set { string s = FartoCel + " - " + FarRate * ((fartocel - farrate)) /1.8; }
            get { return (fartocel - farrate) / 1.8; }
        }
    }
}
    
