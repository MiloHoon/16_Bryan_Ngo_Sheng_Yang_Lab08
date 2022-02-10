using UnityEngine;
using UnityEngine.UI;

public class InvisibleWallScript : MonoBehaviour
{
    private int score;

    public Text ScoreText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            score++;
            ScoreText.text = "Score: " + score;
        }
    }
}
