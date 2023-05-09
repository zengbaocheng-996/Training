using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuatTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //float v = Input.GetAxis("Vertical");
        //float h = Input.GetAxis("Horizontal");
        //// 将横向输入转化为左右旋转，将纵向输入转化为俯仰旋转，得到一个很小的旋转四元数
        //Quaternion smallRotate = Quaternion.Euler(v, h, 0);
        //// 将这个小的旋转叠加到当前旋转位置上
        //if (Input.GetButton("Fire1"))
        //{
        //    Debug.Log("sss");
        //    // 按住鼠标左键或Ctrl键，沿世界坐标轴旋转
        //    transform.rotation = smallRotate * transform.rotation;
        //}
        //else
        //{
        //    // 不按鼠标左键和Ctrl键时，沿局部坐标轴旋转
        //    transform.rotation = transform.rotation * smallRotate;
        //}

        // 前方
        Quaternion q = Quaternion.identity; // identity 相当于Eular(0,0,0),不旋转
        // 改变物体的朝向，取当前朝向与正前方之间10%的位置
        transform.rotation = Quaternion.Slerp(transform.rotation, q, 0.1f);
    }
}
