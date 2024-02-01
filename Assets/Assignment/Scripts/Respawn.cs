using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;  //referencing player location and velocity
    public Transform spawn;     //referencing spawn location

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.position = spawn.position;   //teleports player back to spawn on collision
        player.velocity = player.velocity - player.velocity;    //resets players velocity to 0 when respawning
    }
}
