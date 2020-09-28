using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBackground : MonoBehaviour
{
    public float speed;
    public GameObject starBG;
    private bool successor = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime * -1, 0, 0);
        if (transform.position.x <= -1.06 && !successor)
        {
            successor = true;
            Instantiate(starBG, new Vector3(18.89f, -2.9f, 0), Quaternion.identity);
        }
        if (transform.position.x <= -18.93)
        {
            Destroy(this.gameObject);
        }
    }
}
