using System.Collections;
using System.Collections.Generic;
//上記データ格納型に関する宣言
//下記Unityに関する機能を利用するための宣言
using UnityEngine;



public class Boss
{
    //【発展課題:Lesson4で作成したBossクラスをもとに作成してください】
    //【発展課題1:int型の変数mpを宣言し、53で初期化してください※1】
    private int mp;    //mp残量(宣言のみ)
    private int cost = 5;   //mp消費量(固定値)

    //【発展課題2:mpを消費して魔法攻撃をするMagic関数を作ってください】
    public void Magic()
    {
        //【発展課題3:Magic関数内でmpを5以上の場合は5減らし(以降省略)】
        for (int mp =　53 ; mp > 0 ; mp -= cost) 　//※1初期値53を設定。mpとcostの消費をfor文で判別（mp初期値53と消費5であれば10回ループする）
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");  //mpがcostを上回ってる際に表示(残量あり)
        }
        Debug.Log("MPが足りないため、魔法が使えない。");  //mpがcostを下回ってる際に表示(残量なし)
    }

}


    //クラス名（今回はTest）、スクリプト名とクラス名は同一。
    public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    //Start:最初の一度のみ実行
    void Start()
    {

        //【課題1:要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください】
        int[] array = { 8, 19, 58, 168, 401 };

        //【課題2:for文を使い、配列の各要素の値を順番に表示してください】
        for (int plus = 0; plus < 5; plus++)
        {
            Debug.Log(array[plus]);
        }

        Debug.Log("--------------ここから別プログラム---------------");
        //【課題3:for文を使い、配列の各要素の値を逆順に表示してください】
        for (int minus = 4; minus >= 0; minus--)
        {
            Debug.Log(array[minus]);
        }

        Debug.Log("--------------ここから別プログラム---------------");
        //【発展課題4:Magic関数を呼び出して、魔法を使ってください】
        Boss bossmp = new Boss();

        //【発展課題5:Magic関数を10回使った後に、さらにMagic関数を呼び出すと(以降省略)】
        bossmp.Magic();

    }

    // Update is called once per frame
    //Update：毎フレーム(FPS)ごとに実行
    void Update()
    {
        
    }
}

