using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;


public class flyzeliafly : MonoBehaviour
{
    public float velocity = 1;
    public Text gameText;
    private int gameScore;
	public AudioSource Hlish;
	public GameObject dup;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int gameScore = 0;
		gameText.text = "Beat me";
		FindObjectOfType<typewriterUI>().Start();

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        CameraShaker.Instance.ShakeOnce(7f, 7f, .1f, .1f);

        
        var pos = Input.mousePosition;
        pos.z = transform.position.z;
        pos = Camera.main.ScreenToWorldPoint(pos); 
        pos = transform.InverseTransformPoint(pos); 
        gameScore++;
        gameText.text = "" + gameScore;
		FindObjectOfType<typewriterUI>().Start();
        Vector2 vec;
        // Я зубрю ;)
        vec = new Vector2(-pos[0], 1); //Гений, даже ВС код выделил
        
        rb.velocity = vec * velocity;
		Hlish.Play();
		if (gameScore == 20) {
			GameObject duplicate = Instantiate(dup);
		}
		if (gameScore == 50) {
			GameObject duplicate = Instantiate(dup);
		}
		if (gameScore == 100) {
			GameObject duplicate = Instantiate(dup);
		}

    }

    void Update() {
        if (rb.position.y < -10f){
            FindObjectOfType<GameManager>().GameOver();
        }
    }


}
