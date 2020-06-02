using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System; //enumを使うために必要

public class SetColorImage : MonoBehaviour
{
    public Image ChangeColor;

    // 画像
    public Sprite Red, Green,Red2,Orange,Brown,Black,Gold,Silver,Blue,Purple;

    void Update()
    {
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
                        case KeyCode.A:
                            ChangeColor.sprite = Red;
                            break;

                        case KeyCode.S:
                            ChangeColor.sprite = Green;
                            break;

                        case KeyCode.D:
                            ChangeColor.sprite = Red2;
                            break;

                        case KeyCode.F:
                            ChangeColor.sprite = Orange;
                            break;

                        case KeyCode.G:
                            ChangeColor.sprite = Brown;
                            break;

                        case KeyCode.Z:
                            ChangeColor.sprite = Black;
                            break;

                        case KeyCode.X:
                            ChangeColor.sprite = Gold;
                            break;

                        case KeyCode.C:
                            ChangeColor.sprite = Silver;
                            break;

                        case KeyCode.V:
                            ChangeColor.sprite = Blue;
                            break;

                        case KeyCode.B:
                            ChangeColor.sprite = Purple;
                            break;
                    }
                    break; // 一度処理に入ればこれ以降処理に入ることは無いのでここでbreakし、foreach文を抜けます。
                }
            }
        }
    }
}