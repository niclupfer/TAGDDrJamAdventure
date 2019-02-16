using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCat : MonoBehaviour
{
	public float mouseAngle;
	public float catAngle;

	public float angleSpeed;

	public GameObject mouse;
	public GameObject cat;

	public GameObject mouseGrabber;
	public GameObject catGrabber;

	public bool mouseGrabbing;
	public bool catGrabbing;

	public Vector3 mouseGrabSpot;
	public Vector3 catGrabSpot;

	void Start()
    {
        
    }

    void Update()
    {
		if (Input.GetKey (KeyCode.W)) {
			mouseAngle += angleSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			mouseAngle -= angleSpeed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			catAngle += angleSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			catAngle -= angleSpeed * Time.deltaTime;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (mouseGrabbing) {
				mouseGrabbing = false;

				mouseGrabber.GetComponent<SpriteRenderer> ().color = Color.white;
			} else {
				mouseGrabbing = true;
				mouseGrabSpot = mouseGrabber.transform.position;
				mouseGrabber.GetComponent<SpriteRenderer> ().color = Color.blue;
			}
		}


		mouse.transform.localEulerAngles = new Vector3 (0, 0, mouseAngle);
		cat.transform.localEulerAngles = new Vector3 (0, 0, catAngle);
    }

	void FixedUpdate()
	{
		if (mouseGrabbing) {
			mouseGrabber.transform.position = mouseGrabSpot;
		}

			
	}
}
