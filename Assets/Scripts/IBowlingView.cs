using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBowlingView
{
    void SetScores(int[,] scorePlayer1, int[,] scorePlayer2);
    void SetScoreTotal(int totalP1, int totalP2);
}
