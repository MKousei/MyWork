using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System; //enumを使うために必要

public class SetImage : MonoBehaviour
{
    public Image ChangeName;
    public Image ChangeImage;

    // 名前
    public Sprite Na_BlackLeopard, Na_Cheetah, Na_Elephant, Na_Fawn, Na_Koala, Na_Lion, Na_Monkey, Na_Pegasus, Na_RaccoonDog, Na_Sheep, Na_Tiger, Na_Wolf;

    // 画像        クロヒョウ , チーター,   象    ,小鹿,コアラ,ライオン,猿  , ペガサス, タヌキ   ,  羊  ,  虎     狼
    public Sprite BlackLeopard, Cheetah, Elephant, Fawn, Koala, Lion, Monkey, Pegasus, RaccoonDog, Sheep, Tiger, Wolf;

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
                        case KeyCode.Alpha1:
                            ChangeName.sprite = Na_BlackLeopard;
                            ChangeImage.sprite = BlackLeopard;
                            break;

                        case KeyCode.Alpha2:
                            ChangeName.sprite = Na_Cheetah; ;
                            ChangeImage.sprite = Cheetah;
                            break;

                        case KeyCode.Alpha3:
                            ChangeName.sprite =  Na_Elephant;
                            ChangeImage.sprite = Elephant;
                            break;

                        case KeyCode.Alpha4:
                            ChangeName.sprite = Na_Fawn;
                            ChangeImage.sprite = Fawn;
                            break;

                        case KeyCode.Alpha5:
                            ChangeName.sprite = Na_Koala ;
                            ChangeImage.sprite = Koala;
                            break;

                        case KeyCode.Alpha6:
                            ChangeName.sprite = Na_Lion;
                            ChangeImage.sprite = Lion;
                            break;

                        case KeyCode.Q:
                            ChangeName.sprite = Na_Monkey;
                            ChangeImage.sprite = Monkey;
                            break;

                        case KeyCode.W:
                            ChangeName.sprite = Na_Pegasus;
                            ChangeImage.sprite = Pegasus;
                            break;

                        case KeyCode.E:
                            ChangeName.sprite = Na_RaccoonDog;
                            ChangeImage.sprite = RaccoonDog;
                            break;

                        case KeyCode.R:
                            ChangeName.sprite = Na_Sheep;
                            ChangeImage.sprite = Sheep;
                            break;

                        case KeyCode.T:
                            ChangeName.sprite = Na_Tiger;
                            ChangeImage.sprite = Tiger;
                            break;

                        case KeyCode.Y:
                            ChangeName.sprite = Na_Wolf;
                            ChangeImage.sprite = Wolf;
                            break;

                        default:
                            break;
                    }
                    
                    break; // 一度処理に入ればこれ以降処理に入ることは無いのでここでbreakし、foreach文を抜けます。
                }
            }
        }
    }
}

// ※foreach文はある配列やリストに格納されている要素一つ一つに一回ずつアクセスすることのできる文