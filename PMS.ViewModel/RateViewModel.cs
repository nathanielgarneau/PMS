﻿using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class RateViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name;
        public double Value;

    }
}