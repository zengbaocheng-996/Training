using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResources : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*---加载资源---*/
        // 预制体资源用GameObject类型表示，路径不包含“Resources”和扩展名
        GameObject go = Resources.Load<GameObject>("Prefabs/Cube");
        // 资源加载和实例化是不同的
        GameObject go2 = Instantiate(go);
        // 加载其他类型的资源
        Texture2D image = Resources.Load<Texture2D>("Image/1");
        Debug.Log("image.name");
        /*---卸载资源---*/
        // 强制卸载资源
        Resources.UnloadAsset(image);
        //销毁物体
        Destroy(go2);
    }

}
