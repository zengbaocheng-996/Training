using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("组件执行开始函数！");
        //// 物体将沿着自身的右侧方向（X轴正方向也称为向右）前进1.5个单位
        //transform.Translate(1.5f, 0, 0);
        //transform.position = new Vector3(1, 2.5f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("当前游戏进行时间：" + Time.time);
        //transform.Translate(0, 0, 0.1f);
        // 在这个例子中等价于：
        //transform.position += new Vector3(0, 0, 0.1f);
        //transform.Translate(0, 0, 5 * Time.deltaTime);
        //// 或
        //transform.position += new Vector3(0, 0, 5 * Time.deltaTime);
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        //Debug.Log("当前输入纵向：" + v + "    " +"横向："+h);
        //transform.Translate(h * 10 * Time.deltaTime, 0, v * 10 * Time.deltaTime);
        transform.Translate(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);
    }
}
