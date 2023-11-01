using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    public int highScore;
    public int userHighScore;

    private void Awake()
    {
        instance = this;
    }

    public void SaveUserHighScore(int newScore){
        if (newScore >= Score.GetUserHighScore()){
            userHighScore = newScore;
            PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "_HighScore", userHighScore);
        }
    }

    public void SaveData (int newScore){
        if(newScore > Score.GetBestScore())
        {
            highScore = newScore;
        PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public int LoadUserHighScore(){
        return PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "_HighScore");
    }

    public int LoadData(){
        return PlayerPrefs.GetInt("HighScore");
    }

    public void DeleteData(){
       PlayerPrefs.DeleteKey(PlayerPrefs.GetString("username") + "_HighScore");
    }
}
