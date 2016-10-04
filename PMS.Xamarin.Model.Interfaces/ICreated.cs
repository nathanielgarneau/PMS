using System;

namespace PMS.Xam.Model.Interfaces
{
    public interface ICreated
    {
        int CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }
    }
}