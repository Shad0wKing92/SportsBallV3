using UnityEngine;
using System.Collections;

public class ControllerTestInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxis("Horizontal") >= -1 || Input.GetAxis("Horizontal") <= 1)
        {
            Debug.Log("Hor: " + Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Vertical") >= -1 || Input.GetAxis("Vertical") <= 1)
        {
            Debug.Log("Ver: " + Input.GetAxis("Vertical"));
        }

        if (Input.anyKeyDown)
        {
            for (int i = 0; i < 20; i++)
            {
                if (Input.GetKeyDown("joystick 1 button " + i))
                {
                    print("joystick 1 button " + i);
                }
            }
        }
	}
}
