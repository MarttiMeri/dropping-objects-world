using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGettingFar : MonoBehaviour {

	private float x,y,z,x0,y0,z0;
	private int round;
	// Use this for initialization
	void Start () {
		round = 0;
		x0 = gameObject.transform.localPosition.x;
		y0 = gameObject.transform.localPosition.y;
		z0 = gameObject.transform.localPosition.z;
	}

	// Update is called once per frame
	void Update () {
		x = gameObject.transform.localPosition.x;
		y = gameObject.transform.localPosition.y;
		z = gameObject.transform.localPosition.z;
		//		if (Mathf.Abs (x0 - x) > 100.0  || Mathf.Abs (y0 - y) > 100.0 || Mathf.Abs (z0 - z) > 100.0) {

		if (y <  -10.0) {
			round++;
			if (round == 1) {
				gameObject.transform.localPosition = new Vector3(x0, y0, z0);
			} else {				
				Application.Quit();
			}
		}
	}
}