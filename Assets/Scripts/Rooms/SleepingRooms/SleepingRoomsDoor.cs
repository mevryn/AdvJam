﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingRoomsDoor : MonoBehaviour {
    private GameObject character;
    void OnMouseDown()
    {
        if(GameHolderScript.instance.checkingRange(transform.position,character.transform.position,(float)character.GetComponent<CharacterBehaviour>().getRange()))
        {
            print("clicked");
            GameHolderScript.instance.loadLevel("roomlocked");
            character.transform.position = new Vector3(-7.5f, -2.04f, -1f);
        }
        else
        {
            GameHolderScript.instance.playerToFarAway();
        }
    }
	// Use this for initialization
	void Start () {
        character = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}