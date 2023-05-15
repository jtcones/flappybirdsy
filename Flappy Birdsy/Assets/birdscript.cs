using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public gameLogic logic;
    public bool birdisalive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisalive)
        {
            myRigidbody.velocity = Vector2.up * flapstrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdisalive = false;
    }
}
