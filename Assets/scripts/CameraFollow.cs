using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject foco;

	public float minZoomDistance = -60f;
	public float maxZoomDistance = -4f;
	public float zoomSpeed = 1f;
	public float zoomSpeedMouseScrollZoomAxis = -10f;

	public float distance = -20f;

	void Update () {

		if(Input.GetAxis("Zoom") != 0){
			float zoomToAdd = Input.GetAxis("Zoom") * zoomSpeedMouseScrollZoomAxis * Time.deltaTime * -1;
			if(distance + zoomToAdd >= minZoomDistance && distance + zoomToAdd <= maxZoomDistance){
				distance += zoomToAdd;
			}
		}

		transform.position = new Vector3 (foco.transform.position.x, foco.transform.position.y, distance);
	}
}
