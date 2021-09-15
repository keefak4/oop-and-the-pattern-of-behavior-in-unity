using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorIdle : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log(message: "Enter Idle Behacior");
    }

    public void Exit()
    {
        Debug.Log(message: "Exit Idle Behacior");
    }

    public void Update()
    {
        Debug.Log(message: "Update Idle Behacior");
    }
}
