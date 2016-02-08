using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Camera fps_camera;
	public Camera god_camera;

	public GameObject player;
	public float speed;
	public float rotateSpeed;

	void Start () {
		fps_camera.enabled = true;
		god_camera.enabled = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update() {
		// modify height
		if (fps_camera.isActiveAndEnabled) {
			if (Input.GetKey (KeyCode.Q)) {
				Camera.main.transform.position += Vector3.up * speed * Time.deltaTime;
			}
			if (Input.GetKey (KeyCode.E)) {
				Camera.main.transform.position += Vector3.down * speed * Time.deltaTime;
			}
		}

		// switch cameras
		if (Input.GetKeyDown (KeyCode.Z)) {
			fps_camera.enabled = !fps_camera.enabled;
			god_camera.enabled = !god_camera.enabled;
		}
	}

	void LateUpdate() {
		if (fps_camera.isActiveAndEnabled) {
			Camera.main.transform.Rotate (0, Input.GetAxis ("Mouse X") * rotateSpeed, 0);
		}
	}
}
