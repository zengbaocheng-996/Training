using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateParticle : MonoBehaviour
{
    public GameObject prefabParticle;
    public GameObject prefab;
    private void Start()
    {
        // ��������prefab
        GameObject obj = Instantiate(prefab);
        // ������������϶�ʱ���ٽű�
        obj.AddComponent<TimeDestroy>().time = 1;
        // �޸Ķ��������ٶ�Ϊ2����
        Animator anim = obj.GetComponent<Animator>();
        anim.speed = 2;
    }
    public void OnParticleSystemStopped()
    {
        Debug.Log("����ֹͣ");
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown("Jump"))
        //{
        //    GameObject particle = Instantiate(prefabParticle);
        //    // �������û�й�ѡPlay On Awakeѡ�����Ҫ�ֶ�����Play
        //    ParticleSystem ps = particle.GetComponent<ParticleSystem>();

        //    // ��Ҫ�ڲ��ź��޸Ĳ�������֧��
        //    // ��˲��Ա��ű�����ȡ����ѡ���ӵ�Play On Awakeѡ��

        //    // ��ȡ����������������������ϵĵ�һ�����
        //    ParticleSystem.MainModule main = ps.main;
        //    main.duration = 1; // �ı��ܳ���ʱ��
        //    main.startSpeed = 40; // �ı��ʼ�ٶ�
        //    main.stopAction = ParticleSystemStopAction.Destroy;// �ı䲥��һ�κ����Ϊ

        //    // ͬ����ȡ�������
        //    ParticleSystem.EmissionModule emission = ps.emission;
        //    emission.rateOverTime = 1000;// �Ӵ���Ƶ��

        //    ps.Play();

        //}
    }
}
