using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Bskin : MonoBehaviour
{
    #region stats
    [Header("References")]
    public Image uiImage;
    public Player myPlayer;
    #endregion

    #region Functions

    private void Start()
    {
        
    }
    public void OnClick()
    {
        myPlayer.ChangeImage(uiImage);
    }
    #endregion
}