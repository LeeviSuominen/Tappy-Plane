using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogIn : MonoBehaviour
{
    public static string username;
    [SerializeField] TMP_InputField inputField;
   

    public void LoadGame(){
        username = inputField.text;
        PlayerPrefs.SetString("username", username);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

}

    
