using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;// 魔法力

    // 魔法攻撃の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss x = new Boss();

        // 魔法攻撃用の関数を呼び出す
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
        x.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}