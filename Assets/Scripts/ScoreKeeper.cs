using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;

    public int GetScore() { return score; }
    public void AddScore(int _score)
    {
        score += _score;
        Math.Clamp(score, 0, int.MaxValue);
        Debug.Log(score);
    }
    public void ResetScore() { score = 0; }

}
