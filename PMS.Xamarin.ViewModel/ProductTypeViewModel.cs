using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class ProductTypeViewModel : IEntity<int>
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}