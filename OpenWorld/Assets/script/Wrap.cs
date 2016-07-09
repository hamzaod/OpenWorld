using UnityEngine;
using System.Collections;

public class Wrap : MonoBehaviour {
    public Transform wrapTarget;



   
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("An object Collided");
        
    }

	
}
