using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class LoadFromFileExample : MonoBehaviour
{
    void Start()
    {
        var myLoadedAssetBundle =
            AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "myassetBundle");
        if(myLoadedAssetBundle==null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("MyObject");
        Instantiate(prefab);
    }
    //IEnumerator InstantiateObject()
    //{
    //    string assetBundleName = "testing";
    //    string url = "file://" + Application.dataPath + "/AssetBundles/" + assetBundleName;
    //    UnityEngine.Networking.UnityWebRequest request
    //        = UnityEngine.Networking.UnityWebRequest.GetAssetBundle(url);
    //}
}
