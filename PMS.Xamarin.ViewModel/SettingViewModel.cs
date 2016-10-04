using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class SettingViewModel : IEntity<int>
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int Id { get; set; }
    }
}