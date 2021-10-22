using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase 
{
    public virtual void OnStateEnter(object o = null)
    {

    }
    public virtual void OnStateStay()
    {

    }
    public virtual void OnStateExit()
    {

    }
}

public class StateMenu : StateBase
{
    public override void OnStateEnter(object o = null)
    {
        base.OnStateEnter(o);
        Ball b = (Ball)o;
    }

}

public class StatePlaying : StateBase
{
    public override void OnStateEnter(object o = null)
    {
        base.OnStateEnter(o);
        Ball b = (Ball)o;

        Debug.Log("Começou");
        GameManager.Instance.StartGame();
    }
}

public class StateResetBall : StateBase
{
    public override void OnStateEnter(object o = null)
    {
        base.OnStateEnter(o);
        GameManager.Instance.ResetBall();
    }
}

public class StateEndGame : StateBase
{
    public override void OnStateEnter(object o = null)
    {
        base.OnStateEnter(o);
        GameManager.Instance.ShowMainMenu();
    }
}
