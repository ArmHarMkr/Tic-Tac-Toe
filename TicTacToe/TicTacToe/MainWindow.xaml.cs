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

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        //variables declaring
        bool isPlayerX = true;
        static int buttonCLickedSum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }



        //button methods
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button1);
            buttonCLickedSum++;
            win(button1.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button2);
            buttonCLickedSum++;
            win(button2.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button3);
            buttonCLickedSum++;
            win(button3.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");

        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button4);
            buttonCLickedSum++;
            win(button4.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");

        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button5);
            buttonCLickedSum++;
            win(button5.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");

        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button6);
            buttonCLickedSum++;
            win(button6.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");

        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button7);
            buttonCLickedSum++;
            win(button7.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");
            

        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button8);
            buttonCLickedSum++;
            win(button8.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");

        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            which_player_turn(button9);
            buttonCLickedSum++;
            win(button9.Content.ToString());
            if (buttonCLickedSum >= 9)
                MessageBox.Show("Game over");

        }

        //restart button click method
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();

        }

        //Player's turn method
        private void which_player_turn(Button button)
        {
            switch (isPlayerX)
            {
                case true:
                    button.Foreground = Brushes.Lime;
                    button.Content = "X";
                    isPlayerX = false;
                    playerTurn.Text = "Player O turn";
                    button.IsEnabled = false;
                    break;
                default:
                    button.Foreground = Brushes.Red;
                    button.Content = "O";
                    isPlayerX = true;
                    playerTurn.Text = "Player X turn";
                    button.IsEnabled = false;
                    break;
            }
        }

        //winner checking method
        private void win(string btnContent)
        {
            if ((button1.Content == btnContent & button2.Content == btnContent &
                 button3.Content == btnContent)
               | (button1.Content == btnContent & button4.Content == btnContent &
                 button7.Content == btnContent)
               | (button1.Content == btnContent & button5.Content == btnContent &
                 button9.Content == btnContent)
               | (button2.Content == btnContent & button5.Content == btnContent &
                 button8.Content == btnContent)
               | (button3.Content == btnContent & button6.Content == btnContent &
                 button9.Content == btnContent)
               | (button4.Content == btnContent & button5.Content == btnContent &
                 button6.Content == btnContent)
               | (button7.Content == btnContent & button8.Content == btnContent &
                 button9.Content == btnContent)
               | (button3.Content == btnContent & button5.Content == btnContent &
                 button7.Content == btnContent))
            {

                if (btnContent == "O")
                {



                    MessageBox.Show("PLAYER O WINS");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;


                }


                else if (btnContent == "X")
                {
                    MessageBox.Show("PLAYER X WINS");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
        }
    }
}
