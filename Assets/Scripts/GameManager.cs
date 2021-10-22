using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public float timeToFree = 1f;
    
    public static GameManager Instance;
    public StateMachine stateMachine;

    [Header("Menus")]

    public GameObject uiEndGame;
    public void Awake()
    {
        Instance = this;
    }

    public void ResetBall()
    {
        ball.CanMove(false);
        ball.ResetBall();
        Invoke(nameof(SetBallFree), timeToFree);
    }

    public void SetBallFree()
    {
        ball.CanMove(true);
    }

    public void StartGame()
    {
        ResetBall();
    }

    public void EndGame()
    {
        stateMachine.SwitchState(StateMachine.States.END_GAME);
    }

    public void ShowMainMenu()
    {
        uiEndGame.SetActive(true);
        Invoke(nameof(BallCantMove), timeToFree*1.1f);
    }

    public void BallCantMove()
    {
        ball.CanMove(false);
    }

}
