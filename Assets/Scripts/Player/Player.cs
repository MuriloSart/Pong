using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int maxPoints = 10;
    public float speed = 10f;

    [Header("References")]

    public Rigidbody2D myRigidbody2D;
    public Image uiPlayer;
    public string nickName;


    [Header("Keys")]

    public KeyCode MoveUp = KeyCode.UpArrow;
    public KeyCode MoveDown = KeyCode.DownArrow;

    [Header("Points")]

    public int currentPoints;
    public TextMeshProUGUI uiTextPoints;

    void Awake()
    {
        ResetPlayer();
    }
    private void ResetPlayer()
    {
        currentPoints = 0;
        UpdateUI();
        Debug.Log("Pontos Resetados");
    }
    public void SetName(string s)
    {
        nickName = s;
    }
    void Update()
    {
        if (Input.GetKey(MoveUp))
            myRigidbody2D.MovePosition(transform.position + transform.up * speed * Time.deltaTime * (80));
        else if (Input.GetKey(MoveDown))
            myRigidbody2D.MovePosition(transform.position + transform.up * -speed * Time.deltaTime * (80));
    }
    public void ChangeColor(Color c)
    {
        uiPlayer.color = c;
    }
    public void ChangeImage(Image s)
    {
        uiPlayer.sprite = s.sprite;
    }
    public void AddPoint()
    {
        currentPoints++;
        CheckMaxPoint();
        UpdateUI();
    }
    public void UpdateUI()
    {
        uiTextPoints.text = currentPoints.ToString();
    }
    public void CheckMaxPoint()
    {
        if (currentPoints >= maxPoints)
        {
            currentPoints = 0;
            
            GameManager.Instance.EndGame();
            HighscoreManager.Instance.SavePlayerwin(this);
        }
    }
}

