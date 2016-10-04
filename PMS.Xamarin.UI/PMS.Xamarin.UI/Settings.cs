using System.Collections.Generic;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
//using Newtonsoft.Json;

namespace PMS.Xam.UI
{
    public class Settings
    {
        private static Settings _instance;
        // static BLL.Setting BllSetting = new PMS.Xam.BLL.Setting();
        private List<SettingViewModel> Values { get; set; }

        public static Settings Instance
        {
            get { return _instance ?? (_instance = Load()); }
        }

        public string UserId { get; set; }

        public bool RegistrationComplete { get; set; }

        public string DeviceToken { get; set; }

        public Task Save()
        {
            return Task.Factory.StartNew(() =>
            {
                //	if(App.CurrentUser != null)
                //		DeviceToken = App.CurrentUser.DeviceToken;
                //var json = JsonConvert.SerializeObject(this);
                //using(var sw = new StreamWriter(_filePath, false))
                //{
                //	sw.Write(json);
                //}
            });
        }


        public static Settings Load()
        {
            var settings = new Settings();
            //List<SettingViewModel> values = BllSetting.GetAll().ToList();
            //settings.Values = values;
            return settings;
        }
    }
}