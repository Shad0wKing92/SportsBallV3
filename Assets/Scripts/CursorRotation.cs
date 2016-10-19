using UnityEngine;
using System.Collections;

public class CursorRotation : MonoBehaviour {

    public float speed;

	void Update () {
        this.transform.Rotate(0, Time.deltaTime * speed, 0);
	}
}
