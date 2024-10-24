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
        if (!Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKeyDown(KeyCode.LeftArrow))
            {
            GetComponent<Animator>().SetBool("Walk", false);
        }
      if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            GetComponent<Animator>().SetBool("Walk", true);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            GetComponent<Animator>().SetBool("Walk",true);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.UpArrow) && onGround)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce);
            GetComponent<Animator>().SetTrigger("Jump");
            onGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            onGround = true;
    }
}
