﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Extensions.DependencyInjection;

namespace GW2AddonManager
{
    public partial class UpdatingView : Page, IHyperlinkHandler
    {
        public UpdatingView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<UpdatingViewModel>();
        }

        /***************************** Titlebar Window Drag *****************************/
        private void TitleBar_MouseHeld(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Application.Current.MainWindow.DragMove();
        }

        /***************************** Button Controls *****************************/

        private void minimize_clicked(object sender, RoutedEventArgs e)
        {
            (Parent as Window).WindowState = WindowState.Minimized;
        }

        private void back_clicked(object sender, RoutedEventArgs e)
        {
            _ = this.NavigationService.Navigate(new Uri("UI/OpeningPage/OpeningView.xaml", UriKind.Relative));
        }

    }
}
