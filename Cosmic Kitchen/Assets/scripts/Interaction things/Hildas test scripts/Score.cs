using NUnit.Framework;
using System.IO.Pipes;
using System.Linq;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    hotfix_npc_Interaction[] npcs= FindObjectsByType<hotfix_npc_Interaction>(FindObjectsSortMode.None);
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreBoard;
    

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < npcs.Count(); i++)
        {
            score += npcs[i].ReturnScore();
            npcs[i].ScoreRemoval();
        }
        scoreBoard.text = score.ToString();
    }
}
