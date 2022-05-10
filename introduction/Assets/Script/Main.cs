using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    [SerializeField] GameObject nameOb;
    public GameObject qsOb;
    public GameObject back;
    Image backImg;
    Text shitsumon;
    List<string> qList = new List<string>();
    int[] check = new int[]{ TextScript.check[0], TextScript.check[1], TextScript.check[2], TextScript.check[3], TextScript.check[4] };
    int tmp;
    // Start is called before the first frame update
    void Start()
    {
        nameOb.GetComponent<Text>().text = TextScript.me + "さんは";
        shitsumon = qsOb.GetComponent<Text>();
        backImg = back.GetComponent<Image>();
        qList.Add(TextScript.q1);
        qList.Add(TextScript.q2);
        qList.Add(TextScript.q3);
        qList.Add(TextScript.q4);
        qList.Add(TextScript.q5);

        ChangeQ(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeQ(int LR)
    {

        if (qList.Count == 0)
        {
            if (TextScript.check[tmp].Equals(LR))
            {
                TextScript.compatibility++;
            }
            SceneManager.LoadScene("kekka");
        }
        else
        {
            back.GetComponent<Image>().color = new Color32((byte)Random.Range(180, 255), (byte)Random.Range(180, 255), (byte)Random.Range(180, 255), 255);
            
            tmp = Random.Range(0, qList.Count * 50) / 50;
            shitsumon.text = qList[tmp];
            qList.RemoveAt(tmp);
            while (check[tmp] == -1)
            {
                //Debug.Log(TextScript.check[tmp] + ","+ tmp);
                tmp += 1;
            }

            if (check[tmp].Equals(LR)) TextScript.compatibility++;

            check[tmp] = -1;
            Debug.Log(TextScript.check[0] + "," + TextScript.check[1] + "," + TextScript.check[2] + "," + TextScript.check[3] + "," + TextScript.check[4]);
        }
        Debug.Log(TextScript.compatibility);
    }
}
