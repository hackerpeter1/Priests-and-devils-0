using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {
    public Transform target;
    public float speed = 1.0f;
    private float rx, ry;
	// Use this for initialization
	void Start () {
        rx = Random.Range(10, 20);
        ry = Random.Range(80, 90);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 axis = new Vector3(rx,ry,0);
        this.transform.RotateAround(target.position, axis, Time.deltaTime * 5 * speed);
	}
}
