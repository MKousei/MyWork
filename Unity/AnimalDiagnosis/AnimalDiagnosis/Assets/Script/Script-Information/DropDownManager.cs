using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using TMPro;

public class DropDownManager: MonoBehaviour
{
    public TMP_Dropdown TMPD_Year;
    public TMP_Dropdown TMPD_Month;
    public TMP_Dropdown TMPD_Day;

    int year;
    int month;
    int day;

    // Use this for initialization
    void Start()
    {
        if (TMPD_Year)
        {
            TMPD_Year.ClearOptions();    //現在の要素をクリアする
            List<string> list = new List<string>();
            for (int i = 1949; i <= 2020; i++)
            {
                if (i == 1949)
                {
                    list.Add("年");
                }
                else
                {
                    list.Add(i.ToString() + "年");
                }
            }
            TMPD_Year.AddOptions(list);  //新しく要素のリストを設定する
            TMPD_Year.value = 0;         //デフォルトを設定(0～n-1)
        }

        if (TMPD_Month)
        {
            TMPD_Month.ClearOptions();    //現在の要素をクリアする
            List<string> list = new List<string>();
            for (int i = 0; i <= 12; i++)
            {
                if (i == 0)
                {
                    list.Add("月");
                }
                else
                {
                    list.Add(i.ToString() + "月");
                }
            }
            TMPD_Month.AddOptions(list);  //新しく要素のリストを設定する
            TMPD_Month.value = 0;         //デフォルトを設定(0～n-1)
        }

        if (TMPD_Day)
        {
            TMPD_Day.ClearOptions();    //現在の要素をクリアする
            List<string> list = new List<string>();
            for (int i = 0; i <= 31; i++)
            {
                if (i == 0)
                {
                    list.Add("日");
                }
                else
                {
                    list.Add(i.ToString() + "日");
                }
            }
            TMPD_Day.AddOptions(list);  //新しく要素のリストを設定する
            TMPD_Day.value = 0;         //デフォルトを設定(0～n-1)
        }
    }
}