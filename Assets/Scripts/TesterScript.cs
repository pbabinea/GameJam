using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterScript : MonoBehaviour
{
    //public GameObject antag;
    public BeatScript beat;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
       //beat = antag.GetComponent<BeatScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(beat.isOnBeat())
            this.GetComponent<Renderer>().enabled = true;
        else
            this.GetComponent<Renderer>().enabled = false;
    }
}
