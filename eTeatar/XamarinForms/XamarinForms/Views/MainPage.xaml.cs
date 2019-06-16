using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinForms.Models;

namespace XamarinForms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Pocetna, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Pocetna:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Predstave:
                        MenuPages.Add(id, new NavigationPage(new Predstave()));
                        break;
                    case (int)MenuItemType.Obavijesti:
                        MenuPages.Add(id, new NavigationPage());
                        break;
                    case (int)MenuItemType.Termini:
                        MenuPages.Add(id, new NavigationPage());
                        break;
                    case (int)MenuItemType.MojePredstave:
                        MenuPages.Add(id, new NavigationPage());
                        break;
                    case (int)MenuItemType.MojProfil:
                        MenuPages.Add(id, new NavigationPage());
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}