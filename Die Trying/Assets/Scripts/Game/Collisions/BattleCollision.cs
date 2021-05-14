using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCollision : MonoBehaviour
{
    public bool inTrigger;
    public GameObject battleScene;
    public GameObject gameScene;
    public GameObject lindza;
    
    private void OnTriggerEnter(Collider other)
    {
        
        inTrigger = true;
        
    }

    void Update()
    {
        int x = Random.Range(1,10000);
        if(inTrigger == true && x == 74)
        {
           battleScene.SetActive(true);
           gameScene.SetActive(false);
           lindza.SetActive(false);
        }
    }
}
