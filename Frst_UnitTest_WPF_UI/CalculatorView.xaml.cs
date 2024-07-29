﻿using System;
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
using System.Windows.Shapes;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace First_UnitTest.CalculatorUi;

/// <summary>
/// Interaction logic for CalculatorView.xaml
/// </summary>
public partial class CalculatorView : FluentWindow
{
    public CalculatorView()
    {
        InitializeComponent();
        this.DataContext = new CalculatorViewModel();
        ApplicationThemeManager.Apply(this);
    }
}
