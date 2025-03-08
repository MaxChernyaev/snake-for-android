using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    // private Vector2 _direction = Vector2.up;
    // [SerializeField] private float _snakeSpeed = 0.3f;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     Time.fixedDeltaTime = _snakeSpeed;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.W)) {
    //         _direction = Vector2.up;
    //         Debug.Log("UP");
    //     } else if (Input.GetKeyDown(KeyCode.S)) {
    //         _direction = Vector2.down;
    //         Debug.Log("down");
    //     } else if (Input.GetKeyDown(KeyCode.A)) {
    //         _direction = Vector2.left;
    //         Debug.Log("Left");
    //     } else if (Input.GetKeyDown(KeyCode.D)) {
    //         _direction = Vector2.right;
    //         Debug.Log("RiGhT");
    //     }
    // }

    // private void FixedUpdate()
    // {
    //     transform.position = new Vector3(
    //         Mathf.Round(transform.position.x) + _direction.x,
    //         Mathf.Round(transform.position.y) + _direction.y,
    //         0.0f
    //     );
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall"){
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
