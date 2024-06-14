using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using TMPro;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    // We need x and y axes for the snake's movement so we used "Vector2" for this.
    // And we set the direction of the snake to right by default.
    private Vector2 direction = Vector2.right;
    private List<Transform> Tail = new List<Transform>();
    public Transform Tail_Prefab;
    public int Initial_Size = 3;

    // It's  must be "public static" to access from other scripts.
    public static int Score;
    //Heyy!!! Don't forget to add "using TMPro;" at the top to use TextMeshPro UI ;)
    public TMP_Text Score_Text;

    // Start is called before the first frame update
    private void Start()
    {   
        Score = 0;
        Score_Text.text = "Score :" + Score.ToString();
        Reset_State(); 
    }

    // Update is called once per frame
    private void Update()
    {
        //So that the snake doesn't move in the opposite direction on the same axis.
        if (this.direction.x != 0f)
        {
            // We used the "Input.GetKeyDown" to give the snake movement in different directions by keyboard.
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Keypad8))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                direction = Vector2.down;
            }
        }
        else if(this.direction.y != 0f)
        {

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.Keypad6))
            {
                direction = Vector2.right;
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Keypad4))
            {
                direction = Vector2.left;
            }
        }

        Score_Text.text = "Score : " + Score.ToString();

        //We saved the highest scores as integer using the "PlayerPrefs" class.
        if (Score > PlayerPrefs.GetInt("High_Score"))
        PlayerPrefs.SetInt("High_Score", Score);
    }

    private void FixedUpdate()
    {
        // Every time the snake eats the food, a new segment is added to its tail.
        for (int i = Tail.Count - 1; i > 0; i--)
        {
            Tail[i].position = Tail[i - 1].position;
        }
        // The reason we use "Vector3" in this code block is that the "Transform" component has all three x, y, z axes.
        // Our snake must move unit by unit and for this we used the "Mathf.Round"
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + direction.x,
            Mathf.Round(this.transform.position.y) + direction.y,
            0.0f
            );

    }

    private void Grow()
    {
        // Each tail segment is placed behind the previous segment.
        Transform Tail_Segment = Instantiate(this.Tail_Prefab);
        Tail_Segment.position = Tail[Tail.Count -1 ].position;
        Tail.Add(Tail_Segment);
    }

    private void Reset_State()
    {
        for(int i = 1; i < Tail.Count; i++)
        {
            Destroy( Tail[i].gameObject );
        }
        Tail.Clear();
        Tail.Add(this.transform);

        for(int i = 1; i < this.Initial_Size; i++)
        {
            Tail.Add(Instantiate(this.Tail_Prefab));
        }

        // Snake moves to the right by default.
        this.transform.position = Vector3.zero;
        direction = Vector2.right;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Grow();
            Score++;
        }
        else if(other.tag == "Obstacle")
        {
            //Heyy!!! Don't forget to add "using UnityEngine.SceneManagement;" at the top to switch between scenes ;)
            SceneManager.LoadScene(1);
            Reset_State();
        }
    }

}
