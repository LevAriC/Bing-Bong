using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    public int paddleSpeed = 800;
    // private Vector3 paddlePosition = new Vector3(0, 0, 0);
	
	void Update () {
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * Time.deltaTime * paddleSpeed * -1);
    }
}


 
