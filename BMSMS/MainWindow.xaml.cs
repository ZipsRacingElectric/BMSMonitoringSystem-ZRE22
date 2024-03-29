﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace BMSMS
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            //mainFrame.Navigate(typeof(Pages.Monitoring));
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected == true)
            {
                NavView_Navigate("settings", args.RecommendedNavigationTransitionInfo);
            }
            else if (args.SelectedItemContainer != null)
            {
                mainFrame.Navigate(typeof(Pages.Monitoring));
                //var navItemTag = args.SelectedItemContainer.Tag.ToString();
                //NavView_Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
            }
        }

        private void NavView_Navigate(string navItemTag, Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo transitionInfo)
        {
            Type _page = null;
            if (navItemTag == "settings")
            {
                _page = typeof(Pages.Settings);
            }
            else
            {
                
                //var item = _pages.FirstOrDefault(p => p.Tag.Equals(navItemTag));
                //_page = item.Page;
            }
            // Get the page type before navigation so you can prevent duplicate
            // entries in the backstack.

            //var preNavPageType = ContentFrame.CurrentSourcePageType;

            // Only navigate if the selected page isn't currently loaded.
            //if (!(_page is null) && !Type.Equals(preNavPageType, _page))
            {
               // ContentFrame.Navigate(_page, null, transitionInfo);
            }
        }
    }
}
