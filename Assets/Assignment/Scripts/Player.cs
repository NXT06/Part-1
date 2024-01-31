using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float force = 10f;
    float jumps = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) == true && jumps == 1)
        {

            rigidbody.velocity = Vector2.up * force;
            jumps = 0f;
        }
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        UnityEngine.Debug.Log("Can jump");
        jumps = 1;
    }
}
