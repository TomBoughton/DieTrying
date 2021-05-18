using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleLoop : MonoBehaviour
{
    public Enemy enemy;
    public Stats player;
    public int currentHP;
    public int currentMP;
    public Text mp;
    public Text hp;
    public int damageDealt;
    public int corruption;
    public int enemyHealth;
    public bool done;
    public Text textbox;
    // Start is called before the first frame update
    void Awake()
    {
        player.LoadPlayer();
        currentHP = player.Health;
        currentMP = player.Mana;
        enemyHealth = enemy.enemyHealth;
        textbox.text = "What will Lindza do?";
    }

    // Update is called once per frame
    void Update()
    {
        mp.text = ""+currentMP;
        hp.text = ""+currentHP;

        
    }



    public void blAttack()
    {
        if(done)
        {
            done = false;
            int x = Random.Range(1,5);
            damageDealt = x+(player.Attack * 2)+(corruption/4);
            enemyHealth -= damageDealt;
            textbox.text = "Lindza attacked and dealt "+damageDealt+" damage.";
            Invoke("EnemyTurn", 2);
        }
        
       
    }

    public void Ability()
    {
        
        if(currentMP > 3)
        {
            if(done)
            {
                done = false;
                int x = Random.Range(1,7);
                damageDealt = x+(player.Attack * 2)+(corruption/4);
                enemyHealth -= damageDealt;
                textbox.text = "Lindza attacked and dealt "+damageDealt+" damage.";
                Invoke("EnemyTurn", 2);
            }
        }  
        else
        {
            textbox.text = "Lindza does not have enough MP to do that!";
            Invoke("EndTurn", 2);
        }     
    }

    public void Heal()
    {
        if(currentMP > 3)
        {
            if(done)
            {
                done = false;
                int x = Random.Range(4,7);
                currentHP += x;
                textbox.text = "Lindza healed herself for "+x+" health.";
                Invoke("EnemyTurn", 2);
            }
        }  
        else
        {
            textbox.text = "Lindza does not have enough MP to do that!";
            Invoke("EndTurn", 2);
        }   

    }


    public void Run()
    {
        if(done)
        {
            done = false;    
            int x = Random.Range(1,3);
            if(x == 1;)
            {
                textbox.text = "Lindza escapes!";
                Invoke("EndBattle", 3);
            }
            else
            {
                textbox.text = "Lindza tries to run, but the enemy blocks the way.";
                Invoke("EnemyTurn", 2);
            }
        }
    }


    void EnemyTurn()
    {
        if(enemyHealth <= 0)
        {
            EnemyDead();
        }
        else
        {
            int x = Random.Range(enemy.enemyMinHit,enemy.enemyMaxHit);
            currentHP =- x;
            textbox.text = "The enemy deals "+x+" damage";
            Invoke("CheckCorruption", 2);
        }
    }

    void CheckCorruption()
    {

        
    }
    void XP()
    {
        
    }
}

