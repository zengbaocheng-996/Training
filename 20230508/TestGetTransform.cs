using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGetTransform : MonoBehaviour
{
    //public GameObject other;
    //public Transform otherTrans;
    //public MeshFilter otherMesh;
    //public Rigidbody otherRigid;
    // Start is called before the first frame update
    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        // ����Canvas���Ϳ�����·���������UI������
        Transform itemPanel = canvas.transform.Find("ItemPanel");
        //Transform rightLeg = transform.Find("Character1_Reference/Character1_Hips/Characterl_RightUpLeg");
        //Debug.Log("�����" + rightLeg.gameObject.name);
        //Transform root = rightLeg.Find("../../..");
        //Debug.Log("�����Ȼص���һ��ڵ�" + root.gameObject.name);
        //Transform leftLeg = rightLeg.Find("../Characterl_LeftUpLeg");
        //Debug.Log("�����ȴ����ҵ�����" + leftLeg.gameObject.name);
        //// ��������д���ȼۣ�p1��p2��ͬ
        //Transform p1 = transform.parent;
        //Transform p2 = transform.Find("..");
        //// ����Ż�ȡ����
        //Transform hips = transform.Find("Character1_Reference/Characterl_Hips");
        //Transform rightLeg = hips.GetChild(1);
        //if(other!=null)
        //{
        //    Debug.Log("other ��������Ϊ " + other.name);
        //}
        //else
        //{
        //    Debug.Log(" δָ�� other����");
        //}
    }
    void Test()
    {
        for(int i=0;i<transform.childCount;i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            Debug.Log("��" + i + "������������Ϊ" + child.name);
            Debug.Log("������" + child.transform.childCount + "����һ��������");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
