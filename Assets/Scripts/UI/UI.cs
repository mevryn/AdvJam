using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour {
    public static UI instance = null;
    public Canvas mainUI;
    public Text dialog;
    // Use this for initialization
    void Awake () {
        // sprawdzenie czy istnieje juz instancja tego obiektu
        if (instance == null)
            //jezeli nie to przypisujemy instancje do tego obiektu
            instance = this;
        //jezeli instancja i to nie jest to
        else if (instance != this)
            Destroy(gameObject);
        mainUI = FindObjectOfType<Canvas>();
        DontDestroyOnLoad(mainUI);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
         dialog = mainUI.GetComponentInChildren<Text>();
        disableText();
	}
	public void disableText()
    {
        dialog.text = "";
    }
	// Update is called once per frame
	void Update () {
		
	}
}
