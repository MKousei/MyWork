using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ansermgr2 : MonoBehaviour
{
    public GameObject Anser2 = null;
 
    public int Answer2Cnt = 0;
    public string[] Answer2 = new string[10];
    public bool AnsFlg = false;
    public bool Flg = false;
    GameObject GOGM;
    GameMng GM;
    Text AM2;
    public Button Btn;

    void Start()
    {
        GOGM = GameObject.Find("GameManager");
        Btn = GetComponent<Button>();
        if (!AnsFlg)
        {
            //Btn.interactable = true;
        }
    }

    public void OnClick()
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
        AM2 = Anser2.GetComponent<Text>();
        


        AM2.text = Answer2[Answer2Cnt];


        if (GM.Flg)
        {
            Answer2Cnt++;
            Flg = true;
        }
    }

}
