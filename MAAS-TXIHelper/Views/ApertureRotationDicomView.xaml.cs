﻿using MAAS_TXIHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VMS.TPS.Common.Model.API;

namespace MAAS_TXIHelper.Views
{
    /// <summary>
    /// Interaction logic for ApertureRotationDicomView.xaml
    /// </summary>
    public partial class ApertureRotationDicomView : UserControl
    {
        public ApertureRotationDicomView(ScriptContext context)
        {
            this.DataContext = new ApertureRotationDicomViewModel(context);
            InitializeComponent();
        }
    }
}