using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    public bool is3D;
    private void Update()
    {
        if (!is3D)
        {
            scoreText.text = player.position.x.ToString("0");
        }
        else
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
