using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputContr : MonoBehaviour
{
    public Player Player;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            this.Player.SetBehaviorAgressive();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.Player.SetBehaviorActive();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.Player.SetBehaviorIdle();
        }
    }
}
