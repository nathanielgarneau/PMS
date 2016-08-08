using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMS.BLL
{
    public class BusinessLayer
    {
        public BusinessLayer()
        {
        }
        private Setting _setting { get; set; }
        public  Setting Setting => _setting ?? (_setting = new Setting());
    }
}
