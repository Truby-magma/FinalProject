using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GameObject player;
    public DoorOpen pikadoor;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(
                gameObject.transform.position,
                player.transform.position) < 2 )
        {
            pikadoor.moveDown();

        }
    }
}
