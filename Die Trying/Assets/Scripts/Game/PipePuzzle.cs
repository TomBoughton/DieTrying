using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePuzzle : MonoBehaviour
{
    
    public void Clicked()
    {
         Quaternion theRotation = gameObject.transform.rotation;
         theRotation.z *= 90;
         gameObject.transform.rotation = theRotation;
        
    }
}
