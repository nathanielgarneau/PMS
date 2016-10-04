namespace PMS.Xam.Model.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}