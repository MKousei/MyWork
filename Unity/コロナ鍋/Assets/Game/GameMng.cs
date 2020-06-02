using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMng : MonoBehaviour
{
    private int Number;
    public bool Flg = false;
    string S1;
    string S2;
    Ansermgr1 A1;
    Ansermgr2 A2;
    QuestionMng QM;
    GameObject GOAN1;
    GameObject GOAN2;
    GameObject GOQM;
    Text a;



    void Start()
    {
        GOAN1 = GameObject.Find("Canvas/AnserManager1");
        GOAN2 = GameObject.Find("Canvas/AnserManager2");
        GOQM = GameObject.Find("Canvas/QuestionManager");
        S1 = GameObject.Find("Canvas/Anser1/Text").GetComponent<string>();
        S2 = GameObject.Find("Canvas/Anser2/Text").GetComponent<string>();
        a = GameObject.Find("Canvas/marubatsu1").GetComponentInChildren<Text>();
    }

    void Update()
    {
        A1 = GOAN1.GetComponent<Ansermgr1>();
        A2 = GOAN2.GetComponent<Ansermgr2>();
        QM = GOQM.GetComponent<QuestionMng>();

        if (A1.AnsFlg || A2.AnsFlg)
        {
            if (S1 == "鍋" || S2 == "鍋")
            {
                Debug.Log("丸");
                a.text = "丸";
                Flg = true;
            }
            else
            {
                Debug.Log("罰");
                a.text = "罰";
                Flg = true;
            }
        }

        if (A1.Flg && A2.Flg && QM.Flg)
        {
            A1.Flg = false;
            A2.Flg = false;
            QM.Flg = false;
            A1.AnsFlg = false;
            A2.AnsFlg = false;
            Flg = false;
        }

        if (Number > 9)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
