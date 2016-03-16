using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    private float angle;
    private float speed = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        angle += 400 * Time.deltaTime * speed;
        transform.eulerAngles = new Vector3(0, 0, angle);
	}
}
