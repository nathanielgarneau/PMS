using System;

namespace PMS.Xam.Model.Interfaces
{
    public interface IModded
    {
        int ModdedBy { get; set; }
        DateTime ModdedOn { get; set; }
    }
}