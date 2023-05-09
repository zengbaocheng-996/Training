using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public GameObject gameObjectB;
    public GameObject gameObjectC;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 a = new Vector3(2, 1, 0);
        //Vector3 na = a / a.magnitude;
        //// a.magnitude����a�ĳ��ȣ����������a��ģ��
        //// ����д���ȼ��ڣ�
        //Vector3 na2 = a.normalized;
        //// ���ȼ��ڣ�
        //Vector3 na3=Vector3.Normalize(a);
        //// ���ȼ��ڣ�
        //Vector3 na4 = (1 / a.magnitude) * a;
        //Vector3 a = new Vector3(2, 1, 0);
        //Vector3 b = new Vector3(3, 0, 0);
        //Vector3 dir_b = b.normalized; // dir_b�Ǳ�׼��������b
        //float pa = Vector3.Dot(a, dir_b); // pa��������a������b�����ͶӰ��
        //Vector3 a = new Vector3(2, 1, 1);
        //Vector3 b = new Vector3(3, 0, 2);
        //Vector3 n = Vector3.Cross(a, b);
        //n = n.normalized;

        // ���ǵ�ǰ�����A����
        Vector3 p1 = transform.position;
        // ��������B������
        Vector3 p2 = gameObjectB.transform.position;
        // ���ǵ�ǰ����A��B������
        Vector3 diff = p2 - p1;
        //// �����һ���µ�����C��λ�ڱ�BԶ�뵱ǰ����Aһ����λ��
        //Vector3 p3 = p2 + diff;
        // ������C��λ�ô�����������A��B��λ�ƣ��õ��µ�����
        Vector3 p3 = gameObjectC.transform.position + diff;
        // ���������ĳ���Ϊһ��
        Vector3 diffHalf = diff * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
