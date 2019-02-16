using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject target;
	public float smoothing;

	void Start()
    {
        
    }

    void FixedUpdate()
    {
		if (target != null) {
			var pos = target.transform.position;

			transform.position =
				Vector3.Lerp (transform.position,
					pos, smoothing * Time.deltaTime);
		}
    }
}
