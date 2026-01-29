using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] int lives;
    [SerializeField] TextMeshProUGUI livesBoard;
    int scoreLastFrame;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == scoreLastFrame - 50)
        {
            lives--;
        }
        livesBoard.text = lives.ToString();

        if (lives == 0)
        {
            print("CHANGING SCENE!");
            SceneManager.LoadScene("LoseScene");
        }
        scoreLastFrame = score;
    }
}
