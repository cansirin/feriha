using UnityEngine;
using System.Collections;


public class controller : MonoBehaviour {
	public int movementspeed;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.localEulerAngles = new Vector3(0,270,0);
			transform.Translate (transform.right * movementspeed * Time.deltaTime); 

		}
		else if(Input.GetKey (KeyCode.D)) {
			transform.localEulerAngles = new Vector3(0,90,0);
			transform.Translate (transform.right *(-1)* movementspeed * Time.deltaTime); 
		}
		else if (Input.GetKey (KeyCode.W)) {
			transform.localEulerAngles = new Vector3(0,0,0);
			transform.Translate (transform.forward * movementspeed * Time.deltaTime); 
		}
		else if(Input.GetKey (KeyCode.S)) {
			transform.localEulerAngles = new Vector3(0,180,0);
			transform.Translate (transform.forward * (-1) * movementspeed * Time.deltaTime);
		}
	}
}