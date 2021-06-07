using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BowlingPresenter 
{
    IBowlingView view;
    public BowlingModel bowlingModel;

    public BowlingPresenter(IBowlingView view) {
        bowlingModel = new BowlingModel();
        this.view = view;
    }
  
    public void Simulate() {

        bowlingModel.Simulate();

        view.SetScores(bowlingModel.player1.GetScores(), bowlingModel.player2.GetScores());
        view.SetScoreTotal(bowlingModel.GetTotalScore(bowlingModel.player1), bowlingModel.GetTotalScore(bowlingModel.player2));
    }
}
