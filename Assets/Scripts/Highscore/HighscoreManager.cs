using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreManager : MonoBehaviour
{
    public static HighscoreManager Instance;

    private string keyToSave = "keyHighscore";

    [Header("References")]
    public TextMeshProUGUI uiTextHighscore;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        UpadateText();
    }

    private void UpadateText()
    {
        uiTextHighscore.text = PlayerPrefs.GetString(keyToSave, "sem highscore");
    }

    public void SavePlayerwin(Player p)
    {
        if (p.nickName == "") return;
        PlayerPrefs.SetString(keyToSave, p.nickName);
        UpadateText();
    }
}
