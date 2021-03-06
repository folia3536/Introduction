using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject meOb;
    public GameObject youOb;
    public GameObject q1Ob;
    public GameObject q2Ob;
    public GameObject q3Ob;
    public GameObject q4Ob;
    public GameObject q5Ob;
    public GameObject titleOb;
    public GameObject[] toggles;
    InputField me;
    InputField you;
    InputField q1;
    InputField q2;
    InputField q3;
    InputField q4;
    InputField q5;
    
    //public GameObject option;
    // Start is called before the first frame update
    void Start()
    {
        me = meOb.GetComponent<InputField>();
        you = youOb.GetComponent<InputField>();
        q1 = q1Ob.GetComponent<InputField>();
        q2 = q2Ob.GetComponent<InputField>();
        q3 = q3Ob.GetComponent<InputField>();
        q4 = q4Ob.GetComponent<InputField>();
        q5 = q5Ob.GetComponent<InputField>();
        //option = GetComponent<GameObject>();

        if (TextScript.ini)
        {
            TextScript.Init();
        }

        GetBool();
        GetText();
    }

    public void SetMe()
    {
        if(me.text.Length != 0)
        {
            TextScript.me = me.text;
            titleOb.GetComponent<Text>().text = me.text + "さん¥nとの相性診断";
        }
    }
    public void SetYou()
    {
        
        if (you.text.Length != 0)
        {
            TextScript.you = you.text;
        }
    }

    public void SetQ1()
    {
        if (q1.text.Length != 0)
        {
            TextScript.q1 = q1.text;
        }
    }

    public void SetQ2()
    {
        if (q2.text.Length != 0)
        {
            TextScript.q2 = q2.text;
        }
    }

    public void SetQ3()
    {
        if (q3.text.Length != 0)
        {
            TextScript.q3 = q3.text;
        }
    }

    public void SetQ4()
    {
        if (q4.text.Length != 0)
        {
            TextScript.q4 = q4.text;

        }
    }

    public void SetQ5()
    {
        if (q5.text.Length != 0)
        {
            TextScript.q5 = q5.text;
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene("shitsumon");
    }

    public void ActiveOption(GameObject option)
    {
        GetText();
        if(option.activeInHierarchy)
        {
            option.SetActive(false);
        }
        else
        {
            option.SetActive(true);
        }
    }

    public void GetText()
    {
        me.placeholder.GetComponent<Text>().text = TextScript.me;
        you.placeholder.GetComponent<Text>().text = TextScript.you;
        q1.placeholder.GetComponent<Text>().text = TextScript.q1;
        q2.placeholder.GetComponent<Text>().text = TextScript.q2;
        q3.placeholder.GetComponent<Text>().text = TextScript.q3;
        q4.placeholder.GetComponent<Text>().text = TextScript.q4;
        q5.placeholder.GetComponent<Text>().text = TextScript.q5;
    }

    void GetBool()
    {
        for(int i = 0; i < TextScript.check.Length; i++)
        {
            if(TextScript.check[i] == 1)
            {
                toggles[i].GetComponent<Toggle>().isOn = true;
            }
            else if(TextScript.check[i] == 0)
            {
                toggles[i].GetComponent<Toggle>().isOn = false;
            }
            
        }
    }

    public void SetBool(int index)
    {
        if(toggles[index].GetComponent<Toggle>().isOn)
        {
            TextScript.check[index] = 1;
        }
        else
        {
            TextScript.check[index] = 0;
        }
        Debug.Log(toggles[0].GetComponent<Toggle>().isOn + "," + toggles[1].GetComponent<Toggle>().isOn + "," + toggles[2].GetComponent<Toggle>().isOn + "," + toggles[3].GetComponent<Toggle>().isOn + "," + toggles[4].GetComponent<Toggle>().isOn);
    }

    public void GameEnd()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
