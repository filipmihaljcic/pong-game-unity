using UnityEngine;

namespace Project.Scripts
{
    public class Ball : MonoBehaviour
    {
        public float _ballSpeed = 200f;

        private Rigidbody2D _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            ResetPosition();
            AddStartingForce();
        }

        
        public void ResetPosition()
        {
            _rigidbody.position = Vector3.zero;
            _rigidbody.velocity = Vector3.zero;
        }

        public void AddStartingForce()
        {
            // which side the ball goes after game starts
            // (if it's less than than 0.5f it goes to player side)
            // (else it goes to computer side)
            float _x = Random.value < 0.5f ? -1.0f : 1.0f; 
            // this y value is about angle which ball bounces after contact
            float _y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

            Vector2 _ballDirection = new Vector2(_x, _y);
            _rigidbody.AddForce(_ballDirection * _ballSpeed);
        }

        public void AddForce(Vector2 _force)
        {
            _rigidbody.AddForce(_force); 
        }
    }
}
