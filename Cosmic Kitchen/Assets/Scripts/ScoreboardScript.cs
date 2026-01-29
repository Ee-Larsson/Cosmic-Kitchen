using System.IO;
using UnityEngine;

public class ScoreboardScript : MonoBehaviour
{
    Score currentScore;
    string filePath = Application.persistentDataPath + "\\Cosmic Kitchen\\Assets\\Resources\\ScoreBoard.txt";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void AddNewScore(string filePath)
    {
        int score = currentScore.returnScore();
        string[] scores = File.ReadAllLines(filePath);
        int i = 0;
        while (i <= scores.Length)
        {
            
            if (score > int.Parse(scores[i]))
            {
                scores[i] = "";
            }

            i++;
        }
    }
}
