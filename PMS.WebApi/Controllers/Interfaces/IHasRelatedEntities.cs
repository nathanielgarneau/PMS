namespace PMS.WebApi.Controllers.Interfaces
{
    internal interface IHasRelatedEntities<T> where T : class
    {
        T AttachRelations(T item);
    }
}