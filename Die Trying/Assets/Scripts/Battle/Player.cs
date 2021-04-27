using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text HealthText;
    public int currentHealth;
    public Text MPText;
    public int currentMP;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = BattleLoop.currentHealth;
        currentMP = BattleLoop.mp;
        HealthText.text = ""+currentHealth;
        MPText.text = ""+currentMP;
        
    }
}
