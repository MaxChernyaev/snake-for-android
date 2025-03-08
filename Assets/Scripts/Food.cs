using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] BoxCollider2D gridArea;
    [SerializeField] ScoreManager scoreManager;

    private void Start()
    {
        scoreManager.ResetScore();
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = gridArea.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            scoreManager.IncreaseScore();
            RandomizePosition();
        }
    }
}
