using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	private Transform myTransform;
	public float RotateSpeed;

	// Use this for initialization
	void Start () {
		myTransform = this.GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {

		myTransform.eulerAngles += new Vector3 (0, 0, RotateSpeed * Time.deltaTime);
	
	}
}
