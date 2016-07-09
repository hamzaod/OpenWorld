using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CharchterControllerr : NetworkBehaviour
{

	Animator anim; 
	public float speed = 0.05f;
    float input_x;
    float input_y;
    // Use this for initialization
    private Transform myTransform;
    void Start () {
        myTransform = GetComponent<Transform>();
        anim = GetComponent<Animator>();
        if (isLocalPlayer)
        {
            myTransform.FindChild("camera").GetComponent<Camera>().enabled = true;
        }
		
	}

    // Update is called once per frame
    void Update() {
        

        if (isLocalPlayer) { 
           input_x = Input.GetAxisRaw("Horizontal");
           input_y = Input.GetAxisRaw("Vertical");
       
        bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;
        
            anim.SetBool("isWalking", isWalking);
            if (isWalking)
            {
                anim.SetFloat("x", input_x);
                anim.SetFloat("y", input_y);

                transform.position += new Vector3(input_x, input_y, 0).normalized * speed;

            }
        
        
    }
    }

}
