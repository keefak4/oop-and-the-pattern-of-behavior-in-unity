using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour , IControlobor
{
    public void Move()
    {
        Run();
    }

    public void Run()
    {
        Debug.Log(message:"Character Run"); 
    }
    public void Walk()
    {
        Debug.Log(message: "Character Walk");

    }
}
