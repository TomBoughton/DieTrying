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
    public GameObject battleScene;
    public GameObject gameScene;
    public GameObject lindza;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        player.LoadPlayer();
        currentHP = player.Health;
        currentMP = player.Mana;
        enemyHealth = enemy.enemyHealth;
        textbox.text = "What will Lindza do?";
        done = true;
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
            lindza.GetComponent<Animator>().Play("Lindza|Knee");
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
                lindza.GetComponent<Animator>().Play("Lindza|Claws");
                textbox.text = "Lindza attacked and dealt "+damageDealt+" damage.";
                
                Invoke("EnemyTurn", 2);
                currentMP -= 3;
            }
        }  
        else
        {
            textbox.text = "Lindza does not have enough MP to do that!";
            Invoke("EndTurn", 2);
            done = false;
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
            done = false;
        }   

    }


    public void Run()
    {
        if(done)
        {
            done = false;    
            int x = Random.Range(1,3);
            if(x == 1)
            {
                textbox.text = "Lindza escapes!";
                Invoke("EndFight", 3);
            }


            else
            {
                textbox.text = "Lindza tries to run, but the enemy blocks the way.";
                Invoke("EnemyTurn", 2);
                done = false;
            }
        }
    }


    void EnemyTurn()
    {
        if(enemyHealth <= 0)
        {
            textbox.text = "The foe has been slain!";
            Invoke("XP", 2);
        }
        else
        {
            int x = Random.Range(enemy.enemyMinHit,enemy.enemyMaxHit);
            currentHP = currentHP - x;
            Enemy.GetComponent<Animator>().Play("metarig|metarigAction");
            textbox.text = "The enemy deals "+x+" damage";
            Invoke("CheckCorruption", 2);
            
            
        }
    }

    void CheckCorruption()
    {
        if(currentHP <= 0)
        {
            if(corruption >player.Tolerance*25)
            {
                textbox.text = "Lindza dies, and is too corrupted to continue fighting, and has to leave the battle";
                Invoke("EndFight", 4);
            }
            else
            {
                corruption = corruption + 25;
                textbox.text = "Lindza dies, but the parasite brings her back to life, but she becomes slightly corrupted.";
                currentHP = player.Health;
                Invoke("EndTurn", 3);
            }
        }
        else
        {
            Invoke("EndTurn", 2);
        }  
    }

    void EndTurn()
    {
        textbox.text = "What will Lindza do?";
        done = true;
    }
    void EndFight()
    {
        battleScene.SetActive(false);
        gameScene.SetActive(true);
        player.SavePlayer();
        Invoke("Start", 2);
    }
    void XP()
    {
        player.Exp = player.Exp + enemy.expGiven;
        if(player.Exp >= player.Level*100)
        {
            player.LevelUp();
            textbox.text = "Lindza has leveled up! She is now level "+player.Level+" !";
            Invoke("EndFight", 3);
        }
        else
        {
            textbox.text = "Lindza has gained "+enemy.expGiven+" XP!";
            Invoke("EndFight", 3);
        }
    }

    
}

