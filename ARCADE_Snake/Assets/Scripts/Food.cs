using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D Ghost_Area;


    // Start is called before the first frame update
    void Start()
    {
        // Each time the game starts, the food takes a random position.
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        // The food only takes position randomly within the selected area.
        Bounds bounds = this.Ghost_Area.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        // We used "Mathf.Round" so that the food moves in integers and aligns exactly with the snake.
        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Each time the snake eats the food, the food takes a random position.

        if (other.tag == "Snake")
        {
            RandomizePosition();
        }
    }

}
