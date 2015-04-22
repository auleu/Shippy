using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject foco;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (foco.transform.position.x, foco.transform.position.y, transform.position.z);
	}
}
