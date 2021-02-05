using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderScript : MonoBehaviour
{

    public GameObject PortalTrigger1;
    public GameObject PortalTrigger2;
    public GameObject Wallrooffloor1;
    public GameObject Wallrooffloor2;

    void OnTriggerEnter(Collider other)
    {
        PortalTrigger1.GetComponent<BoxCollider>().enabled = true;
        PortalTrigger2.GetComponent<BoxCollider>().enabled = true;
        Wallrooffloor1.GetComponent<MeshCollider>().enabled = false;
        Wallrooffloor2.GetComponent<MeshCollider>().enabled = false;
    }

    void Start()
    {
        PortalTrigger1.GetComponent<BoxCollider>().enabled = true;
        PortalTrigger2.GetComponent<BoxCollider>().enabled = true;
        Wallrooffloor1.GetComponent<MeshCollider>().enabled = true;
        Wallrooffloor2.GetComponent<MeshCollider>().enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        PortalTrigger1.GetComponent<BoxCollider>().enabled = true;
        PortalTrigger2.GetComponent<BoxCollider>().enabled = true;
        Wallrooffloor1.GetComponent<MeshCollider>().enabled = true;
        Wallrooffloor2.GetComponent<MeshCollider>().enabled = true;
    }

}
