using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour {

    public Canvas mainUI;
	// Use this for initialization
	void Awake () {
        mainUI = FindObjectOfType<Canvas>();
        DontDestroyOnLoad(mainUI);
        Text dialog = mainUI.GetComponentInChildren<Text>();
        dialog.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
