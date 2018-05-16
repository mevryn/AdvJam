using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassageEntry : MonoBehaviour {
    private GameObject character;
	// Use this for initialization
	void Start () {
        character = GameObject.FindGameObjectWithTag("Player");
        //changePosition();
    }
    void changePosition()
    {
        character.transform.position = new Vector3(-9f,-2.04f,-1f);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
