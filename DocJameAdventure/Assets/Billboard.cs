using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
	Camera cam;

    void Start()
    {
		cam = Camera.main;
    }

    void Update()
    {
		var flatPos = cam.transform.position;
		flatPos.y = 0;

		var myFlatPos = new Vector3(transform.position.x, 0, transform.position.z);

		var angle = Vector3.Angle (flatPos, myFlatPos);
		transform.eulerAngles = new Vector3 (0, angle, 0);

		//transform.LookAt (flatPos);
    }
}
