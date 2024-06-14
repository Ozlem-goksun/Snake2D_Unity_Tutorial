using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Game_Over : MonoBehaviour
{

    public TMP_Text Score_Display_Text;
    public TMP_Text High_Score_Text;

    // Start is called before the first frame update
    void Start()
    {
        Score_Display();
        High_Score_Display();
    }

    private void Score_Display()
    {
        Score_Display_Text.text = "Your Score : " + Snake.Score;
    }

    private void High_Score_Display()
    {
        High_Score_Text.text = "High Score : " + PlayerPrefs.GetInt("High_Score");
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
