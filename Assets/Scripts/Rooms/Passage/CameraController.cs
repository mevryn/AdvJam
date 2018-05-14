using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
public class CameraController : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
	}
	bool checkIfMovable(Vector3 pos)
    {
        if (pos.x <= 1.17f & pos.x >= -1.17f)
        {
            return true;
        }
        else
            return false;
    }
    void LateUpdate()
    {
        if(checkIfMovable(player.transform.position))
        transform.position = player.transform.position + offset;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
