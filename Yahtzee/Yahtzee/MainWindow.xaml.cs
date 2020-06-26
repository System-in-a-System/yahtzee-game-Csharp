using System;
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

namespace Yahtzee
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Set initial game parameters
        int rollCounter = 0;

        int firstDie = 0;
        int secondDie = 0;
        int thirdDie = 0;
        int fourthDie = 0;
        int fifthDie = 0;


        // Instantiate a random number generator
        Random roll = new Random();


        // Event handler for the roll button click
        private void RollButton_Click(object sender, RoutedEventArgs e)
        {

            // Enable checkboxes
            cb1.IsEnabled = true;
            cb2.IsEnabled = true;
            cb3.IsEnabled = true;
            cb4.IsEnabled = true;
            cb5.IsEnabled = true;


            // If the player does not hold back the first die...
            if (!(bool)cb1.IsChecked)
            {
                // ... roll the first die
                firstDie = roll.Next(1, 7);

                switch (firstDie)
                {
                    case 1:
                        img1.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));
                        break;
                    case 2:
                        img1.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));
                        break;
                    case 3:
                        img1.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));
                        break;
                    case 4:
                        img1.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));
                        break;
                    case 5:
                        img1.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));
                        break;
                    case 6:
                        img1.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));
                        break;
                }
            }


            // If the player does not hold back the second die...
            if (!(bool)cb2.IsChecked)
            {
                // ... roll the second die
                secondDie = roll.Next(1, 7);

                switch (secondDie)
                {
                    case 1:
                        img2.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));
                        break;
                    case 2:
                        img2.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));
                        break;
                    case 3:
                        img2.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));
                        break;
                    case 4:
                        img2.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));
                        break;
                    case 5:
                        img2.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));
                        break;
                    case 6:
                        img2.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));
                        break;
                }
            }


            // If the player does not hold back the third die...
            if (!(bool)cb3.IsChecked)
            {
                // ... roll the third die
                thirdDie = roll.Next(1, 7);

                switch (thirdDie)
                {
                    case 1:
                        img3.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));
                        break;
                    case 2:
                        img3.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));
                        break;
                    case 3:
                        img3.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));
                        break;
                    case 4:
                        img3.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));
                        break;
                    case 5:
                        img3.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));
                        break;
                    case 6:
                        img3.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));
                        break;
                }
            }


            // If the player does not hold back the fourth die...
            if (!(bool)cb4.IsChecked)
            {
                // ... roll the fourth die
                fourthDie = roll.Next(1, 7);

                switch (fourthDie)
                {
                    case 1:
                        img4.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));
                        break;
                    case 2:
                        img4.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));
                        break;
                    case 3:
                        img4.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));
                        break;
                    case 4:
                        img4.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));
                        break;
                    case 5:
                        img4.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));
                        break;
                    case 6:
                        img4.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));
                        break;
                }
            }


            // If the player does not hold back the fifth die...
            if (!(bool)cb5.IsChecked)
            {
                // ... roll the fifth die
                fifthDie = roll.Next(1, 7);

                switch (fifthDie)
                {
                    case 1:
                        img5.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));
                        break;
                    case 2:
                        img5.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));
                        break;
                    case 3:
                        img5.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));
                        break;
                    case 4:
                        img5.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));
                        break;
                    case 5:
                        img5.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));
                        break;
                    case 6:
                        img5.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));
                        break;
                }
            }


            // Update roll counter
            rollCounter++;



            // Update game status & functioanlity accordingly
            switch (rollCounter)
            {
                case 1:
                    infoLabel.Content = "You have 2 rolls left";
                    break;

                case 2:
                    infoLabel.Content = "You have 1 roll left";
                    break;

                case 3:
                    // Calculate game results
                    int[] output = { firstDie, secondDie, thirdDie, fourthDie, fifthDie };

                    int highestNumberOfMatches = getHighestNumberOfMatches(output);
                    

                    // Display game results						
                    if (highestNumberOfMatches == 5)
                        infoLabel.Content = "It's Yahtzee!";
                 

                    else if (highestNumberOfMatches == 4)
                        infoLabel.Content = "It's four of a kind!";


                    else if (highestNumberOfMatches == 3)
                        infoLabel.Content = "It's three of a kind!";


                    else if (secondDie - firstDie == 1 && thirdDie - secondDie == 1 &&
                            fourthDie - thirdDie == 1 && fifthDie - fourthDie == 1)
                        infoLabel.Content = "It's a large Straight!";


                    else if ((secondDie - firstDie == 1 && thirdDie - secondDie == 1 && fourthDie - thirdDie == 1) ||
                            (thirdDie - secondDie == 1 && fourthDie - thirdDie == 1 && fifthDie - fourthDie == 1))
                       infoLabel.Content = "It's a small Straight!";


                    else if (highestNumberOfMatches == 2)
                        infoLabel.Content = "It's a pair!";


                    else
                        infoLabel.Content = "You will get lucky next time";

                    break;
            }
        }



        // Method to retrieve the highest frequency of element occurence in an int[] array   
        public static int getHighestNumberOfMatches(int[] numbers)
        {

            int highestNumberOfMatches = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                int matches = 0;
                int currentComparand = numbers[i];

                foreach (int number in numbers)
                {
                    if (number == currentComparand)
                        matches++;
                }

                if (matches > highestNumberOfMatches)
                    highestNumberOfMatches = matches;

            }

            return highestNumberOfMatches;
        }
    }
}
