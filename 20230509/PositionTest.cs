using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// ��ǰ�������������ϵλ��
        //Vector3 worldPos = transform.position;
        //Debug.Log("World Pos:" + worldPos);
        //// ��ǰ������Ը������λ��
        //Vector3 localPos = transform.localPosition;
        //Debug.Log("Local Pos:" + localPos);
        //// ��ת
        //Quaternion worldRotation = transform.rotation;
        //Quaternion localRotation = transform.localRotation;
        //// �ڸ�����ֲ�����ϵ�µ����š��޷�ֱ�ӻ����������ϵ������
        //Vector3 localScale = transform.localScale;
        //// �������������Ϸ��ƶ�һ��
        //transform.position += Vector3.up;
        //// ������������Ϸ��ƶ�һ��
        //transform.Translate(Vector3.up);
        //// ����һ�����ȼ����������
        //transform.position += transform.up;
        //// �����д���ᵼ�¼��������岻��
    }

    // Update is called once per frame
    void Update()
    {
        // ���ָ��λ������Ļ����ϵ
        Vector2 mousePos = Input.mousePosition;
        Debug.Log("���ָ���� ��Ļ�ϵ�λ�ã�" + mousePos);
        // �����ָ��λ��ת��Ϊ��ͼ����ϵʱ����Ҫ�������������
        Vector3 viewPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Debug.Log("���ָ��λ�õ���ͼ����Ϊ��" + viewPoint);
    }
}
