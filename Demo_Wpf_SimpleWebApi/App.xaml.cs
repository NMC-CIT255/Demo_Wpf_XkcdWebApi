using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Demo_Wpf_SimpleWebApi.BusinessLayer;

namespace Demo_Wpf_SimpleWebApi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            AppBusiness appBusiness = new AppBusiness();
        }
    }
}
