using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResources : MonoBehaviour
{
    private void Start()
    {
        /* 加载资源 */
        // 预制体资源用GameObject类型表示，路径不包含Resources和扩展名
        GameObject go = Resources.Load<GameObject>("Prefabs/Cube");
        // 资源加载和实例化是不同的
        GameObject go2 = Instantiate(go,new Vector3(0,0,0),Quaternion.identity);

        //// 加载其他类型的资源
        //Texture2D image = Resources.Load<Texture2D>("Images/1");
        //Debug.Log(image.name);

        ///* 卸载资源 */
        //// 强制卸载资源
        //Resources.UnloadAsset(image);
        //// 销毁物体
        //Destroy(go2);

        //// 卸载一个资源
        //public static void UnloadAsset(Object asssetToUnload);
        //// 自动卸载所有未使用的资源
        //public static AsyncOperation UnloadUnusedAssets();
    }
}
