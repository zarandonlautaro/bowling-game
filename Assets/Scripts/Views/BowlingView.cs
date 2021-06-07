using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlingView : MonoBehaviour, IBowlingView
{
    public BowlingPresenter presenter;

    public ScoreView[] player1;
    public ScoreView[] player2;

    public Text scoreFinalp1;
    public Text scoreFinalp2;

    void Awake() {
        presenter = new BowlingPresenter(this);
    }

    public void Simulate()
    {
        presenter.Simulate();
    }

    public void SetScores(int[,] scorePlayer1, int[,] scorePlayer2)
    {
        for (int i = 0; i < player1.Length; i++) {
            player1[i].SetValues(scorePlayer1[i, 0], scorePlayer1[i, 1]);
            player2[i].SetValues(scorePlayer2[i, 0], scorePlayer2[i, 1]);
        }
    }

    public void SetScoreTotal(int totalP1, int totalP2)
    {
        scoreFinalp1.text = totalP1.ToString();
        scoreFinalp2.text = totalP2.ToString();
    }
}
