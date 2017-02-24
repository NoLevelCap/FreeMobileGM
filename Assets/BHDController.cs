using UnityEngine;
using System.Collections;

public class BHDController : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick(){
		anim.SetBool ("Present", !anim.GetBool ("Present"));
	}
}
