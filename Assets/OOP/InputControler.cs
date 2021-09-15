using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControler : MonoBehaviour
{
    private IControlobor controlobor;
    public GameObject go;
    private void Start()
    {
        controlobor = go.GetComponent<IControlobor>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            controlobor.Move();
        }
    }
}
