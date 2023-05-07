using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    SphereCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        //// 获取到组件后，将它的引用保存在collider字段中，方便下次使用
        //collider = gameObject.GetComponent<SphereCollider>();
        //// 以下每一句写法均与上面一句等价
        //collider = this.GetComponent<SphereCollider>();
        //collider = GetComponent<SphereCollider>(); // 同上，省略了this
        //collider = transform.GetComponent<SphereCollider>(); // 通过transform组件获得其他组件
        //collider = transform.GetComponent<MeshRenderer>().GetComponent<SphereCollider>();
        //collider = transform.GetComponent<SphereCollider>().GetComponent<SphereCollider>();
        //// 多此一举的写法，但是结果也正确
        collider = GetComponent<SphereCollider>();
        // 获取到所有的脚本组件，放在数组中
        Test[] tests = GetComponents<Test>();
        Debug.Log(" 共有 " + tests.Length + " 个Test脚本组件");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
