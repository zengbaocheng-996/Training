using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // 触发开始事件OnTriggerEnter，参数为碰撞体信息，即另一个进入了该触发区域的物体的碰撞体
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " 碰到了我");
        // 销毁自己
        Destroy(gameObject);
    }
}
