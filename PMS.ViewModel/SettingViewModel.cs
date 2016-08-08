using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class SettingViewModel :IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
