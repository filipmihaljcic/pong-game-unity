using UnityEngine;

namespace Project.Scripts
{
    public class Paddle : MonoBehaviour
    {
        protected Rigidbody2D _rb2D;
        
        public float _speed = 10f;

        private void Awake()
        {
            _rb2D = GetComponent<Rigidbody2D>();
        }
        
        public void ResetPos()
        {
            _rb2D.velocity = Vector2.zero;
            _rb2D.position = new Vector2(_rb2D.position.x, 0f);
        }
    }
}
