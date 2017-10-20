using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController2 : MonoBehaviour {

	public Text scoreLabel;

	private int score = 0;

	// Use this for initialization
	void Start () {

		score = 0;


		SetScore ();

	}
	
	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "SmallStarTag") {

			score += 5;

		} else if (collision.gameObject.tag == "LargeStarTag") {

			score += 20;

		} else if (collision.gameObject.tag == "SmallCloudTag") {

			score += 10;

		} else if (collision.gameObject.tag == "LargeCloudTag") {

			score += 30;
		}

		SetScore ();
	}

	void SetScore() {

		scoreLabel.text = "Score :" + score;
	}
}
