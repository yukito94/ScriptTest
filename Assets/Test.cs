using System.Collections;
using System.Collections.Generic;
//上記データ格納型に関する宣言
//下記Unityに関する機能を利用するための宣言
using UnityEngine;

//クラス名（今回はTest）、スクリプト名とクラス名は同一。
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    //Start:最初の一度のみ実行
    void Start()
    {

        //【課題:要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください】
        int[] array = { 8,19,58,168,401 };

        //【課題:for文を使い、配列の各要素の値を順番に表示してください】
        for (int plus = 0; plus < 5; plus++)
        {
            Debug.Log(array[plus]);
        }

        Debug.Log("--------------ここから別プログラム---------------");
        //【課題:for文を使い、配列の各要素の値を逆順に表示してください】
        for (int minus = 4; minus >= 0; minus--)
        {
            Debug.Log(array[minus]);
        } 
    }

    // Update is called once per frame
   //Update：毎フレーム(FPS)ごとに実行
    void Update()
    {
        
    }
}
