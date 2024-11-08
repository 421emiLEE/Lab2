using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double speedLimit;
            double currentSpeed;
            double fine;
            const double penaltySpeed = 25;
            const double penaltyFine = 250.00;
            const double fineperLimit = 7.00;

            speedLimit = double.Parse(speedlimitTxtBox.Text);
            currentSpeed = double.Parse(speedTxtBox.Text);



            if(currentSpeed > speedLimit)
            {
                fine  = 60 +(currentSpeed - speedLimit) * fineperLimit;
                if(currentSpeed >= penaltySpeed)
                {
                    SpeedCanvas.Background = Brushes.Red;
                    fine = fine + penaltyFine;
                    resultTxtBox.Text = "Speeding with penalty, your fine will be %" + fine;
                }
            }
            else if(currentSpeed > penaltySpeed)
            {
                fine = penaltyFine;
                SpeedCanvas.Background = Brushes.Yellow;
                resultTxtBox.Text = "speeding with no penalty, your fine will be $" + fine;
            }
            else
            {
                resultTxtBox.Text = "Legal speed";
                SpeedCanvas.Background = Brushes.Green;
            }


        }
    }
}