using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowMap1 : MonoBehaviour
{
    public GameObject miniMap1;

    public GameObject Sphere1;
    public GameObject Sphere2;
    public GameObject Sphere3;
    public GameObject Sphere4;

    void Start()
    {
        miniMap1.SetActive(false);

    }
}
