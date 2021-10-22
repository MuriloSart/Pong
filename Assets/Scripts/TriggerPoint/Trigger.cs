using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Player player;
    public string tagOfBall = "Ball";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == tagOfBall)
        {
            CountPoint();
        }
    }
    private void CountPoint()
    {
        StateMachine.Instance.ResetPosition();
        player.AddPoint();
    }
}
