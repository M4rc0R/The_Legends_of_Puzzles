using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    
    public float Speed;
    
    private Rigidbody2D rig;
    
    public int diamonds;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "diamond"){
            Destroy(collision.gameObject);
            diamonds = diamonds + 1;
    }
    if(collision.gameObject.tag == "bomb"){
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

        
        
}
}
