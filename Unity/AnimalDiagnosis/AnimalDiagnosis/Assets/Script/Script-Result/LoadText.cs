//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class LoadText : MonoBehaviour
//{
//	//　読み込んだテキストを出力するUIテキスト
//	[SerializeField]
//	private Text dataText;
//	//　Resourcesフォルダから直接テキストを読み込む
//	private string loadText;

//	void Start()
//	{
//		// ResourcesフォルダのTest2ファイルを取り出すには Resources.Load関数を使用し第１引数にファイル名、第２引数にそのファイルの型を指定
//			loadText += (Resources.Load("Text/" + 1, typeof(TextAsset)) as TextAsset).text;

//		//　読み込んだテキストファイルの内容を表示
//		dataText.text = loadText;
//	}
//}

//  確認用
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    // テキストファイルを扱うにはTextAssetを使用する必要がある。

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text dataText;
    //　読む込むテキストが書き込まれている.txtファイル (TextAssetの参照変数)
    [SerializeField]
    private TextAsset textAsset;
    //　Resourcesフォルダから直接テキストを読み込む
    private string loadText;
    //　改行で分割して配列に入れる
    private string[] splitText;
    //　現在表示中テキスト番号
    private int textNum;

    void Start()
    {
        // ResourcesフォルダのTest2ファイルを取り出すには Resources.Load関数を使用し第１引数にファイル名、第２引数にそのファイルの型を指定
        for (int i = 1; i <= 60; i++)
        {
            loadText += (Resources.Load("Text/" + i, typeof(TextAsset)) as TextAsset).text + "\r\n_No." + i + "@";
        }

        // 読み込んだテキストファイルは改行文字（￥n）を含んだ形で記述されていますので、Split関数を使用して\nを使って分割し文字列型の配列に入れる
        splitText = loadText.Split(char.Parse("@"));

        textNum = 0;

        dataText.text = "→で昇順、←で降順に読み込みしたテキストが表示される。";
    }

    void Update()
    {
        ////　読み込んだテキストファイルの内容を表示
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    textNum++;
        //    if (textNum >= splitText.Length)
        //    {
        //        textNum = 0;
        //    }

        //    dataText.text = splitText[textNum];
        //}

        ////Resourcesフォルダに配置したテキストファイルの内容を表示
        //else if (Input.GetButtonDown("Fire2"))
        //{
        //    textNum--;
        //    if (textNum < 0)
        //    {
        //        textNum = 60;
        //    }

        //    dataText.text = splitText[textNum];
        //}

        // 何かキーが押されているかの判定をします。ここを書かないと毎フレームごとに全てのキーをチェックしてしまうので処理が重くなります。
        if (Input.anyKeyDown)
        {
            // codeという変数にKeyCodeを一つずつ取り出して代入
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                //押したキーがcodeと同じであるかをチェック
                if (Input.GetKeyDown(code))
                {
                    switch (code)
                    {
                        case KeyCode.RightArrow:
                            textNum++;
                            if (textNum >= splitText.Length)
                            {
                                textNum = 0;
                            }

                            dataText.text = splitText[textNum];
                            break;

                        case KeyCode.LeftArrow:
                            textNum--;
                            if (textNum < 0)
                            {
                                textNum = 60;
                            }

                            dataText.text = splitText[textNum];
                            break;

                    break; // 一度処理に入ればこれ以降処理に入ることは無いのでここでbreakし、foreach文を抜けます。
                }
            }
        }
    }
}
}