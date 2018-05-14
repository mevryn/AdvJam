using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraScript : MonoBehaviour
{
   public Vector3 playerPosition;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        chooseSceneToPreventCamera();
    }

    void chooseSceneToPreventCamera()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentSceneName = currentScene.name;
        switch (currentSceneName)
        {
            case "passage":
                preventCameraMovement(1.2f);
                break;
            case "hibernation":
                preventCameraMovement(0f);
                break;
        }
       
    }

    void preventCameraMovement(float frame)
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        if (playerPosition.x > -frame & playerPosition.x < frame) 
        {
            Debug.Log("true"+playerPosition.x);
            transform.position = new Vector3(playerPosition.x, playerPosition.y + 1.8f, -10.0f);
        }
        else
        {
            Debug.Log("false"+playerPosition.x);
            transform.position = transform.position;
        }
    }
}
