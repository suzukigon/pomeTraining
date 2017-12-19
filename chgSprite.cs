using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chgSprite : MonoBehaviour {

    public static int trnKind = 0;

    public Sprite spriteMae;
    public Sprite spriteAto;

    public Sprite udeMae;
    public Sprite udeAto;

    private bool chFlg = false;
    private GameObject ude;
    private GameObject sqw;

    public static int getTrn()
    {
        return trnKind;
    }

    public void changeSprite() // スクワットをタップした時🐶
    {
        // 画像クリックで切り替える
        ude = GameObject.Find("Udetate");
        this.gameObject.GetComponent<Image>().sprite = spriteMae;
        ude.gameObject.GetComponent<Image>().sprite = udeMae;

        trnKind = 0; // スタート開始時に渡すフラグ
        getTrn();
    }

    public void changeSpriteUde() // 腕立てをタップした時😼
    {
        // 画像クリックで切り替える
        sqw = GameObject.Find("squwat");
        this.gameObject.GetComponent<Image>().sprite = udeAto;
        sqw.gameObject.GetComponent<Image>().sprite = spriteAto;

        trnKind = 1; // スタート開始時に渡すフラグ
        getTrn();
    }
}
