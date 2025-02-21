# STEP BY STEP 2D SNAKE GAME 🐍🍎
Hey guys! Here is a classic snake game made with Unity 2022.3.16f1. You know the best way to understand game mechanics is to clone games from our childhood. This is my first clone game. I hope you have as much fun making this game as I did ;) By the way I mostly used [Zigurous](https://www.youtube.com/@Zigurous)'s [How to make Snake in Unity (Complete Tutorial) 🐍🍎](https://www.youtube.com/watch?v=U8gUnpeaMbQ) video to make this game so I thank [Adam Graham](https://github.com/adamgraham) very much :)

# [Arcade Snake Unity Folder](https://drive.google.com/drive/folders/1TEVQNnhHCNjQf5oi7rxk3BrWwfl--m3Q)

## Game Preview

![snakeGameGif](https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/Snake_Game.gif)

## Scene Setup🎥⚙️

### Camera Settings

Our first setting is about the camera's field of view, the size of the snake should not be too big so that we can move easily in our game area. We can do this by reducing the size of the snake, but here we will do it by increasing the camera's field of view because why not😀 ?
</br><b><i>So, let's get started and hunt for some food!!!</i>🍎</b>

<table>
  <tr>
    <td style="vertical-align: top; width: 30%;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_1.png" alt="step1" style="max-width: 100%; height: auto;">
    </td>
    <td style="padding-left: 20px;">
      <p style="margin-top: 0;">First, let's adjust the main camera settings to increase its field of view so that objects in our game area appear smaller.</p>
      <p>🕹️ Start by selecting the main camera from the <b><i>"Hierarchy"</i></b> window.</p>
      <p>🕹️ And find the size setting of the camera in the <b><i>"Inspector"</i></b> window.</p>
      <p>🕹️ The size of the camera is 5 by default. You can change it to 15 or any other value you want. 15 will be enough for this game.</p>
      <p>🕹️ You can also change the background color of the camera to your preference.</p>
      <p><i>Let's go to the next step.</i></p>
    </td>
  </tr>
</table>

### Snake Creation 🟩
Now it's time to create the snake. In this game we will create the snake from a simple square, you can also use designs you have found or designed on any platform.
<table style="margin-left: auto; margin-right: auto;">
  
  <tr>
    <td style="text-align: center;">
      <p>🕹️ At first, we add a <b><i>"2D Object > Sprites > Square"</i></b> to the scene in <i>"Hierarchy"</i> window.</p>
    </td>
  </tr>
  
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_2.png" alt="step2" style="max-width: 100%; height: auto;">
    </td>
  </tr>
  
  <tr>
    <td style="text-align: center;">
      <p>🕹️ After adding the sprite, it should appear like this 👇🏽.</p>
    </td>
  </tr>
  
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_2_2.png" alt="step2_2" style="max-width: 100%; height: auto;">
    </td>
  </tr>
  </table>

<p><b><i>Let's give a few features to this little square trying to be a snake.</i>🟩</b></p>

  <table>
    <tr>
        <td style="text-align: left;">
          <p style="margin-top: 0;">🕹️ Add a <b><i>"Rigidbody"</i></b> component so that the snake can behave according to the laws<br> of physics.</p>
          <p style="margin-top: 0;">🕹️ Make sure the <b></i>"Body Type"</i></b> is<b> <i>"Kinematic"</i> </b>in the<i> "Rigidbody"</i> component.</p>
        </td>
      </tr>
      <tr>
        <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_3.png" alt="step3" style="width: 450px; height: auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_3_2.png" alt="step3_2" style="width: 450px; height: auto; display: block; margin: 0 auto;">
        </td>
      </tr>
      
</table>

<p>Kinematic Rigidbodies are objects that are usually moved programmatically, and their position, velocity and rotation are usually determined by code, so they are not subject to physical effects such as gravity.That's why we chose kinematic instead of dynamic body type.</p>
<p>By the way, I recommend you to give our little dreamer square a clear name like <b><i>"Snake"</i></b> or <b><i>"Player"</i></b>.This will make your progress more organized and easier ;)</p>

 <table style="margin: 0 auto;">
  <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ We need a collider to detect the collision of the snake with other objects. Since we are using a square, it would be best to use a <b><i>"Box Collider 2D"</i></b>.</p>
      <p style="margin-top: 0;">🕹️ After adding the collider, check the<b> <i>"Is Trigger"</i></b> option.</p>
       <p> We're doing this because when <i>"Is Trigger"</i> is checked, the collider object does not generate physical collision responses (for example, objects do not bounce off each other). Instead, it detects whether one object passes through another.</p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_3_3.png" alt="step3_3" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_3_4.png" alt="step3_4" style="max-width: 100%; height: auto; display: inline-block; margin: 0 auto;">
    </td>
  </tr>
    <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ The box collider is automatically set to match the size of the object and here it will be added in the size of the square we add.</p>
        <p>However, since the sprite that we will add as food in the next step will be a square with the same size as this square, it will be detected by the collider even when it is just touching the snake.</p>
        <p>But we want there to be an action when the snake passes over the food. So the size of the collider must be smaller than the snake object. You can give the collider any value less than 1. I said less than 1 because we did not make any changes to the size of
          the snake and by default we used a square with a value of 1 by 1. Here I gave the size of the collider a value of 0.75 by 0.75.</p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_3_5.png" alt="step3_5" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
  </tr>

<tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ Now we add a square sprite for food and assign a <b><i>"Box Collider"</i></b> to it.</br>
      There is no need to assign a <i>"Rigidbody"</i> to our food because it does not move and does not require physical interaction. So, we just need to add a <i>"Box Collider"</i>, and there is no need to change the size of this collider.</p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      </br><p style="margin-top: 0;">🕹️ The last thing left to do on our scene is to add the walls that will border the snake.For this, we add 4 square sprites and size and position them like a room. I recommend using integers when sizing your wall. This will make it easier for you in the next steps. You can use the values given below.</p>
    </td>
  </tr>
  <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/wall1.png" alt="wall_1" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/wall2.png" alt="wall_2" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/wall3.png" alt="wall_3" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/wall4.png" alt="wall_4" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
  </tr>
  </table>
<p>When all setup is done, our scene will look like below.</p>
  <table>
 <tr>
    <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_5.png" alt="step3_6" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
  </tr>
  </table>
  
  ## Snake Movement 🐍🤸🏻‍♀️

  <p>Now that our game area is ready, we can start to move the snake. Of course, we will give the snake movement using code. <b><i>So let's move on.</i></b></br></p>
  
  <table>
 <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ As you know, we will add mechanics to objects using <b><i>"C#"</i></b>. For this, first we need to create a <b><i>"C# Script"</i></b> file in the <b><i>"Assets"</i></b> folder.</p>
    </td>
    </tr>
      <tr>
      <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_6.png" alt="step3_6" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
     </tr>
    <tr>
    <td style="text-align: center;">
      <p style="margin-top: 0;">🕹️ In order for the script to affect the snake object, it must be added as a component to the snake object.</p>
    </td>
    </tr>
      <tr>
      <td style="text-align: center;">
      <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_6_2.png"  style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
    </td>
     </tr>
 </table>

<p>Now it's time to open the script. When you first open the script you will see code blocks like this by default. We will add new libraries (using System.....) depending on the commands we write in the code. 
  For now, the libraries given below will be more than enough.</p>

 ```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
// Start is called before the first frame update
    private void Start()
    {

    }

 
// Update is called once per frame
    private void Update()
    {

    }
}
 ```
<p>🕹️ And now let's add the code that allows the snake to automatically move in any direction we choose at the start of the game and also to move in the directions assigned by the keys selected from the keyboard.</p>
<p><b><i>Details of the codes are given in the comment lines.</i></b></p>

```csharp
// Snake Script
 
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Snake : MonoBehaviour
{

/* We need x and y axes for the snake's movement so we used "Vector2" for this.
And we set the direction of the snake to right by default.*/

private Vector2 direction = Vector2.right;

// Update is called once per frame
    private void Update()
    {
        /*So that the snake doesn't move in the opposite direction on the same axis.
        When the snake starts to grow, a sudden turn in the opposite direction to the one
        it was going will create problems because it will hit itself and the game will be over.
        */
        if (this.direction.x != 0f)
        {
            // We used the "Input.GetKeyDown" to give the snake movement in different directions by keyboard.

            if (Input.GetKeyDown(KeyCode.W))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                direction = Vector2.down;
            }
        }
        else if(this.direction.y != 0f)
        {

            if (Input.GetKeyDown(KeyCode.D))
            {
                direction = Vector2.right;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                direction = Vector2.left;
            }
        }
}


   /*FixedUpdate is a function in Unity where physical updates are processed at regular and consistent time intervals,
   ensuring consistent operation of the game across different systems."*/

   private void FixedUpdate()
    {
        // The reason we use "Vector3" in this code block is that the "Transform" component has all three x, y, z axes.
        // Our snake must move unit by unit and for this we used the "Mathf.Round"
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + direction.x,
            Mathf.Round(this.transform.position.y) + direction.y,
            0.0f
            );
    }
}

```


<p>🕹️ Now the snake automatically goes to the right when the game starts and moves in the directions we assign with the keys we want. But the speed may not be as much as we want. You can change the snake's speed as you want from the editor. For this, it will be enough to follow the steps below.
</p>
    <table style="width: 100%;">
      <tr>
        <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/speed1.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/speed2.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
        </td>
      </tr>
  </table>

  ### Eating Food 🍎
  
  <p><b>Time to fill our bellies😋🍽️.</b></p>
  
  The snake must grow by one unit each time it eats food. For this, the snake must recognize the food.
  
  <table>
     <tr>
        <td>
         <p>🕹️ Before we start, we need to assign tags to the objects (snake, food, walls, etc.) in our game. We will add tags in our editor. 
           After clicking on the object, you can follow the steps below. Make sure your tags are clear like the ones below.</p>
        </td>
      </tr>
      <tr>
        <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingTag1.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingTag2.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
        </td>
      </tr>
  </table>

<table>
  <tr>
    <td>
      <p>
        First, let's test if the colliders can detect each other.
      </p>
      <p>
        🕹️ We will use <b><i>"Debug.Log("The warning you want it to give during the test.");"</i></b> for testing. This code will not create any changes in our game; 
        it will only appear in the <b><i>"Console"</i></b> window when objects collide.This way we can understand if there are problems in our code. 
      </p>
    </td>
  </tr>
</table>

```csharp
// Snake Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    // This function is triggered when the snake collides with another 2D collider.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Debug.Log("Snake collided with Food!");
        }
        else if(other.tag == "Obstacle")
        {
           Debug.Log("Snake collided with Obstacle!");
        }
    }

}
```


  <table style="width: 100%;">
     <tr>
        <td style="vertical-align: top; text-align: center;">
         <p><b><i>Since the colliders can detect each other, we can continue.</i></b></p>
    <p>When the snake eats the food, the food should disappear and re-locate randomly. Before we start coding this, there is something we need to do in the editor:
      define the boundaries of the area where the food can be positioned.
  <p>🕹️ We will do this with an empty object that just has a collider. With this object, we will create a ghost area.</p>

  </p>
        </td>
      </tr>
      <tr>
        <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_9.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_9_2.png" style="max-width: 100%; height: auto; display: block; margin: 0 auto;">
        </td>
      </tr>
    <tr>
      <td>
        <p>
          🕹️ The size of our ghost area should be smaller than our play area as you can see below.
        </p>
      </td>
    </tr>
    <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_9_3.png"  style="width: 950px; height:auto; display: block; margin: 0 auto;">
        </td>
      </tr>
    <tr>
      <tr>
      <td>
        <p>
          The reason for this is that the position of the square we add as food is based on its center.If we give equal sizes to our game area,
          the food will go outside the game area and this is something we don't want to happen.
        </p>
      </td>
    </tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_9_4.png" style="width: 950px; height:auto; display: block; margin: 0 auto;">
        </td>
      </tr>
        
  </table>
  
  <p>
    🕹️ Now we can add the code needed for the food to be randomly positioned at the start of the game and when it is eaten. Of course, for this, we need to add a script to the food component.
  </p>

  

```csharp
//Food Script

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
```

<p>
  🕹️ If you check the script you added to the food object, you will see that a section has been added for the ghost area. In this section, we need to add the object we created for the ghost area. The ghost area is now active.
</p>
        
  <table>      
    <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_10.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_10_2.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
        </td>
      </tr>
  </table>
  
 ### Snake's Growth 🐛➜🐍
<p>
   It's time to add a tail to the snake and make it grow longer every time it eats food.
</p>
<table>
   <tr>
      <td>
        <p>🕹️ We can use a copy of the snake object for the tail, but we don't need a rigidbody component and the "Snake" script. So we will delete these components and use the new object as it is. 
          Below I have created a sample tail with copies of the new object to see how the snake will look when it grows, if you want you can reduce the size of the object a bit like I did and make the snake look better.
        </p>
      </td>
    </tr>
    <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_11.png" style="width: 950px; height:auto; display: block; margin: 0 auto;">
        </td>
      </tr>
   <tr>
      <td>
        <p>🕹️ After creating a <b><i>prefab</i></b> of the new object and tagging it the same as the snake object, we can begin coding for the tail. We can drag the tail object to <b><i>"Assets"</i></b> file and turn it into a prefab. 
          (Prefab allows changes we make to an object that we use more than once to apply to all copies).
        </p>
      </td>
    </tr>
    <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_11_2.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/step_11_3.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
        </td>
      </tr>
  </table>

<p>
  <b><i>Let's start coding for the tail!!!</i></b>
</p>

```csharp
// Snake Script

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using TMPro;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    // List to store the snake's tail segments
    private List<Transform> Tail = new List<Transform>();

    // Prefab for the tail segments
    public Transform Tail_Prefab;

    // Initial size of the snake
    public int Initial_Size = 3;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialize the snake's state at the beginning of the game
        Reset_State(); 
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Every time the snake eats the food, a new segment is added to its tail.
        for (int i = Tail.Count - 1; i > 0; i--)
        {
            // Each tail segment takes the position of the previous segment
            Tail[i].position = Tail[i - 1].position;
        }

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
        // Destroy existing tail segments
        for(int i = 1; i < Tail.Count; i++)
        {   
            Destroy( Tail[i].gameObject );
        }
        // Clear the tail list and add the snake's head as the first segment
        Tail.Clear();
        Tail.Add(this.transform);

        // Add initial tail segments
        for(int i = 1; i < this.Initial_Size; i++)
        {
            Tail.Add(Instantiate(this.Tail_Prefab));
        }

        // Snake moves to the right by default.
        this.transform.position = Vector3.zero;
        direction = Vector2.right;
        
    }

    // This function is triggered when the snake collides with another 2D collider.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            // Grow the snake when it collides with food
            Grow();
        }
        else if(other.tag == "Obstacle")
        {    
            // When the snake collides with an obstacle, reset the scene and the snake's state
            Reset_State();
        }
    }

}
```
## Adding Score 🔢

<p>
  <b><i>Our snake is finally getting fed.Now it's time to count how much it's eaten, I mean, let's add score.</i>🏆</b>
</p>


<table>
  <tr>
    <td>
      <p>
        🕹️ The first step to adding a score is to add a text that will appear on the screen as a score. For this, we will add <b><i>UI > TextMeshPro</i></b> from the <i>"Hierarchy"</i> window and specify its goal by giving it a clear name.
      </p>
    </td>
  </tr>
    <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingUI_txt.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingUI2.png" style="width: 400px; height:auto; display: block; margin: 0 auto;">
    </td>
  </tr>
  </table>

  <table>

<p>
🕹️ We change the <b><i>"UI Scale Mode"</i></b> of our canvas to <b><i>"Scale With Screen Size"</i></b> so that our text is positioned correctly on all devices, and apply this setting to all the texts we will add.
</p>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/canvasSetting1.png" style="width: 600px; height:auto; display: block; margin: 0 auto;">
      </td>
     <td>
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/canvasSetting2.png" style="width: 400px; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
 </table>


 <table>
   <tr>
     <td>
       <p>
         🕹️ And then you can adjust its position and size on the screen to your liking.
       </p>
     </td>
   </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingScorePreview.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
 </table>

 <p> We will add the codes for score to the "Snake" script.</p>


```csharp
//Snake Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Snake : MonoBehaviour
{
    // Variable to store the score
    private int Score;

    // Heyy!!! Don't forget to add "using TMPro;" at the top to use TextMeshPro UI ;)
    // When we define the score variable, a section will appear in the snake object, assign the score text there.
    public TMP_Text Score_Text;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialize score to 0
        Score = 0;
        // Display the initial score on the screen
        Score_Text.text = "Score :" + Score.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        // Update the score text on the screen every frame
        Score_Text.text = "Score : " + Score.ToString();
    }

    // This function is triggered when the snake collides with another 2D collider.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            // Increment the score when the snake collides with food
            Score++;
        }
    }
}


```



 <table>
   <tr>
     <td>
       <p>
         🕹️ When we define the score variable, an area will appear in the snake object where we will assign the score text.
       </p>
     </td>
   </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingScore1.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
 </table>

 <p>Now, every time the snake eats the food, the score will increase by one. The last thing left to do is to add a game over scene.</p>

 ## Game Over☠️


<table>
   <tr>
     <td>
       <p>
         🕹️ To add a new scene, go to <b><i>"Project > Assets > Scenes"</i></b>.
       </p>
     </td>
   </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/newScene.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
  <tr>
     <td>
       <p>
         🕹️ In this scene, we will include <b><i>"Score", "High Score", "Try Again"</i></b> button, and <b><i>"Reset Scores"</i></b> button. You can arrange these UI objects in the scene as you want. 
         Don't forget to adjust the canvas settings as you did previously.
       </p>
     </td>
   </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/gameOver.png" style="width: 950px; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
  <tr>
     <td>
       <p>
         🕹️ You have already added TextMeshPro, you can add the button in a similar way.
       </p>
     </td>
   </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingUI_bttn.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
  <tr>
    <td>
      <p>
        🕹️ Now it's time to make them functional. For this we need to create an empty object (you can call it "Game_Over") and add a new script as a component.
      </p>
    </td>
  </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/addingScript_GameOver.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
 </table>

 ```csharp
// Game_Over Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Over : MonoBehaviour
{
    public TMP_Text Score_Display_Text;

    // Start is called before the first frame update
    void Start()
    {
        // Display the final score when the game over scene starts
        Score_Display();
    }

    // This method updates the score display text with the player's final score
    private void Score_Display()
    {
        // Update the text component with the final score from the Snake script
        Score_Display_Text.text = "Your Score : " + Snake.Score;
    }
}
```
<p>
  🕹️ In this code, since we are trying to access a variable from the snake script, we use <b><i>"public static Score;"</i></b> using <b><i>"public"</i></b> and <b><i>"static"</i></b> 
  to provide access instead of the <b><i>"private int Score;"</i></b> code fragment we wrote in the snake script. When we want to access the Score variable from the gameOver script, we use it as "Snake.Score;".</br>
  This is how we must specify the script to which the variable belongs.
</p>

```csharp

// It's  must be "public static" to access from other scripts.
    public static int Score;
```

<p>🕹️ To keep previous scores, just add the codes below.</p>

```csharp
//Snake Script

public class Snake : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {   

    }

    // Update is called once per frame
    private void Update()
    {

        //We saved the highest scores as integer using the "PlayerPrefs" class.
        // This code checks if the current score is higher than the saved high score.
        if (Score > PlayerPrefs.GetInt("High_Score"))
        {
        // If the current score is higher, it updates the saved high score to the current score.
        PlayerPrefs.SetInt("High_Score", Score);
        }
    }

   
}

```
```csharp
//Game_Over Script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Over : MonoBehaviour
{

    public TMP_Text High_Score_Text;

    // Start is called before the first frame update
    void Start()
    {
        // Display the high score when the game over screen is shown
        High_Score_Display();
    }

    private void High_Score_Display()
    {
        // Get the high score from PlayerPrefs and display it in the High_Score_Text
        High_Score_Text.text = "High Score : " + PlayerPrefs.GetInt("High_Score");
    }

}
```

<p>
   🕹️ Guys, we're getting closer and closer to the end. When our snake hits itself or the wall, it should switch to the game over scene. When the try again button is clicked, 
  the game should start again and when the reset score button is clicked, our old scores should be deleted.
  <b><i>Then, let's move on.</i></b>
</p>

```csharp
//Game_Over Script

using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void Try_Again()
    {
        //Heyy!!! Don't forget to add "using UnityEngine.SceneManagement;" at the top to switch between scenes ;)
        SceneManager.LoadScene(0);
    }

    public void Reset()
    {
        // We were able to access the "Score" in the "Snake.cs" because "Score" is defined as "public static".
        PlayerPrefs.SetInt("High_Score",Snake.Score);
        High_Score_Text.text = "High Score : " + 0;
        Score_Display_Text.text = "Your Score : " + 0;
    }

}
```

```csharp
// Snake Script

using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{

    private List<Transform> Tail = new List<Transform>();
    public Transform Tail_Prefab;
    public int Initial_Size = 3;

    // Start is called before the first frame update
    private void Start()
    {   
        Reset_State(); 
    }

    // Update is called once per frame
    private void Update()
    {
       
    }

    private void FixedUpdate()
    {
       
    }

  
    private void Reset_State()
    {
        for(int i = 1; i < Tail.Count; i++)
        {
            Destroy( Tail[i].gameObject );// Destroy all tail segments except the head
        }
        Tail.Clear();// Clear the tail list
        Tail.Add(this.transform);// Add the head to the tail list

        for(int i = 1; i < this.Initial_Size; i++)
        {
            Tail.Add(Instantiate(this.Tail_Prefab)); // Add initial tail segments
        }

        // Snake moves to the right by default.
        this.transform.position = Vector3.zero;
        direction = Vector2.right;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            
        }
        else if(other.tag == "Obstacle")
        {
            //Heyy!!! Don't forget to add "using UnityEngine.SceneManagement;" at the top to switch between scenes ;)
            SceneManager.LoadScene(1);
            Reset_State();
        }
    }

}

```

<table>
 <tr>
    <td>
      <p>
        🕹️ To make sure that the scene replacement codes work correctly, you need to make some changes in the editor. you need to add the scenes in the <b><i>"Build Settings"</i></b> window and sort them correctly. 
        You can add your scenes by dragging them to the list here.
      </p>
    </td>
  </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/switchScene1.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/switchScene2.png" style="max-width: 100%; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr><tr>
    <td>
      <p>
        🕹️ You can also make the necessary assignments for buttons as given below.
      </p>
    </td>
  </tr>
   <tr>
      <td style="vertical-align: top; text-align: center;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/buttonSetting1.png" style="width: 450px; height:auto; display: block; margin: 0 auto;">
          <img src="https://github.com/Ozlem-goksun/Snake2D_Unity_Tutorial/blob/main/Steps_ss/buttonSettin2.png" style="width: 450px; height:auto; display: block; margin: 0 auto;">
      </td>
  </tr>
  
 </table>

#### There seems to be nothing left to do. For now.
### See you in more advanced versions of the game.
# Good luck with the food hunt🐍🍎.


