using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger : MonoBehaviour {

    void OnMouseDown()
    {

        Inventory charInv = GameObject.Find("player").GetComponent<Inventory>();
        charInv.inventoryList.Add((GameObject)Resources.Load("Finger"));
        Destroy(gameObject);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
