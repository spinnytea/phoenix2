using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Simply demo script for rotating a thing */
public class Rotate : MonoBehaviour
{
	public GameObject target;

    // if you want to play with these in the editor,
    // then change these from readonly to public
    [Range(0f, 0.5f)]
	public float speed = 0.125f;
    readonly bool x = false;
    readonly bool y = true;
    readonly bool z = false;

    void Update()
	{
		if(target) {
			float delta = Time.deltaTime;

            if (x) target.transform.Rotate(Vector3.left * delta * speed * 360f);
            if (y) target.transform.Rotate(Vector3.up * delta * speed * 360f);
            if (z) target.transform.Rotate(Vector3.forward * delta * speed * 360f);
        }
    }
}
