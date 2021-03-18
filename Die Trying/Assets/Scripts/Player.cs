using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text HealthText;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = SharedData.health;
    }

    // Update is called once per frame
    void Update()
    {
        
        HealthText.text = "Score: " + currentHealth;
    }
}
