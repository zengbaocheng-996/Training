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
        //// ����������ת��Ϊ������ת������������ת��Ϊ������ת���õ�һ����С����ת��Ԫ��
        //Quaternion smallRotate = Quaternion.Euler(v, h, 0);
        //// �����С����ת���ӵ���ǰ��תλ����
        //if (Input.GetButton("Fire1"))
        //{
        //    Debug.Log("sss");
        //    // ��ס��������Ctrl������������������ת
        //    transform.rotation = smallRotate * transform.rotation;
        //}
        //else
        //{
        //    // ������������Ctrl��ʱ���ؾֲ���������ת
        //    transform.rotation = transform.rotation * smallRotate;
        //}

        // ǰ��
        Quaternion q = Quaternion.identity; // identity �൱��Eular(0,0,0),����ת
        // �ı�����ĳ���ȡ��ǰ��������ǰ��֮��10%��λ��
        transform.rotation = Quaternion.Slerp(transform.rotation, q, 0.1f);
    }
}
