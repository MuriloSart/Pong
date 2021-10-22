using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bcolors : MonoBehaviour
{
    public GameObject newGameObject;
    public GameObject newGameObject2;

    public bool Active = false;

    public void Awake()
    {
        Hide();
    }
    public void OnClick()
    {
        if (!Active) Show();

        else if (Active) Hide();
    }

    public void Show()
    {
        newGameObject.SetActive(true);
        newGameObject2.SetActive(true);
        Active = true;
    }

    public void Hide()
    {
        newGameObject.SetActive(false);
        newGameObject2.SetActive(false);
        Active = false;
    }
}
