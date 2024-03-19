using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointManager : NetworkBehaviour
{
    public static PointManager Instance;

    public AudioSource winningSound;

    public TMP_Text hostScore;
    public TMP_Text clientScore;
    public TMP_Text gameTimer;

    public GameObject winnerCanvas;
    public GameObject loserCanvas;

    private int p1Score = 0;
    private int p2Score = 0;
    private float gameDuration = 120f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // Initialize the static reference
        }
        else if (Instance != this)
        {
            Destroy(gameObject); // Ensures singleton pattern
        }

        StartCoroutine(UpdateTimer());
    }

    private void Update()
    {
        hostScore.text = p1Score.ToString();
        clientScore.text = p2Score.ToString();

        gameTimer.text = gameDuration.ToString();

        // Check if a player has reached 3 points
        if (p1Score >= 3 || p2Score >= 3)
        {
            ShowWinnerCanvas();
            StopAllCoroutines(); // Stop the timer as we have a winner
            // to stop infinte looping
            p1Score = 0;
            p2Score = 0;
        }

    }

    // Public methods to modify scores
    public void AddToP1Score(int points)
    {
        p1Score += points;
    }

    public void AddToP2Score(int points)
    {
        p2Score += points;
    }

    // Winner and loser screen controller
    private void ShowWinnerCanvas()
    {
        winnerCanvas.SetActive(true);
        Debug.Log("Attempting to play winning sound.");
        winningSound.Play();
    }

    private void ShowLoserCanvas()
    {
        loserCanvas.SetActive(true);
    }

    private IEnumerator UpdateTimer()
    {
        while (gameDuration > 0)
        {
            // Update the timer text UI every second
            gameTimer.text = $"{gameDuration} seconds";
            yield return new WaitForSeconds(1);
            gameDuration--;
        }

        // Once the timer reaches 0 and no winner, show the loser canvas
        ShowLoserCanvas();
    }
}
