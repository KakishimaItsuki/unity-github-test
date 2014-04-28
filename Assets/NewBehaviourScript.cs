using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello!");

	}
	
	// Update is called once per frame
	void Update () {
		this.rigidbody.AddForce (new Vector3 (10, 0, 0));
	}
}
