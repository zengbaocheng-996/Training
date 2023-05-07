using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRecur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Loop(10));   
        StartCoroutine(LoopA(10));
    }
    IEnumerator LoopA(int n)
    {
        if(n==0)
        {
            yield break;
        }
        yield return LoopB(n - 1);
        yield return new WaitForSeconds(0.3f);
        Debug.Log("LoopA:" + n + "    Time:" + Time.time);
    }
    IEnumerator LoopB(int n)
    {
        if(n==0)
        {
            yield break;
        }
        yield return LoopA(n - 1);
        yield return new WaitForSeconds(0.3f);
        Debug.Log("LoopB:" + n + "    Time:" + Time.time);
    }
    //IEnumerator Loop(int n)
    //{
    //    yield return new WaitForSeconds(0.3f);
    //    Debug.Log("Loop:" + n + "    Time:" + Time.time);
    //    if(n==1)
    //    {
    //        yield break;
    //    }
    //    yield return Loop(n - 1);
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
