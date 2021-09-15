using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorActive : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log(message: "Enter Active Behacior");
    }

    public void Exit()
    {
        Debug.Log(message: "Exit Active Behacior");
    }

    public void Update()
    {
        Debug.Log(message: "Update Active Behacior");
    }
}
