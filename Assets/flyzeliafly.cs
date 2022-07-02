using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyzeliafly : MonoBehaviour
{
    public float velocity = 1;
    

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        rb.velocity = Vector2.up * velocity;
        
        var pos = Input.mousePosition;
        pos.z = transform.position.z;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos = transform.InverseTransformPoint(pos);
        
        Vector2 vec;
        
        vec = new Vector2(-pos[0], 1);
        
        rb.velocity = vec * velocity;
    }
}
