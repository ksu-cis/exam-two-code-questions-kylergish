using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        /// <summary>
        /// Constructor for CustomizeCobblerControl
        /// </summary>
        public CustomizeCobblerControl()
        {
            InitializeComponent();

            Peach.Checked += Peach_Checked;
            Cherry.Checked += Cherry_Checked;
            Blueberry.Checked += BlueBerry_Checked;
        }

        /// <summary>
        /// Event for Peach
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void Peach_Checked(object sender, RoutedEventArgs arg)
        {
            if(DataContext is Cobbler fruit)
            {
                fruit.Fruit = FruitFilling.Peach;
            }
        }

        /// <summary>
        /// Event for Cherry
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void Cherry_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler fruit)
            {
                fruit.Fruit = FruitFilling.Cherry;
            }
        }

        /// <summary>
        /// Event for Blueberry
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="arg">argument</param>
        private void BlueBerry_Checked(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Cobbler fruit)
            {
                fruit.Fruit = FruitFilling.Blueberry;
            }
        }
    }
}
