using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    float speed = 1f;
    float jumpForce = 5f;
    bool onGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }
        if (Input.GetKey(KeyCode.W) && onGround)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce);
            onGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            onGround = true;
    }
}
