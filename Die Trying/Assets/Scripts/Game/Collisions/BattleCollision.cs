using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCollision : MonoBehaviour
{
    public bool inTrigger;
    public GameObject battleScene;
    public GameObject gameScene;
    public GameObject lindza;
    public Granny granny;
    
    private void OnTriggerEnter(Collider other)
    {
        
        inTrigger = true;
        
    }

    void Update()
    {
        int x = Random.Range(1,100);
        if(inTrigger == true && x == 74 && Controller.StatsOpen == false && granny.haveCat == true)
        {
           battleScene.SetActive(true);
           gameScene.SetActive(false);
           
        }
    }
}
