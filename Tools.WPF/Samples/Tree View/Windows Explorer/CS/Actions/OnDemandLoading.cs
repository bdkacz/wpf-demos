﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Controls;
using System.IO;
using System.Diagnostics;
using System.Windows;

namespace WindowsExplorerDemo
{
    class OnDemandLoading:TargetedTriggerAction<TreeViewItemAdv>
    {
        protected override void Invoke(object parameter)
        {
            TreeViewItemAdv item = (parameter as LoadonDemandEventArgs).TreeViewItem;
            ViewModel data = new ViewModel();
            data.OnDemandLoad(item);
        }

#if Framework3_5
        public FrameworkElement TargetObject
        {
            get { return (FrameworkElement)GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register("TargetObject", typeof(FrameworkElement), typeof(OnDemandLoading), new UIPropertyMetadata(null));
#endif
    }  
}
