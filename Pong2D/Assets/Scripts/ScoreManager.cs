using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;

    public Text playerScoreText;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        playerScoreText.text = player1Score + " : " + player2Score;
    }

    public void ResetScores()
    {
        player1Score = 0;
        player2Score = 0;
    }
}