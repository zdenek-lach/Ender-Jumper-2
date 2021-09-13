using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject player;
    public Rigidbody2D thiccBody2D;
    public float movementSpeed;
    public float jumpDetermination;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 2;
        jumpDetermination = 2;
        GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move Right
        if(Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            // thiccBody2D.velocity = new Vector2(movementSpeed, 0f);
            thiccBody2D.AddForce(Vector2.right * movementSpeed*1000 * Time.deltaTime);
            // Debug.Log("YEET right");
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            thiccBody2D.AddForce(transform.right * jumpDetermination*20, ForceMode2D.Impulse);
            // Debug.Log("SUPER YEET right");
        }
        //Move Left
        if(Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //thiccBody2D.velocity = new Vector2(-movementSpeed, 0f);
            thiccBody2D.AddForce(Vector2.right * -movementSpeed * 1000 * Time.deltaTime);
            // Debug.Log("YEEET left");
        }
        //Move up AKA JUMP
        if(Input.GetAxisRaw("Vertical") > 0.5f && isGrounded) {
            thiccBody2D.AddForce (Vector2.up * jumpDetermination *1000 * Time.deltaTime, ForceMode2D.Impulse);
            isGrounded = false;
            //thiccBody2D.velocity = new Vector2(0f,jumpDetermination);
            //thiccBody2D.AddForce(Vector2.up * jumpDetermination *1000 * Time.deltaTime);
            // Debug.Log("YEET UP");
        }
        
    }
     void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
        //Debug.Log("I'm touching" + col);
    }
}
