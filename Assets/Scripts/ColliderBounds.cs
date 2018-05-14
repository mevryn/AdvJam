using UnityEngine;

public class ColliderBounds : MonoBehaviour
{
    SpriteRenderer spriteBorderChecker;
    Vector3 m_Min, m_Max;

    void Start()
    {
        //Fetch the Sprite Renderer from the GameObject
        spriteBorderChecker = GetComponent<SpriteRenderer>();
        //Fetch the minimum and maximum bounds of the Collider volume
        m_Min = spriteBorderChecker.bounds.min;
        m_Max = spriteBorderChecker.bounds.max;
        //Output this data into the console
        OutputData();
    }

    void OutputData()
    {
        //Output to the console the center and size of the Collider volume
        Debug.Log("Sprite bound Minimum : " + m_Min);
        Debug.Log("Sprite bound Maximum : " + m_Max);
    }
}