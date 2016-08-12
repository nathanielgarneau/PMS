using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;
using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Client<T,TX>: BasicHttpClient<T,TX> where T : IEntity<TX> 
    {
        public Client(string apiAddress) : base(apiAddress)
        {
        }
    }
}
