using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalScoreUdetate : MonoBehaviour {

    private Text targetText;

    void Start()
    {
        int total_count_udetate = PlayerPrefs.GetInt("TotalCountUdetate");
        string text1 = (total_count_udetate).ToString();

        this.targetText = this.GetComponent<Text>();
        this.targetText.text = text1;
    }

    void Update()
    {

    }
}
