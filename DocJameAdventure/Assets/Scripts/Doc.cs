using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Doc : MonoBehaviour
{
	public float speed;

	Rigidbody rb;

    void Start()
    {
		rb = GetComponent<Rigidbody> ();

    }

    void Update()
    {
		var vert = Input.GetAxis ("Vertical");
		var horz = Input.GetAxis ("Horizontal");

		var posDelta = (new Vector3 (horz, 0, vert)).normalized * speed * Time.deltaTime;

		//transform.position += posDelta;
		rb.MovePosition(transform.position + posDelta);

		if (Input.GetKeyDown (KeyCode.E))
			Whatever ();
    }

	void Whatever()
	{
		GetComponentInChildren<MeshRenderer> ().material.color = Color.red;
	}
}
