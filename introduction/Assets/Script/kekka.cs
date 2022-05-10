using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kekka : MonoBehaviour
{
    public GameObject t1Ob;
    public GameObject t2Ob;
    public GameObject t3Ob;
    Text t1;
    Text t2;
    Text t3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TextScript.compatibility);
        t1 = t1Ob.GetComponent<Text>();
        t2 = t2Ob.GetComponent<Text>();
        t3 = t3Ob.GetComponent<Text>();

        t1.text = TextScript.you + "さんと" + TextScript.me + "さんは...";
        t2.text = "相性" + TextScript.compatibility * 20 + "％";
        SetText3(TextScript.compatibility);
    }

    public void TitleBack()
    {
        TextScript.check = new int[] { 1, 1, 1, 1, 1 };
        TextScript.compatibility = 0;
        SceneManager.LoadScene("title");
    }

    void SetText3(int com)
    {
        switch (com)
        {
            case 0:
                t3.text = "相性最悪...\nいつか仲良くなれるかも？";
                break;
            case 1:
                t3.text = "相性わるめ...\nいいところを見つけてみよう！";
                break;
            case 2:
                t3.text = "相性微妙...\nでもきっと仲良くなれます！";
                break;
            case 3:
                t3.text = "相性まあまあ！\n仲良くしてください！";
                break;
            case 4:
                t3.text = "相性いいです！\n仲良くなりましょう！";
                break;
            case 5:
                t3.text = "相性最高！\nぜひ仲良くしましょう！！";
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
