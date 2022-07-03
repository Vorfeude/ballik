using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flyzeliafly : MonoBehaviour
{
    public float velocity = 1;
    public Text gameText;
    private int gameScore;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int gameScore = 0;
        gameText.text = "" + gameScore;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        rb.velocity = Vector2.up * velocity;
        
        var pos = Input.mousePosition;
        pos.z = transform.position.z;
        pos = Camera.main.ScreenToWorldPoint(pos); 
        pos = transform.InverseTransformPoint(pos); 
        gameScore++;
        gameText.text = "" + gameScore;
        Vector2 vec;
        // Я зубрю ;)
        vec = new Vector2(-pos[0], 1); //Гений, даже ВС код выделил
        
        rb.velocity = vec * velocity;
    }
}
