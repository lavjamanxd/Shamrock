using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using Shamrock.Core._4Chan.Model;
using Shamrock.Core.Util;
using Shamrock.Core.ViewModel;

namespace Shamrock.Core.Services.Interfaces
{
    public abstract class NavigationServiceBase : INavigationService
    {
        private Dictionary<Type, Type> _definedNavigations = new Dictionary<Type, Type>()
        {
            {typeof(Board), typeof(BoardViewModel)},
            {typeof(BoardInfo), typeof(BoardListViewModel)}
        };

        public void InitialNavigation()
        {
            NavigateTo(Resolver.Construct<BoardListViewModel>());
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