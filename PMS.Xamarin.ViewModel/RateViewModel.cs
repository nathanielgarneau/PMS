﻿using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class RateViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name;
        public double Value;

    }
}