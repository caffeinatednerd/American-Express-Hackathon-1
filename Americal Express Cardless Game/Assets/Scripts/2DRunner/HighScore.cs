using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text score;
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    /*
    public void ScoreCounter()
    {
        //int scoreInt = score;

        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreInt);
            highScore.text = scoreInt.ToString();
        }
    }*/
}
