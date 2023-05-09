using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            // 防止角色低头的代码
            Vector3 v= hit.point - transform.position;
            v.y = transform.position.y;
            transform.forward = v;
        }
    }
}
