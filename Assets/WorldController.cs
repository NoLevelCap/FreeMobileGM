using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

	private float mod = 360f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.forward, mod * Time.deltaTime, Space.Self);
		} else if(Input.GetKey(KeyCode.D)){
			transform.Rotate (Vector3.forward, -mod * Time.deltaTime, Space.Self);
		} else if (Input.GetKey (KeyCode.W)) {
			transform.Rotate (Vector3.right, -mod * Time.deltaTime, Space.World);
		} else if(Input.GetKey(KeyCode.S)){
			transform.Rotate (Vector3.right, mod * Time.deltaTime, Space.World);
		}
	}
}
