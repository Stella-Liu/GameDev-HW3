using UnityEngine;
using System.Collections;

public class CameraTrigger : MonoBehaviour {

	public CameraController controller;
	public int camNum;

	void OnTriggerEnter(Collider other){
		controller.DeactivateCameras();
		controller.activateCamera(camNum);
	}
}
