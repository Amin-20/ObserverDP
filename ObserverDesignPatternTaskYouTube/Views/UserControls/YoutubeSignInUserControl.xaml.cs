﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObserverDesignPatternTaskYouTube.Views.UserControls
{
    /// <summary>
    /// Interaction logic for YoutubeSignInUserControl.xaml
    /// </summary>
    public partial class YoutubeSignInUserControl : UserControl
    {
        public YoutubeSignInUserControl()
        {
            InitializeComponent();
            YoutuberSignInWindow youtuberSignIn = new YoutuberSignInWindow();
            this.DataContext = youtuberSignIn;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
