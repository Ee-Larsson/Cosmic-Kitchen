using System;
using System.Collections.Generic;
using UnityEngine;

public class NPC_interaction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    List<string> dialouge = new List<string>();
    Component actionScript;
    bool colliding = false;

    void Start()
    {
        dialouge.Add("Test string one");
        dialouge.Add("test string two");
        dialouge.Add("Test string three");
        dialouge.Add("Test string four");
        //get list of foods
    }

    // Update is called once per frame
    void Update()
    {
        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
        if (colliding == true && Input.GetKeyDown(KeyCode.E))
        {
            System.Random rand = new System.Random();
            int x = rand.Next(0, dialouge.Count);
            Debug.Log(dialouge[x]);
        }
    }
}
