using System;
using System.Collections.Generic;
using UnityEngine;

public class NPC_interaction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    List<string> dialouge = new List<string> {"test string one", "test string two", "test string three", "test string four"};
    Component actionScript;
    bool colliding = false;

    void Start()
    {
        //get list of foods
    }

    // Update is called once per frame
    void Update()
    {
        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
        if (colliding == true && Input.GetKeyDown(KeyCode.E))
        {
            int x = new Random.Range(1, 5);
            Console.Write(x);
        }
    }
}
