using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIter2 : MonoBehaviour
{
    IEnumerator<int> HelloWorld()
    {
        transform.position = new Vector3(1, 0, 0);
        yield return 1;
        transform.position = new Vector3(2, 0, 0);
        yield return 2;
        transform.position = new Vector3(3, 0, 0);
        yield return 1;
    }
    IEnumerator<int> e;
    float helloTime = 0;

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
            if(Time.time>helloTime)
            {
                if(!e.MoveNext())
                {
                    // 协程结束了
                    e = null;
                    return;
                }
            Debug.Log("yield返回值：" + e.Current);
            // 把返回值当作延迟的时间
            helloTime = Time.time + e.Current;
            }
        }
    }
}
