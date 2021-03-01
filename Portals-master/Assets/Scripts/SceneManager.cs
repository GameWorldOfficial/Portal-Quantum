using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;

    public void QOne()
    {
        Q1.SetActive(true);
    }

    public void QTwo()
    {
        Q2.SetActive(true);
    }

    public void QThree()
    {
        Q3.SetActive(true);
    }

    public void Qfour()
    {
        Q4.SetActive(true);
    }

    public void Qfive()
    {
        Q5.SetActive(true);
    }

    public void Qsix()
    {
        Q6.SetActive(true);
    }

}
