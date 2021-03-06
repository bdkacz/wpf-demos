#region Copyright Syncfusion Inc. 2001 - 2018
// <copyright file="ViewModel.cs" company="syncfusion">
//  Copyright (c) Syncfusion Inc. 2001 - 2018. All rights reserved.
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
// </copyright>
#endregion

namespace XAMLConfig.ViewModel
{
    using Syncfusion.Windows.Shared;

    public class ViewModel : NotificationObject
    {
        #region Field

        public static string ConnectionString;
        private string olapConnectionString = !string.IsNullOrEmpty(ConnectionString) ? ConnectionString : "";
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel() { }

        #endregion

        #region Properties

       
        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
        public string OlapConnectionString
        {
            get { return olapConnectionString; }
            set { olapConnectionString = value; RaisePropertyChanged("OlapConnectionString"); }
        }

        #endregion
    }
}