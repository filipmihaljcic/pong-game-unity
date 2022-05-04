using UnityEngine;

namespace Project.Scripts
{
    public class ComputerPaddle : Paddle
    {  
        public Rigidbody2D _ball;

        private void FixedUpdate() 
        {
            if (_ball.velocity.x > 0.0f) // the ball is moving towards the computer paddle 
            {
                // if the ball position is higher than computer paddle position
                if (_ball.transform.position.y > transform.position.y) 
                    // move paddle down
                    _rb2D.AddForce(Vector2.up * _speed);

                else if (_ball.transform.position.y < transform.position.y)
                    _rb2D.AddForce(Vector2.down * _speed);
            }
            else 
            {
                // if computer paddle is above middle position 
                if (transform.position.y > 0.0f)
                    // move down
                    _rb2D.AddForce(Vector2.down * _speed);

                else if (transform.position.y < 0.0f)
                    _rb2D.AddForce(Vector2.up * _speed);
            }
        }
    }   
}
