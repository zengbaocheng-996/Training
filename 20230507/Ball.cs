using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("���ִ�п�ʼ������");
        //// ���彫����������Ҳ෽��X��������Ҳ��Ϊ���ң�ǰ��1.5����λ
        //transform.Translate(1.5f, 0, 0);
        //transform.position = new Vector3(1, 2.5f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("��ǰ��Ϸ����ʱ�䣺" + Time.time);
        //transform.Translate(0, 0, 0.1f);
        // ����������еȼ��ڣ�
        //transform.position += new Vector3(0, 0, 0.1f);
        //transform.Translate(0, 0, 5 * Time.deltaTime);
        //// ��
        //transform.position += new Vector3(0, 0, 5 * Time.deltaTime);
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        //Debug.Log("��ǰ��������" + v + "    " +"����"+h);
        //transform.Translate(h * 10 * Time.deltaTime, 0, v * 10 * Time.deltaTime);
        transform.Translate(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);
    }
}
