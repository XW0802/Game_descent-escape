using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
    public float speed;
    float xVelocity;

    public float checkRadius;
    public LayerMask playform;
    public GameObject groundCheck;
    public bool isonGround;

    bool playerDead;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isonGround = Physics2D.OverlapCircle(groundCheck.transform.position, checkRadius, playform);
        anim.SetBool("isonGround", isonGround);
        Movement();
    }

    void Movement()
    {
        xVelocity = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);

        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));

        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity, 1, 1);
        }
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag ("Fan"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spike"))
        {
            anim.SetTrigger("dead");
        }
    }

    public void PlayerDead()
    {
        playerDead = true;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(groundCheck.transform.position, checkRadius);
    }
}