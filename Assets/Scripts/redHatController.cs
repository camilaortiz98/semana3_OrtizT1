using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redHatController : MonoBehaviour
{
    public float velocity = 10;
    public float jumpForce = 70;

    // Start is called before the first frame update

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;

    //const
    private const int RUN = 0;
    private const int JUMP = 1;
    private const int SLIDE = 2;
    private const int DEAD = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocity, rb.velocity.y);
       //sr.flipX = false;
       changeAnimation(RUN);

    }

    private void changeAnimation(int animation)
    {
        animator.SetInteger("Estado", animation);
    }
}
