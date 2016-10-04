using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class RateViewModel : IEntity<int>
    {
        public string Name;
        public double Value;
        public int Id { get; set; }
    }
}