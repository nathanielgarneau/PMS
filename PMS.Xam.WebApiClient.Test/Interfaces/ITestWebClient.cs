using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

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
