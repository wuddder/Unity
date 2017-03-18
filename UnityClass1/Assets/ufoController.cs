using UnityEngine;
using System.Collections;

public class ufoController : MonoBehaviour {


	private int counter = 0;
	private Transform myTransform;
	private Rigidbody2D myRigibody2D;
	public ScoreManager scoreManager;


	// Use this for initialization
	void Start () {

		Debug.Log ("Start");
		myTransform = this.GetComponent<Transform> ();
		myRigibody2D = this.GetComponent<Rigidbody2D> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.name);
		other.gameObject.SetActive (false);
		scoreManager.AddScore (100);
	}


	public float speed = 10;
	public float forceValue;


	// Update is called once per frame
	void Update () {

//		Debug.Log ("Update " + counter++);
		if (Input.GetKey (KeyCode.W)) {
//			myTransform.position += new Vector3 (0, speed * Time.deltaTime, 0);
			myRigibody2D.AddForce(new Vector2(0,forceValue));
		}
		else if (Input.GetKey (KeyCode.S)) {
//			myTransform.position += new Vector3 (0, -speed * Time.deltaTime, 0);
			myRigibody2D.AddForce(new Vector2(0,-forceValue));
		}
		else if (Input.GetKey (KeyCode.A)) {
//			myTransform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
			myRigibody2D.AddForce(new Vector2(-forceValue,0));
		}
		else if (Input.GetKey (KeyCode.D)) {
//			myTransform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
			myRigibody2D.AddForce(new Vector2(forceValue,0));
		}
	
	}
}
