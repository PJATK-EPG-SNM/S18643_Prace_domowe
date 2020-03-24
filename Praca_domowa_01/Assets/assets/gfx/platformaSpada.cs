using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformaSpada : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals ("ludek"))
        {
            Invoke("Spada", 1f);
            Destroy(gameObject, 1.6f);
        }
    }
    void Spada()
    {
        rb.isKinematic = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
