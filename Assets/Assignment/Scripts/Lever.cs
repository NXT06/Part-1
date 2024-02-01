using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    SpriteRenderer leverColor;
    public Color color;
    public GameObject lever;
    public Transform platformRotation;
    public float degree;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        leverColor = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (on == true && platformRotation.rotation.z <= degree)  //checking if lever has been touched and if platform has already turned 180 degrees
        {
            platformRotation.transform.Rotate(0, 0, -10 * Time.deltaTime);  //rotating spiked platform 
            leverColor = GetComponent<SpriteRenderer>();
            leverColor.color = color; 
        }
        else
        {
            leverColor.color = Color.red;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checking if lever has been switch on or off 
        if (on == false)
        {
            on = true;
            UnityEngine.Debug.Log("Switch On");
        }
        else if (on == true)
        {
            on = false;
            UnityEngine.Debug.Log("Switch Off");
        }
        
    }
}
