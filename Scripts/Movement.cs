using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


    public int rot_speed = 30;
    
    private new Rigidbody rigidbody
    {
        get { return GetComponent<Rigidbody>(); }
    }
    // Use this for initialization
    void Start () {
       
	
	}
	
	// Update is called once per frame
	void Update () {


        // Code written in session w/b 30th january 2017
        // pc controls for the movement of the character

        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward * 20 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(-Vector3.forward * 20 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -rot_speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, rot_speed * Time.deltaTime, 0));
        } 
       

    }
}
