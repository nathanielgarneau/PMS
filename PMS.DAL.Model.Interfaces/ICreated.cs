using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMS.DAL.Model.Interfaces
{
      public interface ICreated
    {
         int CreatedBy { get; set; }
         DateTime CreatedOn { get; set; }
    }
}
