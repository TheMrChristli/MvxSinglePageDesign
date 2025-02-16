﻿using MvvmCross.Platforms.Uap.Presenters.Attributes;
using MvvmCross.Platforms.Uap.Views;
using Mvx.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace Mvx.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    [MvxSplitViewPresentation(Position = SplitPanePosition.Content)]
    public sealed partial class SplitDetailView : SplitDetailViewPage
    {
        public SplitDetailView()
        {
            this.InitializeComponent();
        }
    }

    public abstract class SplitDetailViewPage : MvxWindowsPage<SplitDetailViewModel>
    {
    }
}
