using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Xamarin.Model.Interfaces
{
    public interface IActive
    {
         DateTime ActivatedOn { get; set; }
         DateTime? DeActivatedOn { get; set; }
    }
}
