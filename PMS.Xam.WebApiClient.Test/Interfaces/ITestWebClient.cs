namespace PMS.Xam.WebApiClient.Test.Interfaces
{
    public interface ITestWebClient
    {
        void ConstructorTest();
        void GetListTest();
        void GetSingleTest();
        void GetAllTest();
        void AddTest();
        void AddManyTest();
        void UpdateTest();
        void UpdateManyTest();
        void RemoveTest();
        void RemoveManyTest();
    }
}