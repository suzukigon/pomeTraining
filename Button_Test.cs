using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
* メニュー画面の筋トレ回数選択の取得
* スクワット / 腕立て　の切り替え
*/

public class Button_Test : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;

    public static int kintreCnt = 0;

    public Sprite btn05Mae;
    public Sprite btn05Ato;
    public Sprite btn10Mae;
    public Sprite btn10Ato;
    public Sprite btn15Mae;
    public Sprite btn15Ato;
    public Sprite btn20Mae;
    public Sprite btn20Ato;
    public Sprite btn25Mae;
    public Sprite btn25Ato;

    private GameObject obj;
    private Image image;

    private GameObject cnt05;
    private GameObject cnt10;
    private GameObject cnt15;
    private GameObject cnt20;
    private GameObject cnt25;

    private GameObject sqw;
    private GameObject udetate;

    public void resetBtn() // ボタン選択の初期化
    {
        cnt05 = GameObject.Find("Button05");
        cnt05.gameObject.GetComponent<Image>().sprite = btn05Mae;
        cnt10= GameObject.Find("Button10");
        cnt10.gameObject.GetComponent<Image>().sprite = btn10Mae;
        cnt15 = GameObject.Find("Button15");
        cnt15.gameObject.GetComponent<Image>().sprite = btn15Mae;
        cnt20 = GameObject.Find("Button20");
        cnt20.gameObject.GetComponent<Image>().sprite = btn20Mae;
        cnt25 = GameObject.Find("Button25");
        cnt25.gameObject.GetComponent<Image>().sprite = btn25Mae;
    }

    public static int getHitPoint() // 選択した回数をトレーニングシーンに渡す
    {
        return kintreCnt;
    }

    public void Button1Click5()
    {
        kintreCnt = 5; // 変数を次のシーンに持たせる
        resetBtn();
        this.gameObject.GetComponent<Image>().sprite = btn05Ato;
        getHitPoint();

        //データ取得
        int total_count_sqw = PlayerPrefs.GetInt("TotalCountSqw");
        total_count_sqw = total_count_sqw + 5;

        //データ入力
        PlayerPrefs.SetInt("TotalCountSqw", total_count_sqw);
        
    }

    public void ButtonClick10()
    {
        resetBtn();
        kintreCnt = 10; // 変数を次のシーンに持たせる
        this.gameObject.GetComponent<Image>().sprite = btn10Ato;
        getHitPoint();
    }

    public void ButtonClick15()
    {
        kintreCnt = 15; // 変数を次のシーンに持たせる
        resetBtn();
        this.gameObject.GetComponent<Image>().sprite = btn15Ato;
        getHitPoint();
    }

    public void ButtonClick20()
    {
        kintreCnt = 20; // 変数を次のシーンに持たせる
        resetBtn();
        this.gameObject.GetComponent<Image>().sprite = btn20Ato;
        getHitPoint();
    }

    public void ButtonClick25()
    {
        kintreCnt = 25; // 変数を次のシーンに持たせる
        getHitPoint();
        resetBtn();
        this.gameObject.GetComponent<Image>().sprite = btn25Ato;
    }

    // スクワット開始
    public void startSquwat()
    {
        int resultHitpoint = chgSprite.getTrn();
        Debug.Log(resultHitpoint);


        SceneManager.LoadScene("squwat");
    }

}
