﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Pulsar4X.Entities
{
    public class Star
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Luminosity { get; set; }
        public double Mass { get; set; }
        public double Life { get; set; }
        public double Age { get; set; }
        public double EcoSphereRadius { get; set; }
        public int SpectrumAdjustment { get; set; }
        public StarSpectrum Spectrum { get; set; }

        public ObservableCollection<Planet> Planets { get; set; }
        public StarSystem StarSystem { get; set; }
        


        public Star()
        {
            Planets = new ObservableCollection<Planet>();
        }
    }
}
