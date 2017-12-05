using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Shamrock.Wpf.View.Control
{
    public class ContentNavigator : ContentControl
    {
        private Stack<UIElement> _navigationHistory = new Stack<UIElement>();

        public void NavigateTo(UIElement view)
        {
            if (Content != null)
            {
                _navigationHistory.Push((UIElement)Content);
            }

            Content = view;
        }

        public void NavigateBack()
        {
            Content = _navigationHistory.Pop();
        }
    }
}
