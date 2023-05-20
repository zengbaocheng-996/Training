using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    IEnumerator LoadFileAsync()
    {
        string path = "";
        AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(path);
        yield return request;
        AssetBundle ab = request.assetBundle;
        Instantiate(ab.LoadAsset<GameObject>("CubeWall"));
    }
    IEnumerator UseUnityWebRequest(string path)
    {
        // 使用UnityWebRequest.GetAssetBundle(路径)加载资源。这个路径是资源地址URL，同样也支持本地文件
        UnityWebRequest request = UseUnityWebRequest.GetAssetBundle(path);
        yield return request.SendWebRequest();
        // 运行到这里代表加载完成，从request对象中获得资产包
        AssetBundle ab = DownloadHandlerAssetBundle.GetContent(request);
        // 之后的使用方法与本地加载没有区别
        GameObject obj = ab.LoadAsset<GameObject>("Wall");
        Instantiate(obj);
    }
}
