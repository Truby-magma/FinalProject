using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{

    public Transform player;
    public Animator myAnimator;
    public float d;

    public Vector3 pdist;
    public Vector3 zdist;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myAnimator = GetComponent<Animator>();
        pdist = player.GetComponent<Transform>().position;
        zdist = transform.position;
        float dist = Vector3.Distance(pdist, zdist);
        d = dist;
        if (dist < 8)
        {
            Debug.Log("CLOSE ENOUGH");
            myAnimator.SetBool("CloseEnough", true);
        }
        else
        {
            Debug.Log("TOO FAR");
            myAnimator.SetBool("CloseEnough", false);
        }
    }

}
