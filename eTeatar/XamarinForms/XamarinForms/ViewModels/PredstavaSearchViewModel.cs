using DataTransferObjects.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.ViewModels
{
    public class PredstavaSearchViewModel:BaseViewModel
    {

        public PredstavaSearchRequest _search;
        public string Naziv { get => _search.Naziv; set => _search.Naziv = value; }
        public DateTime 

        public PredstavaSearchViewModel(PredstavaSearchRequest search)
        {
            _search = search;
            if (search == null)
                _search = new PredstavaSearchRequest();
        }

    }
}
