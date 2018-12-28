using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    // Code supplied by teacher in session 4 w/b 13th February 2017

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // https://www.youtube.com/watch?v=6agwCUaMNWI accessed 21 february 2017, published 21st May 2015
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        // check if the mouse button is pressed
        if (Input.GetButtonDown("Fire1"))
        {
            //create a ray in the centre of this camera
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            // object comment
            RaycastHit hit;

            //The game engine will read if the raycast has hit the object and return true or false
            if (Physics.Raycast(ray, out hit))
            {
                //print the comment and destroy
                Debug.Log("OBJ:" + hit.transform.name);
                Destroy(hit.transform.gameObject);

            }

        }


    }
}
