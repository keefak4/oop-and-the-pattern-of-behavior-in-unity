using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorAgressive : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log(message: "Enter Agressive Behacior");
    }

    public void Exit()
    {
        Debug.Log(message: "Exit Agressive Behacior");
    }

    public void Update()
    {
        Debug.Log(message: "Update Agressive Behacior");
    }
}
