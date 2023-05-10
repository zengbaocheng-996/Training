using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudio : MonoBehaviour
{
    // ���ⲿָ������Ƭ��
    public List<AudioClip> clips;
    // ��Դ���
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(clips.Count);
        // ��ȡ��Դ���
        GameObject go = GameObject.Find("Audio Source");
        audio = go.GetComponent<AudioSource>();
        // ��ֹͣ����
        audio.Stop();
        // ��ѭ��
        audio.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            // �л�������0������
            audio.clip = clips[0];
            audio.Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            // �л�������1������
            audio.clip = clips[1];
            audio.Play();
        }
        // ���ո�� ��ͣ/����
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
