using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car : MonoBehaviour,IControlobor
{
    public  void Move()
    {
        Drive();
    }
    public virtual void Drive()
    {
        Debug.Log(message: "Car is driving");
    }
}
