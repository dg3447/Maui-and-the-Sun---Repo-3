﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D myRigidbody;
    public Animator myAnimator;

    [SerializeField]
    private float MovementSpeed;

    private bool attack;
    private bool slide;

    private bool facingRight;

    [SerializeField]
    private Transform[] groundChecks;

    [SerializeField]
    private float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;
    private bool isGrounded;

    private bool jump;
    private bool jumpAttack;

    [SerializeField]
    private bool airControl;

    [SerializeField]
    private float jumpForce;


    //healthbar
    public int maxHealth = 3;
    public int currentHealth;
    public HealthBar healthbar;

    private Inventory inventory;
    [SerializeField]
    private UI_Inventory uiInventory;


    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemWorld itemWorld = collision.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            inventory.addItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
                
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;     //player always face on right direction
        myRigidbody = GetComponent<Rigidbody2D>();  //referencing the rigidbody2d component of the player
        myAnimator = GetComponent<Animator>();     //referencing the Animator component of the player
        currentHealth = maxHealth;            
        healthbar.setMaxHealth(maxHealth);       //setting max health for player
    }


    private void Update() //Update updates once per frame
    {
        HandleInput();
        
    }

   

    void FixedUpdate()    //fixedUpdate updates on fixed amount of time, regardless of frames  
    {
        float horizontal = Input.GetAxis("Horizontal"); // geting x-axis values

        isGrounded = IsGrounded();

        HandleMovement(horizontal);  //method call
        Flip(horizontal);            //method call
        HandleAttack();              //method call
        HandleLayers();              //method call
        ResetValues();               //method call
    }

    private void HandleMovement(float horizontal)
    {
        if (myRigidbody.velocity.y < 0)
        {
            myAnimator.SetBool("land", true);
        }
    
        if (!myAnimator.GetBool("slide") &&!this.myAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Attack") && (isGrounded || airControl)) // if player is not(!) attacking 
        {
            myRigidbody.velocity = new Vector2(horizontal * MovementSpeed, myRigidbody.velocity.y);   //moving player with velocity
        }

        if (isGrounded && jump)
        {
            isGrounded = false;
            myRigidbody.AddForce(new Vector2(0, jumpForce));
            myAnimator.SetTrigger("jump");


        }


        if (slide && !this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("slide"))
        {
            myAnimator.SetBool("slide", true);
        }
        else if (!this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("slide")) // slide is name of slide animation
        {
            myAnimator.SetBool("slide", false); // slide parameters bool
        }


        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));  // running player depending on the speed parameter which returns >0.01||<0.01 for which Mathf.Abs is needed
    }

    private void HandleAttack() //handling the attacks of the player
    {
        if (attack && isGrounded && !this.myAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Attack")) // attacking is not starting after the original attack is done
        {
            myAnimator.SetTrigger("attack");
            myRigidbody.velocity = Vector2.zero;  // (reseting the velocity after affacting)
        }

        if (jumpAttack && !isGrounded && !this.myAnimator.GetCurrentAnimatorStateInfo(1).IsName("jumpAttack"))
        {
            myAnimator.SetBool("jumpAttack", true);
        }
        if (!jumpAttack && !this.myAnimator.GetCurrentAnimatorStateInfo(1).IsName("jumpAttack"))
        {
            myAnimator.SetBool("jumpAttack", false);
        }

        
    }
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))   // checking if  'E' is pressed of keyboard
        {
            attack = true;
            jumpAttack = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            slide = true;
        }
       
    }

    private void Flip(float horizontal)   //flipping the player in left and right direction along x-axis
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale; 
        }
    }

    private void ResetValues() // resetting values to default
    {
        attack = false;
        slide = false;
        jump = false;
        jumpAttack = false;
    }

    private bool IsGrounded()   //checking if player is landed on ground
    {
        if (isGrounded == true)
        {
            myAnimator.ResetTrigger("jump");
            myAnimator.SetBool("land", false);

        }
        return  transform.Find("groundCheck").GetComponent<GroundCheck>().isGrounded;
    }

    private void HandleLayers()
    {
        if (!isGrounded)
        {
            myAnimator.SetLayerWeight(1, 1);
        }
        else
        {
            myAnimator.SetLayerWeight(1, 0);
        }

    }


    public void takedamage(int damage)
    {
        currentHealth -= damage;
       
        healthbar.setHealth(currentHealth);

       

        if (currentHealth<0)
        {
            myAnimator.SetTrigger("dead");
        }
    }


}
