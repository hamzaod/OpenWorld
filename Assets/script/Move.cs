using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	private Animator anim;
	public Vector3 startPosition;
	public Vector2 speed = new Vector2(1,0);
	public float sp = 1f;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame




	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		anim.SetFloat ("SpeedX", inputX);
		anim.SetFloat ("SpeedY", inputY);
		
		Vector3 mouvement = new Vector3 (
			speed.x = inputX,
			speed.y = inputY,
			0);
		if (inputX < 0 && inputY < 0)
			mouvement *= sp / 2;
		else if (inputX > 0 && inputY > 0)
			mouvement *= sp / 2;

		else if (inputX > 0 && inputY < 0)
			mouvement *= sp / 2;

		else if (inputX < 0 && inputY > 0)
			mouvement *= sp / 2;


		else
			mouvement *= sp;

		transform.Translate (mouvement);
	}

	void FixedUpdate () {
		float lastInputX = Input.GetAxis("Horizontal");
		float lastInputY = Input.GetAxis("Vertical");
		if (lastInputX != 0 || lastInputY != 0) {
			anim.SetBool ("walking", true);
			if(lastInputX>0){
				anim.SetFloat("LastMoveX",1f);
			}else if(lastInputX<0){
				anim.SetFloat("LastMoveX",-1f);
			}else{
				anim.SetFloat("LastMoveX",0f);
			}


			if(lastInputY>0){
				anim.SetFloat("LastMoveY",1f);
			}else if(lastInputY<0){
				anim.SetFloat("LastMoveY",-1f);
			}else{
				anim.SetFloat("LastMoveY",0f);
			}



		
		
		} else {
			anim.SetBool ("walking", false);
		}
	}

}
