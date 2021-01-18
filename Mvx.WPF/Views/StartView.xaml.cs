﻿using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using Mvx.Core.ViewModels;

namespace Mvx.WPF.Views
{
    /// <summary>
    /// Interaktionslogik für StartView.xaml
    /// </summary>
    public partial class StartView : IMvxOverridePresentationAttribute
    {
        public StartView()
        {
            InitializeComponent();
        }

        public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
        {
            return new MvxContentPresentationAttribute
            {
                WindowIdentifier = $"{nameof(StartView)}",
                StackNavigation = false
            };
        }
    }
}
