using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public GameObject antag;
    public GameObject player;
    public float speed;
    public float initPos;

    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        if (transform.position.x < -11)
            Destroy(this.gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Player".Equals(collision.gameObject.tag))
        {
            UnityEngine.Debug.Log("collision");
            player.GetComponent<PlayerScript>().score -= 250;
            Destroy(this.gameObject);
        }
    }
}
