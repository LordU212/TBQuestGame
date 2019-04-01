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
using System.Windows.Shapes;
using TBQuestGame.Models;

namespace TBQuestGame.PresentationLayer
{
    /// <summary>
    /// Interaction logic for PlayerSetupView.xaml
    /// </summary>
    public partial class PlayerSetupView : Window
    {
        private Player _player;

        public PlayerSetupView(Player player)
        {
            _player = player;

            InitializeComponent();

            SetupWindow();
        }

        private void SetupWindow()
        {
            List<string> playerClass = Enum.GetNames(typeof(Player.PlayerClass)).ToList();
            PlayerClassCombo.ItemsSource = playerClass;

            
            ErrorMessage.Visibility = Visibility.Hidden;
        }

        private bool IsValidInput(out string errorMessage)
        {
            errorMessage = "";

            if (NameTextBox.Text == "")
            {
                errorMessage += "Player Name is Required. /n";
            }
            else
            {
                _player.Name = NameTextBox.Text;
            }


            return errorMessage == "" ? true : false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage;

            if (IsValidInput(out errorMessage))
            {

                Enum.TryParse(PlayerClassCombo.SelectionBoxItem.ToString(), out Player.PlayerClass playerClass);

                _player.playerClass = playerClass;

                Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = errorMessage;
            }

        }
    }
}
