﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMS.Xam.Model.Interfaces;
using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Facility<T,TX>: BasicHttpClient<T,TX> where T : IEntity<TX> 
    {
        public Facility(string apiAddress) : base(apiAddress)
        {
        }
    }
}