using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGetGameObject : MonoBehaviour
{
    GameObject objMainCam;
    GameObject objMainLight;
    // Start is called before the first frame update
    void Start()
    {
        objMainCam = GameObject.Find("Main Camera");
        objMainLight = GameObject.Find("Directional Light");
        Debug.Log("主摄像机：" + objMainCam.name);
        Debug.Log("主光源：" + objMainLight.name);
        // 将主摄像机放在这个物体后方1米的位置
        objMainCam.transform.position = transform.position - transform.forward;

        // 查找第一个标签为Player的物体
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        // 查找所有标签为Monster的物体，注意返回值是一个数组，结果可以是0个或多个
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");

        // 获得某个Player物体
        GameObject m = GameObject.FindGameObjectWithTag("Player");
        // 将它的标签设置为Cube
        m.tag = "Cube";
        // 判断m的标签是不是Cube
        if (m.CompareTag("Cube")) 
        {
        }
        // 上面的CompareTag用法等价于m.tag=="Cube",推荐使用CompareTag
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
