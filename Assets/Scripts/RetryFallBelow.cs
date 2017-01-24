using UnityEngine;
using System.Collections;

public class RetryFallBelow : MonoBehaviour {
    private float minimumHeight = -10;
    private Vector3 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    if (transform.position.y < minimumHeight){
            transform.position = startPosition;
        }
	}
}
