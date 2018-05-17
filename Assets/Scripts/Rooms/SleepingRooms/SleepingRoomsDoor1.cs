using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingRoomsDoor1 : MonoBehaviour {
    private GameObject character;
    void OnMouseDown()
    {
        if(GameHolderScript.instance.checkingRange(transform.position,character.transform.position,(float)character.GetComponent<CharacterBehaviour>().getRange()))
        {
            GameHolderScript.instance.doorClosed();
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
