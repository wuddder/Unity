using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour {


	private Text text;
	private int _score = 0;
	const string ScorePrefix = "Score : ";


	// Use this for initialization
	void Start () {
	
		text = this.GetComponent<Text> ();
		text.text = ScorePrefix + _score;
	}

	public void AddScore(int score)
	{

		_score += score;

		text.text = ScorePrefix + _score;

	}

	// Update is called once per frame
	void Update () {


	
	}
}
