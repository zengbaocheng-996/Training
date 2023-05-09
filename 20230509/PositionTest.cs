using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// 当前物体的世界坐标系位置
        //Vector3 worldPos = transform.position;
        //Debug.Log("World Pos:" + worldPos);
        //// 当前物体相对父物体的位置
        //Vector3 localPos = transform.localPosition;
        //Debug.Log("Local Pos:" + localPos);
        //// 旋转
        //Quaternion worldRotation = transform.rotation;
        //Quaternion localRotation = transform.localRotation;
        //// 在父物体局部坐标系下的缩放。无法直接获得世界坐标系的缩放
        //Vector3 localScale = transform.localScale;
        //// 物体向着世界上方移动一米
        //transform.position += Vector3.up;
        //// 物体向自身的上方移动一米
        //transform.Translate(Vector3.up);
        //// 上面一句代码等价于下面这句
        //transform.position += transform.up;
        //// 错误的写法会导致计算结果意义不明
    }

    // Update is called once per frame
    void Update()
    {
        // 鼠标指针位置是屏幕坐标系
        Vector2 mousePos = Input.mousePosition;
        Debug.Log("鼠标指针在 屏幕上的位置：" + mousePos);
        // 将鼠标指针位置转化为视图坐标系时，需要利用摄像机计算
        Vector3 viewPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Debug.Log("鼠标指针位置的视图坐标为：" + viewPoint);
    }
}
