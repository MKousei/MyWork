//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;
//using UnityEngine.Advertisements;   // Unity Ads

//public class GameController : MonoBehaviour
//{
//    //ゲームステート
//    enum State
//    {
//        Infomation,
//        GameOver
//    }

//    State state;


//    //public GameObject blocks;
//    public Button OKButton;

//    //string GoogleInfomation_ID = "3577245";
//    //bool GameMode = true;

//    string myPlacentId = "rewardeVideo";

//    // 初期化
//    void Start()
//    {

//    }

//    // [System.Obsolete]
//    private void LateUpdate()
//    {
//        //ゲームのステートごとにイベントを監視
//        switch (state)
//        {
//            case State.Infomation:
//                //キャラクターが死亡したらゲームオーバー
//                if (IsDead()) GameOver();
//                break;
//            case State.GameOver:
//                //タッチしたらシーンをリロード
//                if (Input.GetButtonDown("Fire1"))
//                    ReloadOrShowAdvertisement();
//                break;
//        }
//    }

//    void star()
//    {
//        state = State.star;

//        //各オブジェクトを無効化状態にする
//        azarashi.SetSteerActive(false);
//        blocks.SetActive(false);

//        // ラベルを更新
//        scoreText.text = "Score : " + 0;

//        stateText.gameObject.SetActive(true);
//        stateText.text = "star";
//    }

//    void GameStart()
//    {
//        state = State.Infomation;

//        //各オブジェクトを有効にする
//        azarashi.SetSteerActive(true);
//        blocks.SetActive(true);

//        //最初の入力だけゲームコントローラーから離す
//        azarashi.Flap();

//        //ラベルを更新
//        stateText.gameObject.SetActive(false);
//        stateText.text = "";
//    }

//    void GameOver()
//    {
//        state = State.GameOver;

//        //シーン中のすべてのScrollObjectコンポーネントを探し出す
//        ScrollObject[] scrollObjects = FindObjectsOfType<ScrollObject>();

//        //全ScrollObjectのスクロール処理を無効にする
//        foreach (ScrollObject so in scrollObjects) so.enabled = false;

//        //ラベルを更新
//        stateText.gameObject.SetActive(true);
//        stateText.text = "GameOver";

//    }

//    // [System.Obsolete]
//    void ReloadOrShowAdvertisement()
//    {
//        // 広告の準備ができてなかったらそのままリロードする
//        //if (!Advertisement.Isstar()) Reload();

//        //広告完了のコールバックを登録して Unity Ads を表示
//        var options = new ShowOptions
//        {
//            resultCallback = OnAdvertismentComplete
//        };

//        //Advertisement.Show(options);
//        Advertisement.Show(options);
//    }

//    //広告完了時のイベントを受け取る
//    void OnAdvertismentComplete(ShowResult result)
//    {
//        Reload();
//    }

//    void Reload()
//    {
//        //現在読み込んでいるシーンを再読み込み
//        string currentSceneName = SceneManager.GetActiveScene().name;
//        SceneManager.LoadScene(currentSceneName);
//    }

//    public void IncreaseScore()
//    {
//        score++;
//        scoreText.text = "Score : " + score;
//    }

//}