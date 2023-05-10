using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    public float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", time);
    }

    private void OnDestroy()
    {
        Destroy(gameObject);
    }
}
