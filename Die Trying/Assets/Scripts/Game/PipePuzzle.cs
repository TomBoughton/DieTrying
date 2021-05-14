using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePuzzle : MonoBehaviour
{
    private int degrees = 90;
    private int x = 0;
    public Transform[] correct;
    void Start()
    {
        
        int y = Random.Range(1,4);
        int x = y * degrees;
        if (tag != "MainCamera")
        {
            transform.eulerAngles = Vector3.forward * x;
        }
    }

    public void Clicked()
    {
        
        transform.eulerAngles = Vector3.forward * x;
        x =  x+degrees;
    }
}
