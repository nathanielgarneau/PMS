﻿using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class ProvinceViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}