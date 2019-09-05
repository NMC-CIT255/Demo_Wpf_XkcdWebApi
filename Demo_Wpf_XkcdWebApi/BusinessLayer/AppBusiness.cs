using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_XkcdWebApi.PresentationLayer;

namespace Demo_Wpf_XkcdWebApi.BusinessLayer
{
    public class AppBusiness
    {
        public AppBusiness()
        {
            XkcdComicView xkcdComicView = new XkcdComicView();

            xkcdComicView.Show();
        }
    }
}
