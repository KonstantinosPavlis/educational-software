﻿using Educational_Software.Models;
using Microsoft.UI.Xaml;
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


namespace Educational_Software.Navigation_UI_Pages
{
    
    public sealed partial class Quiz_2 : Page
    {
        User user;
        int current_question_number = 1;

        public Quiz_2()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                user = e.Parameter as User;
            }
        }

        private void Next_step(object sender, RoutedEventArgs e)
        {
            if (current_question_number == 1)
            {
                //Check if the answer is correct
                question_1_radio.IsEnabled = false;
                question_2_empty.Visibility = Visibility.Collapsed;
                question_2_radio_1.Visibility = Visibility.Visible;
                question_2_radio_1.IsEnabled = true;
                current_question_number++;
                question_number.Text = current_question_number.ToString();

            }
            else if (current_question_number == 2)
            {
                //Check if the answer is correct
                question_2_radio_1.IsEnabled = false;
                question_3_empty.Visibility = Visibility.Collapsed;
                question_3_radio_1.Visibility = Visibility.Visible;
                question_3_radio_1.IsEnabled = true;
                ((Button)sender).Content = "Ολοκλήρωση";
                current_question_number++;
                question_number.Text = current_question_number.ToString();
            }
            else if (current_question_number == 3)
            {
                //Check if the answer is correct
                question_3_radio_1.IsEnabled = false;
                if (new Random().Next(2) == 0)
                {
                    ((Button)sender).Content = "Επανάληψη";
                    info_message.Severity = InfoBarSeverity.Error;
                    info_message.Title = "Αποτυχία";
                    info_message.Message = "Απαντήσατε σε πολλές ερωτήσεις λάθος. Προσπαθήστε ξανά.";
                    current_question_number = 10;
                }
                else
                {
                    ((Button)sender).Content = "Ολοκλήρωση";
                    info_message.Severity = InfoBarSeverity.Success;
                    info_message.Title = "Επιτυχία";
                    info_message.Message = "Συγχαρητήρια! Περάσατε τη δοκιμασία !";
                    current_question_number = 11;
                }



            }
            else if (current_question_number == 10)
            {
                //Check if the answer is correct
                question_1_radio.SelectedItem = null;
                question_2_radio_1.SelectedItem = null;
                question_3_radio_1.SelectedItem = null;
                question_1_radio.IsEnabled = true;
                question_2_empty.Visibility = Visibility.Visible;
                question_2_radio_1.Visibility = Visibility.Collapsed;
                question_3_empty.Visibility = Visibility.Visible;
                question_3_radio_1.Visibility = Visibility.Collapsed;
                ((Button)sender).Content = "Επόμενη";
                current_question_number = 1;
                question_number.Text = current_question_number.ToString();
                info_message.Severity = InfoBarSeverity.Warning;
                info_message.Title = "Αναμονή Ολοκλήρωσης";
                info_message.Message = "Απάντησε όλες τις ερωτήσεις του Quiz ώστε να ελεγθεί η πρόοδός σου";
            }
            else if (current_question_number == 11)
            {
                //Check if the answer is correct
                //Nothing for now

            }
        }
    }
}
