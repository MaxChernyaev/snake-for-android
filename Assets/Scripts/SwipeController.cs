using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeController : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField] private Transform _snake;

    private Vector2 _direction = Vector2.up;
    [SerializeField] private float _snakeSpeed = 0.3f;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
                _direction = Vector2.right;
            }
            else
            {
                _direction = Vector2.left;
            }
        }
        else
        {
            if (eventData.delta.y > 0)
            {
                _direction = Vector2.up;
            }
            else
            {
                _direction = Vector2.down;
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        // throw new System.NotImplementedException();
    }

    void Start()
    {
        Time.fixedDeltaTime = _snakeSpeed;
    }

    private void FixedUpdate()
    {
        _snake.position = new Vector3(
            Mathf.Round(_snake.position.x) + _direction.x,
            Mathf.Round(_snake.position.y) + _direction.y,
            0.0f
        );
    }
}
