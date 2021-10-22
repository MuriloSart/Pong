using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeNameBase : MonoBehaviour
{
    private string nickName;

    [Header("References")]
    public TextMeshProUGUI uiTextName;
    public TMP_InputField uiInputField;
    public GameObject changeNameInputField;
    public Player player;

    void Start()
    {
        
    }

    public void ChangeName()
    {
        nickName = uiInputField.text;
        uiTextName.text = nickName;
        changeNameInputField.SetActive(false);
        player.SetName(nickName);
    }
}
