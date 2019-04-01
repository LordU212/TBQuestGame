using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.PresentationLayer;
using TBQuestGame.Models;
using TBQuestGame.DataLayer;

namespace TBQuestGame.BusinessLayer
{
    public class GameBusiness
    {

        bool _newPlayer = true;
        GameSessionViewModel _gameSessionViewModel;
        
        Player _player = new Player();
        PlayerSetupView _playerSetupView = null;
        List<string> _messages;

        public GameBusiness()
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();

        }

        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new PlayerSetupView(_player);
                _playerSetupView.ShowDialog();

                _messages = GameData.InitialMessages();
                _player.Souls = 0;
                _player.Estus = 5;
                _player.PlayerLevel = 1;


            }
            else
            {
                _player = GameData.PlayerData();

            }




        }

        private void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _messages = GameData.InitialMessages();
            switch (_player.playerClass)
            {
                case Player.PlayerClass.Warrior:
                    _player.Health = 120;
                    _player.Dexterity = 11;
                    _player.Strength = 14;
                    _player.Intelligence = 8;
                    _player.Faith = 10;
                    break;
                case Player.PlayerClass.Cleric:
                    _player.Health = 110;
                    _player.Strength = 12;
                    _player.Dexterity = 8;
                    _player.Intelligence = 9;
                    _player.Faith = 14;
                    break;
                case Player.PlayerClass.Mage:
                    _player.Health = 90;
                    _player.Intelligence = 14;
                    _player.Strength = 8;
                    _player.Faith = 9;
                    _player.Dexterity = 12;
                    break;
                case Player.PlayerClass.Assassin:
                    _player.Health = 100;
                    _player.Dexterity = 14;
                    _player.Strength = 10;
                    _player.Intelligence = 10;
                    _player.Faith = 8;
                    break;
                default:
                    break;
            }
        }

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(
                _player,
                GameData.InitialMessages(),
                 GameData.GameMap(),
                 GameData.InitialGameMapLocation()
                );

            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            _playerSetupView.Close();
        }

        
        


    }

}
