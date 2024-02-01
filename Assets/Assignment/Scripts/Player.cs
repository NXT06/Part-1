using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D PlayerRigidbody;  //referencing player object
    public float jumpForce = 10f;
    bool jumps = false;

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");              //getting movement inputs for player
        if (Input.GetKeyDown(KeyCode.Space) == true && jumps == true)   //checks if player is pressing space and if they are touching platforms
        {

            PlayerRigidbody.velocity = Vector2.up * jumpForce;      //increases upward velocity by set amount
        }
    }

    private void OnCollisionEnter2D()
    {
        UnityEngine.Debug.Log("Can jump");   //makes jumping available when on platforms
        jumps = true;
    }
    private void OnCollisionExit2D()    //makes jumping unavailable when off platforms
    {
        UnityEngine.Debug.Log("Can't jump");
        jumps = false;
    }
}
