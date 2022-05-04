using UnityEngine;
using UnityEngine.EventSystems;

namespace Project.Scripts
{
    public class ScoringZone : MonoBehaviour
    {
        public EventTrigger.TriggerEvent _scoreTrigger;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Ball _ball = collision.gameObject.GetComponent<Ball>();

            if (_ball != null)
            {
                BaseEventData _eventData = new BaseEventData(EventSystem.current);
                _scoreTrigger.Invoke(_eventData);
            }
        }
    }
}
