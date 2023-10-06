using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAim : MonoBehaviour
{
	public float movementx;
	public float movementy;
    void Update () 
	{
		movementx = Input.GetAxisRaw("Horizontal");
        movementy = Input.GetAxisRaw("Vertical");

		if(movementx == -1) {
			transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,-180f));
		}
		else if(movementx == 1){
			transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,0f));
		}
		
		if(movementy == 1) {
			transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,-270f));
		}
		else if(movementy == -1){
			transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,-90f));
		}
	}
}
	
