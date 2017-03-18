using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Transform myTransform;
	// Use this for initialization
	void Start () {


		myTransform = this.GetComponent<Transform> ();
			
	}
	
	// Update is called once per frame
	void Update () {

		myTransform.eulerAngles = new Vector3 (0, 0, 0);
	
	}
}
