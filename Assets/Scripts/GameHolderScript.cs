using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHolderScript : MonoBehaviour
{

    public GameObject player;
    void Start()
    {
        //tworzenie Obiektu Postaci przy starcie gry
        Instantiate(player, new Vector3(0, (float)-2.3, 0), Quaternion.identity);
    }

    void Update()
    {
    }
}
