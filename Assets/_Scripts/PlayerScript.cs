using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed;
	private int score;
	public Text scoreText;
	public Text winText;

	// Use this for initialization
	void Start () {
		score = 0;
		setScore (score);
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += (-1 * Camera.main.transform.right) * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			transform.position += Camera.main.transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			transform.position += Camera.main.transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			transform.position += (-1 * Camera.main.transform.forward) * speed * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Snowflake")) {
			other.gameObject.SetActive(false);
			setScore (++score);
			if (score == 6) {
				winText.text = "You won by staying cool with snowflakes and defeating summer!";
			}
		}
	}

	void setScore(int count) {
		scoreText.text = "Score: " + count.ToString ();
	}
}
