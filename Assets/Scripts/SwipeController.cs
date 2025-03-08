using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeController : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField] private Transform _snake;

    private Vector2 _direction = Vector2.up;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
                if (_direction != Vector2.left)
                    _direction = Vector2.right;
            }
            else
            {
                if (_direction != Vector2.right)
                    _direction = Vector2.left;
            }
        }
        else
        {
            if (eventData.delta.y > 0)
            {
                if (_direction != Vector2.down)
                    _direction = Vector2.up;
            }
            else
            {
                if (_direction != Vector2.up)
                    _direction = Vector2.down;
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        // throw new System.NotImplementedException();
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
