using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JunsBush : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    
    
    private void OnTriggerEnter(Collider other)
    {

        RenderSettings.skybox=mat2;
    }
}
