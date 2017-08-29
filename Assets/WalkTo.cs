using UnityEngine;
using System.Collections;

public class WalkTo : MonoBehaviour
{


    public Transform player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(player);
        transform.Translate(Vector3.forward * 8 * Time.deltaTime);
    }
}
