using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float speed;
	public float rotateSpeed;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update() {
		// mouse
		transform.Rotate(0, Input.GetAxis ("Mouse X") * rotateSpeed, 0);

		// movements
		/*if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += (-1 * transform.right) * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			transform.position += transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			transform.position += (-1 * transform.forward) * speed * Time.deltaTime;
		}*/

		// modify height
		if (Input.GetKey (KeyCode.Q)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.E)) {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}

	void LateUpdate () {
		//transform.position = new Vector3 (player.transform.position.x, 0, player.transform.position.z);
		transform.position = player.transform.position;
	}
}
