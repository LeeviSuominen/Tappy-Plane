using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   public static int score = 0;

   public static int userHighScore = 0;
   private static int bestScore = 0;

   [SerializeField] private TMP_Text scoreText;
   [SerializeField] private TMP_Text bestScoreText;
   [SerializeField] private TMP_Text userNameText;
   [SerializeField] private TMP_Text userHighScoreText;

private void Start() {
   userHighScore = SaveManager.instance.LoadUserHighScore();
   bestScore = SaveManager.instance.LoadData();
}
   private void Update() {
    if(scoreText != null)
    {
    scoreText.text = $"PISTEET: {score}";
    }

    if(userHighScoreText != null){
      userHighScoreText.text = $"SINUN PARAS | {userHighScore.ToString()}";
    }

    if (bestScoreText != null){
          bestScoreText.text = $"ALLTIME PARAS | {bestScore.ToString()}";
    }

    if(userNameText != null){
      userNameText.text = $"SINUN NIMI: {PlayerPrefs.GetString("username")}";
    }
   }

public static int GetUserHighScore() => userHighScore;
   public static int GetBestScore() => bestScore;
}
