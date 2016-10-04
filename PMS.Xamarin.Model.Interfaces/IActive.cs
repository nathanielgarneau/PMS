using System;

namespace PMS.Xam.Model.Interfaces
{
    public interface IActive
    {
        DateTime ActivatedOn { get; set; }
        DateTime? DeActivatedOn { get; set; }
    }
}