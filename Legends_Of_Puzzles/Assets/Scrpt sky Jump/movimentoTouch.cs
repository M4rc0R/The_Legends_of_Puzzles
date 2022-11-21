using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class movimentoTouch : MonoBehaviour
{
	public float movementSpeed = 10f;

	Rigidbody2D rb;

	public Joystick joystick;

	public GameObject gameOver;

	float movement = 20f;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		//movimentação com joystick (ainda meio bugado) movement = joystick.Horizontal * movementSpeed;
		movement = Input.GetAxisRaw("Horizontal") * movementSpeed;
	}



	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FoideBase") 
		{
			gameOver.SetActive(true);
			Time.timeScale = 0;
		}
    }


    
}

