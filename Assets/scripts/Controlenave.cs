using UnityEngine;
using System.Collections;

public class Controlenave : MonoBehaviour {
	float dir=0;
	float lift=0;
	Rigidbody2D Rgd;
	// Use this for initialization
	void Start () {
		Rgd = GetComponent<Rigidbody2D> ();
		lift = 9;
		Rgd.centerOfMass = new Vector2 (0, 0);

	}
	
	// Update is called once per frame
	void Update () {
		dir = Input.GetAxis ("Horizontal");
		lift = Input.GetAxis ("Vertical")*11;
		lift = Mathf.Clamp (lift, 0, 11);
		Debug.Log (lift);
	}
	void FixedUpdate () {
		Rgd.AddRelativeForce (new Vector2 (0, lift));
		Rgd.AddTorque (dir * -15f);
		float ang = Vector2.Angle (transform.right, Vector2.up);
		//Rgd.AddTorque ((ang - 90)*0.025f);
	}
}