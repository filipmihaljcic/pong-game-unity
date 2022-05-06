using UnityEngine;

namespace Project.Scripts
{
    public class BouncySurface : MonoBehaviour
    {
        public float _bounceStrength;

        private void OnCollisionEnter2D(Collision2D _other) 
        {
            Ball _ball = _other.gameObject.GetComponent<Ball>();

            if (_ball != null)
            { 
                // first contact point of ball 
                Vector2 _normal = _other.GetContact(0).normal;
                // adding force in the opposite direction
                _ball.AddForce(-_normal * _bounceStrength);
            }
        }
    }
}
