using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ansermgr1 : MonoBehaviour
{
    public GameObject Anser1 = null;

    public int Answer1Cnt = 0;
    public string[] Answer1 = new string[10];
    public bool AnsFlg = false;
    public bool Flg = false;
    GameObject GOGM;
    GameMng GM;
    Text AM1;
    public Button Btn;

    void Start()
    {
        GOGM = GameObject.Find("GameManager");
       
        Btn = GetComponent<Button>();
        AnsFlg = false;
        if (!AnsFlg)
        {
            //Btn.interactable = true;
        }
    }

    void OnClick()
    {
        Btn = GetComponent<Button>();
        AnsFlg = true;
        if (AnsFlg)
        {
            Btn.interactable = false;
        }
    }

    void Update()
    {
        GM = GOGM.GetComponent<GameMng>();
        AM1 = Anser1.GetComponent<Text>();

        AM1.text = Answer1[Answer1Cnt];

        if (GM.Flg)
        {
            Answer1Cnt++;
            Flg = true;
        }

    }

}
