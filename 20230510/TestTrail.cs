using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrail : MonoBehaviour
{
    TrailRenderer trail;
    public Material mat1;
    public Material mat2;

    // Start is called before the first frame update
    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        trail.sharedMaterial = mat1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(trail.sharedMaterial==mat1)
            {
                trail.sharedMaterial = mat2;
                trail.startColor = Color.red;
                trail.endColor = Color.red;
            }
            else
            {
                trail.sharedMaterial = mat1;
                trail.startColor = Color.blue;
                trail.endColor = Color.blue;
            }
        }
    }
}
