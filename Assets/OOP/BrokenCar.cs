using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenCar : Car
{
    public override void Drive()
    {
        base.Drive();
        Debug.Log(message: "Very low...");
    }
}
