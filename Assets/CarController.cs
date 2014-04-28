using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class CarController : MonoBehaviour {

	public float Accleration = 10f;
	public float HandleSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate(){
		float v = Input.GetAxisRaw ("Vertical");
		float h = Input.GetAxisRaw ("Horizontal");

		if (rigidbody.detectCollisions){
			// rotation
			Vector3 rotateDirection = transform.TransformDirection(Vector3.up * h);
			rigidbody.angularVelocity = rotateDirection * HandleSpeed;

			// accleration
			Vector3 forceDirection = transform.TransformDirection(Vector3.forward * v);
			rigidbody.AddForce (forceDirection * Accleration);
		}
	}
}
