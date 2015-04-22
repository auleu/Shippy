using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {

	public float minZoomDistance = 6f;
	public float maxZoomDistance = 15f;
	public float zoomSpeed = 1f;
	public float zoomSpeedMouseScrollZoomAxis = 100f;

	public float distance = 10f;

	void Update () {
		if(Input.GetAxis("Zoom") != 0){
			float zoomToAdd = Input.GetAxis("Zoom") * zoomSpeedMouseScrollZoomAxis * Time.deltaTime * -1;
			if(distance + zoomToAdd >= minZoomDistance && distance + zoomToAdd <= maxZoomDistance){
				distance += zoomToAdd;
			}
		}
	}
}
