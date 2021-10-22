using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public StateBase _currentState;

    public static StateMachine Instance;

    public enum States
    {
        MENU,
        PLAYING,
        RESET_BALL,
        END_GAME
    }
    public Dictionary<States, StateBase> dictionaryState;

    public void Awake()
    {
        Instance = this;

        dictionaryState = new Dictionary<States, StateBase>();
        dictionaryState.Add(States.MENU, new StateMenu());
        dictionaryState.Add(States.PLAYING, new StatePlaying());
        dictionaryState.Add(States.RESET_BALL, new StateResetBall());
        dictionaryState.Add(States.END_GAME, new StateEndGame());

        SwitchState(States.MENU);
    }

    public void SwitchState(States state)
    {

        if (_currentState != null) _currentState.OnStateExit();
        
        _currentState = dictionaryState[state];

        if (_currentState != null) _currentState.OnStateEnter();
    }

    private void Update()
    {
        if (_currentState != null) _currentState.OnStateStay();
    }

    public void ResetPosition()
    {
        SwitchState(States.RESET_BALL);
    }
}
