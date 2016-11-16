using UnityEngine;
using System.Collections;

public class RubeGoldberg : MonoBehaviour {

	private Transform myTransform;
	private float moveSpeed;

	// Use this for initialization
	void Start () {
		moveSpeed = 2;
		myTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		 if(Input.GetKey(KeyCode.Space)){
		// 	//Start the machine
		 	myTransform.position += transform.right * Time.deltaTime * moveSpeed;
		 }	
	}
}
