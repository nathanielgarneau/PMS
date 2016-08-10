﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.UI.ContentPages;
using Xamarin.Forms;

namespace PMS.Xam.UI
{
    public class App : Application
    {
        public static bool IsUserLoggedIn { get; private set; }
        public App()
        {
           
            //MainPage
            //     = new NavigationPage(new ContentPages.Maintenance.ColourPage());//Working navigation example. Delete and edit and listview screens are done with mock data.
              MainPage
                 = new NavigationPage(new MainPage());
            //// The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};
        }
       
        protected override void OnStart()
        {
            // Handle when your app starts
          
			base.OnStart();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
          
			base.OnSleep();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        
        	public static NotificationPayload PendingNotificationPayload
		{
			get;
			private set;
		}
    }
}
