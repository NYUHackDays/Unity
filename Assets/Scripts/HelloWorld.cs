using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour {

	public List<string> list = new List<string>();
	public float speed = 2f;

	// Use this for initialization
	void Start () {
		print (list [0] + " " + list [1]);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (speed, 0, transform.position.z) * Time.deltaTime);
	}
}
