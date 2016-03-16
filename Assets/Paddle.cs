using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    public int paddleSpeed = 100;
    private Vector3 paddlePosition = new Vector3(0, 0, 0);
	
	void Update () {
        float zPos = transform.rotate + (Input.GetAxis("Horizontal") * paddleSpeed);
        //   paddlePosition = new Vector3(0, 0, zPos);
        //   transform.position = paddlePosition;
        transform.Rotate(new Vector3(0, 0, paddleSpeed));
	}
}
