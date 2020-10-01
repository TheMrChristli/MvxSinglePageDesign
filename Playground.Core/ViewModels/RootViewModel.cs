// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Localization;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using Playground.Core.Models;

namespace Playground.Core.ViewModels
{
    public class RootViewModel : MvxNavigationViewModel
    {

        public RootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IMvxViewModelLoader mvxViewModelLoader) : base(logProvider, navigationService)
        {

            ShowChildCommand = new MvxAsyncCommand(async () =>
            {
                var result = await NavigationService.Navigate<ChildViewModel, SampleModel, SampleModel>(new SampleModel
                {
                    Message = "Hey",
                    Value = 1.23m
                });
                var testIfReturn = result;
            });
        }

        public IMvxAsyncCommand ShowChildCommand { get; }

    }
}
