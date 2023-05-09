using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public GameObject gameObjectB;
    public GameObject gameObjectC;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 a = new Vector3(2, 1, 0);
        //Vector3 na = a / a.magnitude;
        //// a.magnitude就是a的长度，术语叫做“a的模”
        //// 以上写法等价于：
        //Vector3 na2 = a.normalized;
        //// 还等价于：
        //Vector3 na3=Vector3.Normalize(a);
        //// 还等价于：
        //Vector3 na4 = (1 / a.magnitude) * a;
        //Vector3 a = new Vector3(2, 1, 0);
        //Vector3 b = new Vector3(3, 0, 0);
        //Vector3 dir_b = b.normalized; // dir_b是标准化的向量b
        //float pa = Vector3.Dot(a, dir_b); // pa即是向量a在向量b方向的投影长
        //Vector3 a = new Vector3(2, 1, 1);
        //Vector3 b = new Vector3(3, 0, 2);
        //Vector3 n = Vector3.Cross(a, b);
        //n = n.normalized;

        // 这是当前物体的A坐标
        Vector3 p1 = transform.position;
        // 这是物体B的坐标
        Vector3 p2 = gameObjectB.transform.position;
        // 这是当前物体A到B的向量
        Vector3 diff = p2 - p1;
        //// 获得了一个新的坐标C，位于比B远离当前物体A一倍的位置
        //Vector3 p3 = p2 + diff;
        // 从物体C的位置触发，发生从A到B的位移，得到新的坐标
        Vector3 p3 = gameObjectC.transform.position + diff;
        // 调整向量的长度为一半
        Vector3 diffHalf = diff * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
