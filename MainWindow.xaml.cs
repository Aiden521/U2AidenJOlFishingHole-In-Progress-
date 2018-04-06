/*
 * Aiden Jolley Ruhn
 * March 31, 2018
 * U2AidenJOlFishingHolees
 * User inputs an amount of fish and the program outputs the amount of points and the allowed amount
 */


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

namespace U2AidenJOlFishingHole
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

            // all int values
            string input = inp.Text;
            int troutFish = 0;
            int troutNumber = 0;
            int pikeFish = 0;
            int pikeNumber = 0;
            int pickerelFish = 0;
            int pickerelNumber = 0;
            int totalPoints = 0;
            int totalFish = 0;
            //  string points = inp.Text.Substring(0, inp.Text.IndexOf("\r"));

            // getting all the values
            int.TryParse(input.Substring(0, input.IndexOf('\r')), out troutFish);
            input = input.Substring(input.IndexOf('\r') + 2);
            MessageBox.Show(troutFish.ToString());
            int.TryParse(input.Substring(0, input.IndexOf('\r')), out pikeFish);
            input = input.Substring(input.IndexOf('\r') + 2);
            MessageBox.Show(pikeFish.ToString());
            MessageBox.Show("Input: " + input);
            int.TryParse(input.Substring(0, input.IndexOf('\r')), out pickerelFish);
            MessageBox.Show("Pickeral: " + pickerelFish);
            input = input.Substring(input.IndexOf('\r') + 2);
            MessageBox.Show(pickerelFish.ToString());

            totalFish = troutFish + pikeFish + pickerelFish;
            MessageBox.Show(totalFish.ToString());


        }
    }
}
