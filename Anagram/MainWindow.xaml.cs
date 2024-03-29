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

namespace Anagram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindAnagram_Click(object sender, RoutedEventArgs e)
        {
            bool isAnagram = false;

            isAnagram = Util.Anagram.AnagramStrStr(StringToBeAnagrammed.Text, StringToBeCompared.Text);

            Result.Text = isAnagram ? "Anagram of " + StringToBeAnagrammed.Text + " exists in " + StringToBeCompared.Text
                : "Anagram of " + StringToBeAnagrammed.Text + " does not exist in " + StringToBeCompared.Text;
        }
    }
}
