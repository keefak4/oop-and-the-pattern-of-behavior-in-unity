using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCar : Car
{
    public void Fly()
    {
        Debug.Log("Fly...");
    }
    public override void Drive()
    {
        Fly();     
    }
}
