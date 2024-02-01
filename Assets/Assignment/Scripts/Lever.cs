using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject lever;
    public Transform platformRotation;
    public float degree;
    bool firstPlat = false;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (on == true && platformRotation.rotation.z <= degree)  //checking if lever has been touched and if platform has already turned 180 degrees
        {
            platformRotation.transform.Rotate(0, 0, -10 * Time.deltaTime);  //rotating spiked platform 

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //checking if lever has been switch on or off 
        if (on == false)  
        {
            on = true;
        }
        else if (on == true)
        {
            on = false;
        }
        UnityEngine.Debug.Log("Switch");  
    }
}
