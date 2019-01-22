using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    int scoreCount = 0;
    public Text text;

	public void addScore(int x)
    {
        scoreCount += x;
    }

    private void FixedUpdate()
    {
        text.text = scoreCount.ToString();
    }
}
