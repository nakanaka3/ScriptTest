using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;// ���@��

    // ���@�U���̊֐�
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Maho : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss boss = new Boss();

        // ���@�U���p�̊֐����Ăяo��
        boss.Magic();

    }

    // Update is called once per frame
    void Update()
    {

    }
}