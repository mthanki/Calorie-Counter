using System.Windows;
using System.Windows.Controls;

namespace Calorie_Counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int APPLE_CALORIES = 80;
        const int BANANA_CALORIES = 115;
        const int ORANGE_CALORIES = 90;
        const int PEAR_CALORIES = 120;

        int TotalCalories = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetTotalCaloriesInView()
        {
            TotalCaloriesLabel.Content = TotalCalories;
        }

        private void FruitImageButton_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            var prop = Button.Tag;
            `
            switch (prop)
            {
                case "Apple":
                    TotalCalories += APPLE_CALORIES;
                    SetTotalCaloriesInView();
                    break;
                case "Banana":
                    TotalCalories += BANANA_CALORIES;
                    SetTotalCaloriesInView();
                    break;
                case "Orange":
                    TotalCalories += ORANGE_CALORIES;
                    SetTotalCaloriesInView();
                    break;
                case "Pear":
                    TotalCalories += PEAR_CALORIES;
                    SetTotalCaloriesInView();
                    break;
                default:
                    break;
            }
        }

        private void ResetCaloriesTotal_Click(object sender, RoutedEventArgs e)
        {
            TotalCalories = 0;
            SetTotalCaloriesInView();
        }
    }
}
