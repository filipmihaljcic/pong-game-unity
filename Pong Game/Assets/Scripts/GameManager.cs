using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public Ball _ball;
       
        public Text _playerScoreText, _computerScoreText;

        public Paddle _playerPaddle, _computerPaddle;

        private int _playerScore, _computerScore = 0;

        public void PlayerScore()
        {
            _playerScore++;

            _playerScoreText.text = _playerScore.ToString();
            ResetRound();
        }

        public void ComputerScore()
        {
            _computerScore++;

            _computerScoreText.text = _computerScore.ToString();
            ResetRound();
        }

        private void ResetRound()
        {
            _playerPaddle.ResetPos();
            _computerPaddle.ResetPos();
            _ball.ResetPosition();
            _ball.AddStartingForce();
        }
    }
}
