using System;
using System.Collections.Generic;
using System.Text;
using DataTransferObjects;

namespace XamarinForms.ViewModels
{
    public class MojProfilViewModel
    {
        public Kupac Kupac { get; set; }

        public MojProfilViewModel()
        {
            Kupac = Helpers.KupacData.Get();
        }

    }
}
