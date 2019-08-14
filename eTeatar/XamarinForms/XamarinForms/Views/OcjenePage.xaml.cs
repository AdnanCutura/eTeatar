﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OcjenePage : ContentPage
    {
        OcjeneViewModel model;
        public OcjenePage()
        {
            InitializeComponent();
            BindingContext = model = new OcjeneViewModel();
        }

        protected override void OnAppearing()
        {
            model.Init.Execute(null);
            base.OnAppearing();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }
    }
}