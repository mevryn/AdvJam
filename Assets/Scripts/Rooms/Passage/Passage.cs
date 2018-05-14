using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour {
    private GameObject character;
	// Use this for initialization
	void Start () {
        character = GameObject.FindGameObjectWithTag("Player");
        changePosition();
    }
    void changePosition()
    {
        character.transform.position = new Vector3(-9f,-1.8f,-1f);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
