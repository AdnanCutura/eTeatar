using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataTransferObjects;

namespace XamarinForms.ViewModels
{
    public class KartaViewModel : BaseViewModel
    {
        private readonly APIService _serviceNarudzba = new APIService("Narudzba");
        public Narudzba Narudzba { get; set; }

        public KartaViewModel()
        {
            
        }

        public ICommand InitCommand;

        private async Task Init()
        {
            try
            {
                var item = await _serviceNarudzba.GetById<Narudzba>(Narudzba.Id);
                //NarudzbaList.Clear();
                //foreach (var item in list)
                //    NarudzbaList.Add(item);
            }
            catch
            {
                // ignored
            }
        }

    }
}
