using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScript : MonoBehaviour
{
    public static bool ini = true;
    public static string me;     //出題する人
    public static string you;    //回答する人
    //特徴１～５
    public static string q1;
    public static string q2;
    public static string q3;
    public static string q4;
    public static string q5;
    //問題の相性チェック真偽(T=1,F=0)
    public static int[] check = new int[] { 1,1,1,1,1 };
    //相性のパーセンテージ
    public static int compatibility = 0;
    public static void Init()
    {
        me = "山下航季";
        you = "ゲスト";
        q1 = "VOCALOIDが好き";
        q2 = "歌うことが好き";
        q3 = "寝ることが好き";
        q4 = "アナログゲームが好き";
        q5 = "知り合った人とは積極的に仲良くなりたい";
        ini = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
