using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public Rigidbody2D spawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.position = spawn.position;
        player.velocity = spawn.velocity;
    }
}
