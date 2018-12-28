using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

    // https://www.youtube.com/watch?v=T1hqJcHTVJI accessed 11th March, published september 27th 2015
    //https://www.youtube.com/watch?v=drTcfhULpLA&t=1s accessed 29th April, published 23rd February 2015
    //https://www.youtube.com/watch?v=188SMf9f6UY&t=3s acessed 29th april, published 23 June 2014
    // https://www.youtube.com/watch?v=1mw1ufZq1N4&list=PLbghT7MmckI4IeNHkPm5bFJhY9GQ0anKN&index=5 accessed 31st april , published 15th november 2014

    public Transform target;
    public Transform myTransform;
    public float PlayerDistance;
    public float delay = 1f;
    float cooldownTimer = 0f;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        //count down the time for every second in game.
        cooldownTimer -= Time.deltaTime;

        PlayerDistance = Vector3.Distance(target.position, transform.position);

        if(PlayerDistance < 7.5f && cooldownTimer <= 0)
        {
            // cast the raycast and reset the timer to 1 second.
            attack();
            cooldownTimer = delay;
        }


        transform.LookAt(target);
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    void attack()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            // if the raycast is touching a collider with a tag called player
            if (hit.collider.gameObject.tag == "Player")
            {
                //the raycast will read the script of the colliding object and subtract its health
                hit.collider.gameObject.GetComponent<PlayerHealth>().health -= 1f;
            }
        }
    }
}
