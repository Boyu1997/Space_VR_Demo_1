using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public Text infoText;

	public float speed;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		Physics.gravity = new Vector3(0, -0.2F, 0);
		infoText.text = "";
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Toilet")) {
			infoText.text = "This is a space toilet!";
		}
	}

	void OnTriggerExit(Collider other) {
		infoText.text = "";
	}
}
