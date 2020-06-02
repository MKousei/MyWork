using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionMng : MonoBehaviour
{
    public GameObject Question = null;
    public int QuestionCnt = 0;
    public string[] QuestionT = new string[10];
    public bool Flg = false;
    GameObject GOGM;
    GameMng GM;
    Text QM;

    public void Start()
    {
        GOGM = GameObject.Find("GameManager");
      
    }

    public void Update()
    {
        QM = Question.GetComponent<Text>();
        GM = GOGM.GetComponent<GameMng>();

        QM.text = QuestionT[QuestionCnt];

        if (GM.Flg)
        {
            QuestionCnt++;
            Flg = true;
        }
    }
}
