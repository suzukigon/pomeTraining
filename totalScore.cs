using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalScore : MonoBehaviour {

    private Text targetText;

    void Start () {
        int total_count_sqw = PlayerPrefs.GetInt("TotalCountSqw");
        string text1 = (total_count_sqw).ToString();

        this.targetText = this.GetComponent<Text>();
        this.targetText.text = text1;
    }
	
	void Update () {
		
	}
}
