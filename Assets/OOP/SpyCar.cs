using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyCar : Car
{
   public void SetVision(bool enabled)
    {
        Debug.Log(message: "Car vision enables" + enabled);
    }
}
