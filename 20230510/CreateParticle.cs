using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateParticle : MonoBehaviour
{
    public GameObject prefabParticle;
    public GameObject prefab;
    private void Start()
    {
        // 创建动画prefab
        GameObject obj = Instantiate(prefab);
        // 给动画物体加上定时销毁脚本
        obj.AddComponent<TimeDestroy>().time = 1;
        // 修改动画播放速度为2倍速
        Animator anim = obj.GetComponent<Animator>();
        anim.speed = 2;
    }
    public void OnParticleSystemStopped()
    {
        Debug.Log("粒子停止");
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown("Jump"))
        //{
        //    GameObject particle = Instantiate(prefabParticle);
        //    // 如果粒子没有勾选Play On Awake选项，就需要手动调用Play
        //    ParticleSystem ps = particle.GetComponent<ParticleSystem>();

        //    // 不要在播放后修改参数，不支持
        //    // 因此测试本脚本必须取消勾选粒子的Play On Awake选项

        //    // 获取主参数，即粒子组件界面上的第一组参数
        //    ParticleSystem.MainModule main = ps.main;
        //    main.duration = 1; // 改变总持续时间
        //    main.startSpeed = 40; // 改变初始速度
        //    main.stopAction = ParticleSystemStopAction.Destroy;// 改变播放一次后的行为

        //    // 同理，获取发射参数
        //    ParticleSystem.EmissionModule emission = ps.emission;
        //    emission.rateOverTime = 1000;// 加大发射频率

        //    ps.Play();

        //}
    }
}
