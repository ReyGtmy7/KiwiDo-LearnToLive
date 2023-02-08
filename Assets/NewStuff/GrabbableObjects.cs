using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        tag = "grabbableObjects";

    }

    // Update is called once per frame
    void Update()
    {
        //if(INput)
        Collider[] colliders = Physics.OverlapSphere(transform.position, 3);

        for (int i = 0; i < colliders.Length; i++)
        {
            if(colliders[i].name == "PlayerCapsule")
            {

            }
        }
    }
}
