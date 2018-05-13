using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameHolderScript : MonoBehaviour
{
    public static GameHolderScript instance = null;
    private List <Vector3> spawningPoint = new List<Vector3>();
    private List<string> sceneList = new List<string>();
    public List<GameObject> backgroundList = new List<GameObject>();
    public GameObject player;
    public GameObject thisPlayer;
    private string currentSceneName;

    public string getCurrentSceneName()
    {
        return currentSceneName;
    }
    void Awake()
    {
        // sprawdzenie czy istnieje juz instancja tego obiektu
        if (instance == null)
            //jezeli nie to przypisujemy instancje do tego obiektu
            instance = this;
        //jezeli instancja i to nie jest to
        else if (instance != this)
            //Wtedy zniszcz ten obiekt, co powoduje, ze moze istniec tylko 1 obiekt GameHolderScripta
            Destroy(gameObject);
        //Ustawia aby ten obiekt nie byl niszczony przy ladowaniu nowej sceny
        DontDestroyOnLoad(gameObject);
        sceneList.Add("hibernation");
        spawningPoint.Add(new Vector3(0, (float)-1.8, -1));
        loadLevel(sceneList[0]);
        //tworzenie Obiektu Postaci przy starcie gry
    }
     void Start()
    {
        InitGame();
    }
    void loadLevel(string level)
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
        Scene currentScene = SceneManager.GetActiveScene();
        string currentSceneName = currentScene.name;
    }
    void InitGame()
    {
        Camera.main.orthographicSize = (float)4.125;
        thisPlayer = (GameObject)Instantiate(player, spawningPoint[0], Quaternion.identity);
        Instantiate(backgroundList[0]);
        
    }
    void Update()
    {
    }
}
