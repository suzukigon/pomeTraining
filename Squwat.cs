using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Squwat : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int resultHitpoint = Button_Test.getHitPoint();

        if(resultHitpoint == 5)
        {
            Invoke("backMenu", 10.5f);
        }
        if (resultHitpoint == 10)
        {
            Invoke("backMenu", 21);
        }
        if (resultHitpoint == 15)
        {
            Invoke("backMenu", 31.5f);
        }
        if (resultHitpoint == 20)
        {
            Invoke("backMenu", 42);
        }
        if (resultHitpoint == 25)
        {
            Invoke("backMenu", 52.5f);
        }

    }

    //「Invoke」で呼び出すメソッド
    void backMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
