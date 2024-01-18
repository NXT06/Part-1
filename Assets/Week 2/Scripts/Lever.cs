using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door.activeInHierarchy == false) { 
        door.SetActive(true);
        UnityEngine.Debug.Log("Lever Off");
    }
        else
        {
            door.SetActive(false);
            UnityEngine.Debug.Log("Lever On");
        }
    }
}
