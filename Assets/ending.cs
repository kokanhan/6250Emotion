using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public GameObject player;
    public GameObject rock;
    private Collider rockTrigger;

    // Start is called before the first frame update
    void Start()
    {
        rockTrigger = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider end)
    {
        rock.transform.localPosition = new Vector3(-36.64f, 1.2f, 10.65f);
    }
}
