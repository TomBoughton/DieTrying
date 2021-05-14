using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipePuzzle : MonoBehaviour
{
    private int numParts;
    public GameObject pipes;
    private int degrees = 90;
    private int x = 0;
    private List<Quaternion> originalRotations = new List<Quaternion>();
    private List<Quaternion> playerRotations = new List<Quaternion>();
    public int a;
    void Start()
    {
        numParts = pipes.transform.childCount;
        for (int i = 0; i < numParts; i++)
        {
            originalRotations.Add(pipes.transform.GetChild(i).gameObject.transform.rotation);
        }
        
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
        AfterClick();
    }

    void Update()
    {
        
    }

    void AfterClick()
    {
        for (int i = 0; i < numParts; i++)
        {
            playerRotations.Add(pipes.transform.GetChild(i).gameObject.transform.rotation);
        }
        
        for (int i = 0; i < numParts; i++)
        {
            if(playerRotations[i] == originalRotations[i])
            {
                a++;
            }
           
        }
        Debug.Log(playerRotations[0]);
        if(a>=numParts)
        {
            Debug.Log("aaaaaaaa");
        }
        
        
    }

}
