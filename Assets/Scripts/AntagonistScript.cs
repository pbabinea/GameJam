using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AntagonistScript : MonoBehaviour
{
    public GameObject indicator;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        indicator.GetComponent<Renderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        count++;
        if (count == 50)
            count = 0;

        if(count == 20)
            indicator.GetComponent<Renderer>().enabled = true;

        if (count == 30)
            indicator.GetComponent<Renderer>().enabled = false;

    }
}
