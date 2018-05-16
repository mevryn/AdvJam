using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenDoor : MonoBehaviour {
    private GameObject character;
    void OnMouseDown()
    {
        if (GameHolderScript.instance.checkingRange(transform.position, character.transform.position, (float)character.GetComponent<CharacterBehaviour>().getRange()))
        {
            print("clicked");
            GameHolderScript.instance.loadLevel("passage");
            character.transform.position = new Vector3(-9f, -2.04f, -1f);
        }
        else
        {
            GameHolderScript.instance.playerToFarAway();
            StartCoroutine(deleteText());
        }
    }
	// Use this for initialization
	void Start () {
        character = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator deleteText()
    {
        yield return new WaitForSeconds(2f);
        UI.instance.disableText();
    }
}
