using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIter3 : MonoBehaviour
{
    IEnumerator<int> HelloWorld()
    {
        // 局部变量的值会被保留
        float helloTime = 0;
        transform.position = new Vector3(1, 0, 0);
        // 延时1秒
        helloTime = Time.time + 1;
        while(Time.time<helloTime)
        {
            // 这个返回值没有用到
            yield return 1;
        }

        transform.position = new Vector3(2, 0, 0);
        // 延时2秒
        helloTime = Time.time + 2;
        while(Time.time<helloTime)
        {
            // 这个返回值没有用到
            yield return 2;
        }

        transform.position = new Vector3(3, 0, 0);
        helloTime = Time.time + 1;
        while (Time.time < helloTime)
        {
            yield return 1;
        }
    }
    IEnumerator<int> e;
    // Start is called before the first frame update
    void Start()
    {
        e = HelloWorld();
    }

    // Update is called once per frame
    void Update()
    {
        if(e!=null)
        {
            if(!e.MoveNext())
            {
                // 协程结束了
                e = null;
                return;
            }
        }
    }
}
