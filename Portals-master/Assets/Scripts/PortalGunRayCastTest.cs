using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGunRayCastTest : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red);

            hit.collider.gameObject.GetComponent<MeshRenderer>();

            print("Material Name: " + hit.collider.gameObject.GetComponent<MeshRenderer>().material.name);
        }
    }
}
