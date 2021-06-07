using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    public Text score1;
    public Text score2;

    public void SetValues(int score1, int score2) {
        this.score1.text = score1.ToString();
        this.score2.text = score2.ToString();
    }
}
