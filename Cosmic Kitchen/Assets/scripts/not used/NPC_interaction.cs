using Assets.Scripts;
using System;
using System.Collections.Generic;
using UnityEngine;

public class NPC_interaction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    List<string> RequestDialouge = new List<string>();
    List<Food> RequestList;
    List<string> FoodDialouge = new List<string>();
    Food request;
    Component actionScript;
    bool colliding = false;
    [SerializeField] GameObject player;
    bool HasGivenRequest = false;
    bool HasFood = false;

    void Start()
    {
        
        RequestDialouge.Add("Test string one"); 
        RequestDialouge.Add("test string two"); 
        RequestDialouge.Add("Test string three");
        RequestDialouge.Add("Test string four");
        //get list of foods
    }

    // Update is called once per frame
    void Update()
    {
        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
        if (colliding == true && Input.GetKeyUp(KeyCode.E) && HasGivenRequest == false) //give request
        {
            System.Random rand = new System.Random();
            int x = rand.Next(0, RequestDialouge.Count);
            request = RequestList[x];
            Debug.Log(RequestDialouge[x]);

            HasGivenRequest = true;
        }
        if (colliding == true && Input.GetKeyUp(KeyCode.E) && HasGivenRequest == true && HasFood == false) //player gives food
        {
            if (request == player.GetComponent<Holding>().ReturnHolding())
            {
                player.GetComponent<Holding>().PlaceFood();
                HasFood = true;
                Debug.Log("yay thank you");
            }

            else
            {
                Debug.Log("grrrrr wrong food fuckass >:(");
            }
        }


    }
}
