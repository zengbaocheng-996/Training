using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInstantiate : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        //// 在场景根节点创建物体
        //GameObject objA = Instantiate(prefab, null);
        //// 创建一个物体，作为当前脚本所在物体的子物体
        //GameObject objB = Instantiate(prefab, transform);
        //// 创建一个物体，指定它的位置和朝向
        //GameObject objC = Instantiate(prefab, new Vector3(3, 0, 3), Quaternion.identity);

        //// 创建10个物体围成环形
        //for(int i=0;i<10;i++)
        //{
        //    Vector3 pos = new Vector3(Mathf.Cos(i*(2*Mathf.PI)/10),0,Mathf.Sin(i*(2*Mathf.PI)/10));
        //    pos *= 5; // 圆环半径是5
        //    Instantiate(prefab, pos, Quaternion.identity);
        //}

        GameObject go = GameObject.Find("Cube");
        go.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
