using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassageDoor : MonoBehaviour {
    private GameObject character;
    void OnMouseDown()
    {
        if(GameHolderScript.instance.checkingRange(transform.position,character.transform.position,(float)character.GetComponent<CharacterBehaviour>().getRange()))
        {
            print("clicked");
            GameHolderScript.instance.loadLevel("hibernation");
            character.transform.position = new Vector3(12f, -2.04f, -1f);
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
