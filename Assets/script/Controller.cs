using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
    public float maxSpeed = 10f;
    bool facingRight = true;
    public Rigidbody2D Body;
    Animator anim;
	void Start () {
        Body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));
        float moveUp = Input.GetAxis("Vertical");
        anim.SetFloat("Speed2", Mathf.Abs(moveUp));

        Body.velocity = new Vector2(move * maxSpeed, Body.velocity.y);
      
        if (move > 0 && !facingRight)
        {
            Flip();
        }

       

        else if (move < 0 && facingRight)
        {
            Flip();
        }


        if (moveUp < 0 && move != 0)//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -2 * Time.deltaTime, 0);

        }
        else if (moveUp < 0 && move == 0)
        {
			anim.SetBool("change", true);
            transform.Translate(0, -maxSpeed * Time.deltaTime, 0);
        }
        if (moveUp > 0 && move != 0)//Press up arrow key to move forward on the Y AXIS
        {

            transform.Translate(0, 2 * Time.deltaTime, 0);
        }
        else if (moveUp > 0 && move == 0)//Press up arrow key to move forward on the Y AXIS
        {
			anim.SetBool("change", true);
            transform.Translate(0, maxSpeed * Time.deltaTime, 0);
        }



	}
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
 
}
