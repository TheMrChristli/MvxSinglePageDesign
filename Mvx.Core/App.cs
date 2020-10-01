using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Mvx.Core.ViewModels;

namespace Mvx.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<StartViewModel>();
        }
    }
}
