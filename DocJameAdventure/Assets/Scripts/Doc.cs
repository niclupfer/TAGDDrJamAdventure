using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Doc : MonoBehaviour
{
	public float speed;

	public GameObject visual;

	Rigidbody rb;

	float goalAngle;
	float currentAngle;
	public float turnSmoothing;

    void Start()
    {
		rb = GetComponent<Rigidbody> ();
		currentAngle = 0;
		goalAngle = 0;
    }

    void FixedUpdate()
	{
		var vert = Input.GetAxis ("Vertical");
		var horz = Input.GetAxis ("Horizontal");

		var vec = (new Vector3 (horz, 0, vert)).normalized;

		var posDelta = vec * speed * Time.deltaTime;

		//transform.position += posDelta;
		rb.MovePosition (transform.position + posDelta);

		if (vec.magnitude > 0)
		{
			goalAngle = Mathf.Atan2 (horz, vert) * Mathf.Rad2Deg;
			currentAngle = Mathf.Lerp (currentAngle, goalAngle, turnSmoothing * Time.deltaTime);
			visual.transform.localEulerAngles = new Vector3 (0, currentAngle, 0);
		}

	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.E))
			Whatever ();
    }

	void Whatever()
	{
		//GetComponentsInChildren<MeshRenderer> ().material.color = Color.red;
	}
}
