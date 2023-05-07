using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInvoke : MonoBehaviour
{
    public GameObject prefab;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreatePrefab", 0.5f);
    }

    void CreatePrefab()
    {
        Vector3 pos = new Vector3(Mathf.Cos(counter *(2 * Mathf.PI)/ 10), 0, Mathf.Sin(counter * (2 * Mathf.PI) / 10));
        pos *= 5; // Ô²»·°ë¾¶ÊÇ5
        Instantiate(prefab, pos, Quaternion.identity);
        counter++;
        if(counter<10)
        {
            Invoke("CreatePrefab",0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            GameObject cube = GameObject.Find("Cube(Clone)");
            // Destroy(cube);
            Destroy(cube, 0.8f);
            cube.AddComponent<Rigidbody>();
        }
    }
}
