    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{

    public SpriteRenderer Apperance;
    public Sprite[] animationArray;
    public float speed;
    public Rigidbody2D rb2d;

    private Animator animationController;

    void Movement()
    {
        //Przechowywanie tymczazowego x'owego wejscia w zmiennej moveHorizontal typu float
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Użycie zmiennej moveHorizontal aby utworzyć nowy vector2 movement 
        Vector2 movement = new Vector2(moveHorizontal, 0);
        if (canMove()) ;
        //Nadanie szybkości ciału naszego Bohatera
        rb2d.velocity = movement * speed;
    }
    //Awake wykonuje sie przed funkcja Start() w Unity
    void Awake()
    {
        //Przypisanie do obiektu animatora, animatora naszego obiektu postaci
        animationController = GetComponent<Animator>();
        //Nadanie wygladu poczatkowego naszej postaci
        Apperance.sprite = animationArray[0];
    }
    void Animation()
    {
        //warunek na animacje
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {
            //Przekazywanie do animatora czy ma animowac czy nie
            animationController.SetBool("Movement", true);
            //obracanie lewo, prawo
            Apperance.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
            animationController.SetBool("Movement", true);
            Apperance.flipX = false;
        }
        else
        {
            animationController.SetBool("Movement", false);
        }


    }
    //FixedUpdate wywoluje sie z niezalezna predkoscia klatek na sekunde
    void FixedUpdate()
    {
        Animation();
        Movement();
    }
    bool canMove()
    {
        if (GameHolderScript.instance.getCurrentSceneName() == "hibernation")
        {

        }
        return true;
    }
}
