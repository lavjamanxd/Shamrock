using System;
using System.Collections.Generic;
using System.Windows;
using Shamrock.Core.Services;
using Shamrock.Core.ViewModel;
using Shamrock.Wpf.View.Control;

namespace Shamrock.Wpf.PlatformServices
{
    public class NavigationService : NavigationServiceBase
    {
        private Dictionary<Type, Type> _viewModelViewPair = new Dictionary<Type, Type>()
        {
            {typeof(BoardListViewModel), typeof(BoardListView) },
            {typeof(ThreadViewModel), typeof(ThreadView) }
        };
        private readonly ContentNavigator _navigator;

        public NavigationService(ContentNavigator navigator)
        {
            _navigator = navigator;
        }

        protected override void NavigateTo(CommonViewModel viewModel)
        {
            var view = (FrameworkElement)Activator.CreateInstance(_viewModelViewPair[viewModel.GetType()]);
            view.DataContext = viewModel;
            
            _navigator.NavigateTo(view);
        }

        public override void NavigateBack()
        {
            _navigator.NavigateBack();
        }
    }
}
