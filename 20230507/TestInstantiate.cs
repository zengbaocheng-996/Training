using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInstantiate : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        //// �ڳ������ڵ㴴������
        //GameObject objA = Instantiate(prefab, null);
        //// ����һ�����壬��Ϊ��ǰ�ű����������������
        //GameObject objB = Instantiate(prefab, transform);
        //// ����һ�����壬ָ������λ�úͳ���
        //GameObject objC = Instantiate(prefab, new Vector3(3, 0, 3), Quaternion.identity);

        //// ����10������Χ�ɻ���
        //for(int i=0;i<10;i++)
        //{
        //    Vector3 pos = new Vector3(Mathf.Cos(i*(2*Mathf.PI)/10),0,Mathf.Sin(i*(2*Mathf.PI)/10));
        //    pos *= 5; // Բ���뾶��5
        //    Instantiate(prefab, pos, Quaternion.identity);
        //}

        GameObject go = GameObject.Find("Cube");
        go.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
