using RockPaperScissorsClient.RequestProviders;
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

namespace RockPaperScissorsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RequestProvider requestProvider = RequestProvider.Create();
            Task.Run(() => requestProvider.Run(this));

            string token = Request.Login("admin", "admin");

            // MainWindow window = new MainWindow();
            // window.ShowDialog(); // MainWindow nahradis tim novym window
        }

<<<<<<< HEAD
        
=======
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
>>>>>>> d817b7d45261c2462ccbe74c9c74ab8b6d91fa2d
    }
}
