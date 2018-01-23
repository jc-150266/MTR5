﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraphPage : ContentPage
    {


        public GraphPage()
        {
            InitializeComponent();

            /* var b = new Label
            {
                Text = "Date:" + DateTime.Today.ToString("dd'/'MM'/'yyyy"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            Content = new StackLayout
            {

                Children = {
           new StackLayout
        {
            Padding = new Thickness(25,90,25,0),
            Spacing = 20,
            Children = { b
    }
}
    }
            }; */

        }







/********************ここから追加******************************************/

void Handle_Clicked(object sender, System.EventArgs e)
        {
            var db = TodoItemDatabase.getDatabase();
            //String sName = eName.Text;
            //String sNotes = eNotes.Text;
            //Boolean bDone = eDone.IsToggled;
            int B_Weight = int.Parse(bWeight.Text);
            int B_Fat = int.Parse(bFat.Text);
            DateTime dCreated =  DateTime.Today; 
            
            


            TodoItem item = new TodoItem() { Created = dCreated, Bweight = B_Weight, Bfat = B_Fat };
            db.SaveItemAsync(item);
            DisplayAlert("", "記録されました", "OK");
            Application.Current.MainPage = new MainPage();
        }

        /*private void eCreated_DateSelected(object sender, DateChangedEventArgs e)//追加
        {
            yyyymmdd = new DateTime(eCreated.Date.Year, eCreated.Date.Month, eCreated.Date.Day);


        }*/
        //DateTime yyyymmdd;//追加


    }
}
