using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Bcolor : MonoBehaviour
{
    #region stats

    [Header("Color")]
    public Color color;

    [Header("References")]
    public Image uiImage;
    public Player myPlayer;
    #endregion

    #region Functions
    private void Start()
    {
        uiImage.color = color;
    }
    private void OnValidate()
    {
        uiImage = GetComponent<Image>();
    }
    public void OnClick()
    {
        myPlayer.ChangeColor(color);
    }
    #endregion
}