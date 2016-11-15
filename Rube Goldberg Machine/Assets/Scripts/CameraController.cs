using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject[] Cameras;
	private int currentCam;

	// Use this for initialization
	void Start () {
	//	DeactivateCameras();
	//	Cameras[0].SetActive(true);
	//	currentCam = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//public void activateCamera(int camNum){
		//	Cameras[camNum - 1].SetActive(true);
		//	currentCam = camNum - 1;
		//}

		//public void DeactivateCameras(){
		//	for(int i = 0; i < Cameras.Length; i++){
		//		Cameras[i].SetActive(false);
		//	}	
		//}
	}
}
