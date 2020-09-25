using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UniversalValues;

public class PlayerMovementScript : MonoBehaviour
{
    public GameObject antag; //to access BeatScript

    void Start()
    {
        //UniversalValues.scale = 1;
        //Debug.Log(scale);
    }

    // Update is called once per frame
    void Update()
    {
        //player moves one lane up/down (within the screen) if they press the button on the beat
        //FIX - player can move twice on a beat if pressed quickly
        if (Input.GetKeyDown(KeyCode.UpArrow) && antag.GetComponent<BeatScript>().isOnBeat() && transform.position.y < 4)
        {
            transform.position = transform.position + new Vector3(0, 2, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && antag.GetComponent<BeatScript>().isOnBeat() && transform.position.y > -4)
        {
            transform.position = transform.position + new Vector3(0, -2, 0);
        }
    }
}
