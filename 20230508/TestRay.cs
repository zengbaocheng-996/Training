using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// 创建从原点向上的射线
        //Ray ray = new Ray(Vector3.zero, Vector3.up);
        //// 获得当前鼠标指针在屏幕上的位置（单位是像素）
        //Vector2 mousePos = Input.mousePosition;
        //// 创建一条射线，起点是摄像机位置，方向指向鼠标指针所在的点（隐含了从屏幕到世界的坐标转换）
        //Ray ray2 = Camera.main.ScreenPointToRay(mousePos);
        //// 之后可以将ray或ray2发射出去，例如：
        //Physics.Raycast(ray, 10000, LayerMask.GetMask("Default"));
        int mask = LayerMask.GetMask("Ground", "Player", "Obstacle");
        mask = ~mask; // 英文波浪线，代表二进制取反
        gameObject.layer = LayerMask.NameToLayer("Default");
        if(Physics.Raycast(transform.position,Vector3.forward,mask))
        { 
            // 碰到了物体
        }
    }
    private void TestRayHit()
    {
        // 声明变量，用于保存碰撞信息
        RaycastHit hitInfo;
        // 发射射线，起点是当前物体的位置，方向是世界前方
        if(Physics.Raycast(transform.position,Vector3.forward,out hitInfo))
        {
            // 如果确实碰到物体，会运行到这里。没碰到物体就不会

            // 获取碰撞点的坐标（世界坐标）
            Vector3 point = hitInfo.point;
            // 获取对方的碰撞体组件
            Collider coll = hitInfo.collider;
            // 获取对方的Transform组件
            Transform trans = hitInfo.transform;
            // 获取对方的物体名称
            string name = coll.gameObject.name;
            // 获取碰撞点的法线向量
            Vector3 normal = hitInfo.normal;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
