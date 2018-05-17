using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameHolderScript : MonoBehaviour
{
    public static GameHolderScript instance = null;
    public List<Vector3> spawningPoint = new List<Vector3>();
    private List<string> sceneList = new List<string>();
    public List<GameObject> backgroundList = new List<GameObject>();
    public GameObject player;
    public GameObject thisPlayer;
    private string currentSceneName;
    private Canvas mainUI;
    protected float cameraSize =(float)5;
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
        spawningPoint.Add(new Vector3((float)0.1, (float)-2.04, -1));
        loadLevel(sceneList[0]);
        //tworzenie Obiektu Postaci przy starcie gry
    }
    void Start()
    {
        mainUI = FindObjectOfType<Canvas>();
        InitGame();
    }
    public void playerToFarAway()
    {
        Text dialog = mainUI.GetComponentInChildren<Text>();
        dialog.text = "It's too far away";
        StartCoroutine(deleteDialog(dialog));
    }
    public void doorClosed()
    {
        Text dialog = mainUI.GetComponentInChildren<Text>();
        dialog.text = "It's locked";
        StartCoroutine(deleteDialog(dialog));
    }
        IEnumerator deleteDialog(Text dialog)
    {
        yield return new WaitForSeconds(2);
        dialog.text = "";
    }
    public void loadLevel(string level)
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
        Scene currentScene = SceneManager.GetActiveScene();
        string currentSceneName = currentScene.name;
        Debug.Log("Trigger");
    }
    void InitGame()
    {
        Camera.main.orthographicSize = (float)5;
        thisPlayer = (GameObject)Instantiate(player, spawningPoint[0], Quaternion.identity);
    }
    public bool checkingRange(Vector3 pos1,Vector3 pos2,float range)
    {
        print(pos1.x + " " + pos2.x + " " + range);
        if (pos1.x < pos2.x)
        {
            float temp = pos1.x;
            pos1.x = pos2.x;
            pos2.x = temp;
        }
        if (pos1.x - pos2.x < range)
        {
            return true;
        }
        else
            return false;
    }

    void Update()
    {
        Debug.Log(Screen.width + " " + Screen.height);

    }
}