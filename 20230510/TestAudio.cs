using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudio : MonoBehaviour
{
    // 从外部指定声音片段
    public List<AudioClip> clips;
    // 音源组件
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(clips.Count);
        // 获取音源组件
        GameObject go = GameObject.Find("Audio Source");
        audio = go.GetComponent<AudioSource>();
        // 先停止播放
        audio.Stop();
        // 不循环
        audio.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 切换到音乐0并播放
            audio.clip = clips[0];
            audio.Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 切换到音乐1并播放
            audio.clip = clips[1];
            audio.Play();
        }
        // 按空格键 暂停/继续
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (audio.isPlaying)
            {
                audio.Pause();
            }
            else 
            {
                audio.UnPause();
            }
        }
    }
}
