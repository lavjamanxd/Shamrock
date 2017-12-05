using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shamrock.Core.Services.Interfaces;
using Shamrock.Core.Util;
using Shamrock.Core.ViewModel;
using Shamrock.Core._4Chan.Model;

namespace Shamrock.Core.Services
{
    public abstract class NavigationServiceBase : INavigationService
    {
        private Dictionary<Type, Type> _definedNavigations = new Dictionary<Type, Type>()
        {
            {typeof(Board), typeof(ThreadViewModel)},
            {typeof(BoardInfo), typeof(BoardListViewModel)}
        };

        public async Task InitialNavigation()
        {
            var a = Resolver.Construct<BoardListViewModel>();
            await a.Load();
            NavigateTo(a);
        }

        protected abstract void NavigateTo(CommonViewModel viewModel);

        public abstract void NavigateBack();

        public void Navigate(object modelToNavigate)
        {
            var typeOfModel = modelToNavigate.GetType();

            if (_definedNavigations.ContainsKey(typeOfModel))
            {
                var matchingViewModel = (CommonViewModel)Resolver.Construct(_definedNavigations[typeOfModel]);
                NavigateTo(matchingViewModel);
                matchingViewModel.Load(modelToNavigate);
            }
            else
                throw new InvalidOperationException($"There's no navigation defined for {modelToNavigate.GetType()}");
        }
    }
}