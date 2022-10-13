using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public Transform[] target;

    public float speed;

    private int current;
    // Start is called before the first frame update

    public bool StartMoving;

    private void Start()
    {
        StartMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            //GetComponent<Rigidbody>().MovePosition(pos);
            transform.position = pos;
        }
        else current = (current + 1) % target.Length;*/
        if (StartMoving == true)
        {

            if (transform.position != target[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
                //GetComponent<Rigidbody>().MovePosition(pos);
                transform.position = pos;
            }
            else if (current < target.Length - 1)
            {
                current++;
            }
        }

    }

    void OnTriggerStay(Collider target)
    {
        if (target.tag == "Player")
        {
            StartMoving = true;
        }
    }
}
