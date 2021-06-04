using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingModel
{
    public BowlingModel() {
    }

    public void SetScore(ScoreData data)
    {

    }
    public void Throw()
    {

    }
}
public class BowlingPlayer
{
    private int[,] scores;

    public BowlingPlayer() {
        scores = new int[10,2];
    }
    public void AddScore(int turno, int tirada, int score) {
        scores[turno, tirada] = score;
    }
}

public class ScoreData{
    int turno;
    int tirada;
    int score;
    int player;
}