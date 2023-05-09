using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoorindateWorld : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.InverseTransformDirection(Vector3.forward);
        transform.Translate(v * Time.deltaTime);
    }
}
