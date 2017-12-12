using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Test : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;

    public Sprite btn05;
    private GameObject obj;
    private Image image;
    public Sprite HoldSprite;

    public static int kintreCnt = 0;

    void Start()
    {
    }

    public void Button1Click()
    {
        Debug.Log("Button1 Click");
        kintreCnt = 5; // 変数を次のシーンに持たせる
        getHitPoint();
        //MainSpriteRenderer.sprite = HoldSprite;

        //buttonImage_.sprite = "set5";

        //obj = GameObject.Find("set5").gameObject as GameObject;
        //image = obj.GetComponent<Image>();
    }

    public static int getHitPoint()
    {
        return kintreCnt;
    }

    public void ButtonClick10()
    {
        Debug.Log("ButtonClick10 Click");
        kintreCnt = 10; // 変数を次のシーンに持たせる
        getHitPoint();
        //MainSpriteRenderer.sprite = HoldSprite;

        //buttonImage_.sprite = "set5";

        //obj = GameObject.Find("set5").gameObject as GameObject;
        //image = obj.GetComponent<Image>();
    }

    public void ButtonClick15()
    {
        kintreCnt = 15; // 変数を次のシーンに持たせる
        getHitPoint();
        Debug.Log("ButtonClick15 Click");

    }

    public void ButtonClick20()
    {
        kintreCnt = 20; // 変数を次のシーンに持たせる
        getHitPoint();
        Debug.Log("ButtonClick20 Click");

    }

    public void ButtonClick25()
    {
        kintreCnt = 25; // 変数を次のシーンに持たせる
        getHitPoint();
        Debug.Log("ButtonClick25 Click");

    }

    // スクワット開始
    public void startSquwat()
    {
        Debug.Log("startSquwat");

        SceneManager.LoadScene("squwat");
    }

}
