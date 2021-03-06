﻿using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelLabelsDemo_2015
{
    public class ViewModel
    {
        public ObservableCollection<Model> Collection { get; set; }

        public Array BorderStyle
        {
            get
            {
                return Enum.GetValues(typeof(BorderType));
            }
        }

        public Array LabelAlignment
        {
            get
            {
                return Enum.GetValues(typeof(LabelAlignment));
            }
        }

        public Array ColorArray
        {
            get
            {
                return new String[] {"Gray","Black","Red","Brown" };
            }
        }


        public ViewModel()
        {
            Collection = new ObservableCollection<Model>();

            Collection.Add(new Model() { Month = "Jan", Temperature = 33 });
            Collection.Add(new Model() { Month = "Feb", Temperature = 37 });
            Collection.Add(new Model() { Month = "Mar", Temperature = 39 });
            Collection.Add(new Model() { Month = "Apr", Temperature = 43 });
            Collection.Add(new Model() { Month = "May", Temperature = 45 });
            Collection.Add(new Model() { Month = "Jun", Temperature = 43 });
            Collection.Add(new Model() { Month = "Jul", Temperature = 41 });
            Collection.Add(new Model() { Month = "Aug", Temperature = 40 });
            Collection.Add(new Model() { Month = "Sep", Temperature = 39 });
            Collection.Add(new Model() { Month = "Oct", Temperature = 39 });
            Collection.Add(new Model() { Month = "Nov", Temperature = 34 });
            Collection.Add(new Model() { Month = "Dec", Temperature = 33 });

        }
    }
}
