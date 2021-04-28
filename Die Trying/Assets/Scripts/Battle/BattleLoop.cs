using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BattleLoop : MonoBehaviour
{
    
    public static int damageDealt = 0;
    public static int enemyDamage = 0;
    public static int currentHealth = 0;
    private static int attack;
    private static int corruption;
    public Text TextBox;
    private bool done = true;
    public static int enemyHealth = 3000;
    public static int battleDamage = 0;
    public static int experince = 0;
    public static int level = 0;
    public static int mp = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        attack = SharedData.attack;
        corruption = SharedData.corruption;
        TextBox.text = "What will Lindza do?";
        currentHealth = SharedData.health;
        battleDamage = enemyHealth;
        level = SharedData.level;
        mp = SharedData.mp;
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Attack()
    {
       if (done == true)
        {
            done = false;
            var x = Random.Range(1,3);
            damageDealt = x+(attack*2)+(corruption/4);
            enemyHealth = enemyHealth - damageDealt;
            TextBox.text = "Lindza dealt "+damageDealt+ " damage!";
            Invoke("EnemyTurn", 2);
        }
       
    }

    public void Ability()
    {

        if (mp<3)
        {
            TextBox.text = "Lindza does not have enough MP!";
            Invoke("EndTurn", 2);
        }

       if (done == true && mp>=3)
        {
            done = false;
            var x = Random.Range(3,5);
            damageDealt = x+(attack*2)+(corruption/4);
            enemyHealth = enemyHealth - damageDealt;
            TextBox.text = "Lindza dealt "+damageDealt+ " damage!";
            mp = mp-3;
            Invoke("EnemyTurn", 2);
        }


       
    }

        public void Heal()
    {

        if (mp<3)
        {
            TextBox.text = "Lindza does not have enough MP!";
            Invoke("EndTurn", 2);
        }

       if (done == true && mp>=3)
        {
            done = false;
            currentHealth = currentHealth+5;
            TextBox.text = "Lindza healed herself for 5 health!";
            mp = mp-3;
            Invoke("EnemyTurn", 2);
        }


       
    }


    public void Run()
    {
        var x = Random.Range(1,4);
        if (x == 3)
        {
            TextBox.text = "Lindza ran away!";
            Invoke("EndFight", 2);
        }
        else
        {
            TextBox.text = "Lindza tries to run away, but the enemy blocks her!";
            Invoke("EnemyTurn", 2);
        }
    }

    public void EnemyTurn()
    {
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
         if (enemyHealth <= 0)
        {
          EnemyDead();  
        }
        if (enemyHealth > 0)
        {
            enemyDamage = Random.Range(1,3);
            currentHealth = currentHealth - enemyDamage;
            TextBox.text = "The enemy dealt "+enemyDamage+" damage!";
            Invoke("CheckCorruption", 2);
        }
        
       
    }

    public void EndTurn()
    {
        done = true;
        TextBox.text = "What will Lindza do?";
    }
    
    public void EnemyDead()
    {
        TextBox.text = "The foe has been slain!";
        Invoke("XPgain", 2);
    }

    public void XPgain()
    {
        SharedData.exp = battleDamage * 10;
        experince = SharedData.exp;
        TextBox.text = "Lindza has " +experince+" expirence points";
        if (level * 100 <= experince)
        {
            Invoke("LevelUp" ,2);
        }
        Invoke("EndFight", 2);


        
    }

    public void LevelUp()
    {
        SharedData.level = SharedData.exp / 100;
        TextBox.text = "Lindza leveled up! She is now level "+SharedData.level;
        Invoke("EndFight", 2);
        
    }

    public void EndFight()
    {
        SceneManager.LoadScene("Game");
    }

    public void Corrupt()
    {
        TextBox.text = "Lindza has died!! The parasite corrupts her.";
        corruption = corruption+25;
        currentHealth = SharedData.health;
        Invoke("EndTurn", 5);
        
    }

    public void CheckCorruption()
    {
         if (currentHealth <= 0)
        {
            Corrupt();
        }
        else
        {
            EndTurn();
        }

        if(corruption > SharedData.tolerance*25)
        {
            TextBox.text = "Lindza has become too corrupted, and is forced to flee";
            Invoke("EndFight", 3);
        }
    }
}
