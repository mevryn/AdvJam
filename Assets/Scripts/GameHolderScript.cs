using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameHolderScript : MonoBehaviour
{
    private List <Vector3> spawningPoint = new List<Vector3>();
    private List<string> sceneList = new List<string>();
    public List<GameObject> backgroundList = new List<GameObject>();
    public GameObject player;
    void Awake()
    {
        sceneList.Add("hibernation");
        SceneManager.LoadScene(sceneList[0], LoadSceneMode.Single);
        spawningPoint.Add(new Vector3(0, (float)-1.8, -1));
        //tworzenie Obiektu Postaci przy starcie gry
        Instantiate(player, spawningPoint[0], Quaternion.identity);
    }

    void Update()
    {
    }
}
