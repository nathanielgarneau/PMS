using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.Model.Interfaces
{
    public interface IModded
    {
         int ModdedBy { get; set; }
         DateTime ModdedOn { get; set; }
    }
}
