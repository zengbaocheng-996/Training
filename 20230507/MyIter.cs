using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIter : MonoBehaviour
{
    IEnumerator<int> HelloWorld()
    {
        transform.position = new Vector3(1, 0, 0);
        yield return 233;
        transform.position = new Vector3(2, 0, 0);
        yield return 234;
        transform.position = new Vector3(3, 0, 0);
        yield return 666;
    }
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator<int> e = HelloWorld();
        while(true)
        {
            if(!e.MoveNext())
            {
                break;
            }
            Debug.Log("yield返回值：" + e.Current);
            Debug.Log("物体当前位置：" + transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
