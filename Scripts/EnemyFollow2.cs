using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow2 : MonoBehaviour
{

    // https://www.youtube.com/watch?v=T1hqJcHTVJI accessed 11th March, published september 27th 2015
    //https://www.youtube.com/watch?v=drTcfhULpLA&t=1s accessed 29th April, published 23rd February 2015
    //https://www.youtube.com/watch?v=188SMf9f6UY&t=3s acessed 29th april, published 23 June 2014

    public Transform target;
    public Transform myTransform;
    public float PlayerDistance;


    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}