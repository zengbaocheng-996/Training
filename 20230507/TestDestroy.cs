using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDestroy : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // 创建20个物体围成环形
        for (int i=0;i<20;i++)
        {
            Vector3 pos = new Vector3(Mathf.Cos(i * (2 * Mathf.PI) / 20), 0,Mathf.Sin(i * (2 * Mathf.PI) / 20));
            pos *= 5; // 圆环半径是5
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            GameObject cube = GameObject.Find("Cube(Clone)");
            Destroy(cube);
        }
    }
}
