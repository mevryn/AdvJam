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
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        if (playerPosition.x < -3.8f)
        {
            transform.position = new Vector3(-3.8f, playerPosition.y + 1.8f, -10.0f);
        } 
        else if (playerPosition.x > 3.8f) {
            transform.position = new Vector3(3.8f, playerPosition.y + 1.8f, -10.0f);
        }
            
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
                preventCameraMovement(3.8f);
                break;
            case "hibernation":
                preventCameraMovement(2.5f);
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
        else if (playerPosition.x < frame)
        {
            transform.position = new Vector3(-frame, playerPosition.y + 1.8f, -10.0f);
        }
        else if (playerPosition.x > frame)
        {
            transform.position = new Vector3(frame, playerPosition.y + 1.8f, -10.0f);
        }
    }
}
