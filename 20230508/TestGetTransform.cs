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
        // 有了Canvas，就可以用路径获得任意UI物体了
        Transform itemPanel = canvas.transform.Find("ItemPanel");
        //Transform rightLeg = transform.Find("Character1_Reference/Character1_Hips/Characterl_RightUpLeg");
        //Debug.Log("获得了" + rightLeg.gameObject.name);
        //Transform root = rightLeg.Find("../../..");
        //Debug.Log("从右腿回到第一层节点" + root.gameObject.name);
        //Transform leftLeg = rightLeg.Find("../Characterl_LeftUpLeg");
        //Debug.Log("从右腿触发找到左腿" + leftLeg.gameObject.name);
        //// 以下两种写法等价，p1与p2相同
        //Transform p1 = transform.parent;
        //Transform p2 = transform.Find("..");
        //// 用序号获取右腿
        //Transform hips = transform.Find("Character1_Reference/Characterl_Hips");
        //Transform rightLeg = hips.GetChild(1);
        //if(other!=null)
        //{
        //    Debug.Log("other 物体名称为 " + other.name);
        //}
        //else
        //{
        //    Debug.Log(" 未指定 other物体");
        //}
    }
    void Test()
    {
        for(int i=0;i<transform.childCount;i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            Debug.Log("第" + i + "个子物体名称为" + child.name);
            Debug.Log("它还有" + child.transform.childCount + "个下一级子物体");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
