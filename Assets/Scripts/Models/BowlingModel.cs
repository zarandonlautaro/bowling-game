using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BowlingModel
{
    public BowlingPlayer player1;
    public BowlingPlayer player2;

    public BowlingModel() {
        player1 = new BowlingPlayer();
        player2 = new BowlingPlayer();
    }
    
    public void Simulate() {
        player1.Simulate();
        player2.Simulate();
    }
  
    public int GetTotalScore(BowlingPlayer player) {
        return player.GetTotalScore();
    }
}
[System.Serializable]
public class BowlingPlayer
{
    private int[,] scores;
    public BowlingPlayer() {
        scores = new int[10, 2];
      
    }
    public bool AddScore(int turno, int tirada, int score) {

        if (tirada == 0 && score > 10) return false;
        if (tirada == 1 && (scores[turno, 0] + score) > 10) return false;

        scores[turno, tirada] = score;
        return true;
    }
    public void AddAllScores(int[,] scores) {
        this.scores = scores;
    }
    public int GetScore(int turno, int tirada) {
        return scores[turno, tirada];
    }
    public int[,] GetScores() {
        return scores;
    }
    public void Simulate()
    {
        for (int i = 0; i < 10; i++)
        {
            int primerTirada = Random.Range(0, 11);
            int segundaTirada = Random.Range(0, 11 - primerTirada);
            AddScore(i, 0, primerTirada);
            AddScore(i, 1, segundaTirada);
        }
    }
    public int GetTotalScore() {

        int backTurn;
        int score = 0;
        for (int turn = 0; turn < scores.GetLength(0); turn++)
        {
            backTurn = turn - 1;
            // check if strike
            if (turn > 0 && scores[backTurn, 0] == 10)
                score += scores[turn, 0] + scores[turn, 1];

            // check if spare
            else if (turn > 0 && scores[backTurn, 0] + scores[backTurn, 1] == 10)
                score += scores[turn, 0];

            for (int lot = 0; lot < scores.GetLength(1); lot++)
                score += scores[turn, lot];
        }
        return score;
    }
}

public class ScoreData{
    public int turno;
    public int tirada;
    public int score;
    public BowlingPlayer player;

    public ScoreData(int turno, int tirada, int score, BowlingPlayer player) {
        this.turno = turno;
        this.tirada = tirada;
        this.score = score;
        this.player = player;
    }
}