using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBowlingView
{
    void SetScore(ScoreData data);
    void Throw();
}
