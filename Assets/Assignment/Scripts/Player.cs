using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D PlayerRigidbody;
    public float force = 10f;
    bool jumps = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) == true && jumps == true)
        {

            PlayerRigidbody.velocity = Vector2.up * force;
            jumps = false;
        }
    }

    private void FixedUpdate()
    {
        PlayerRigidbody.AddForce(direction * force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.Debug.Log("Can jump");
        jumps = true;
    }
}
