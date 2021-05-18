using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stats : MonoBehaviour
{
    public int Attack = 1;
    public int Defence = 1;
    public int Tolerance = 1;
    public int Health = 10;
    public int Mana = 10;
    public int Level = 1;
    public int Exp = 0;
    public int SkillPoints = 10;
    public Text attack;
    public Text def;
    public Text tol;
    public Text hp;
    public Text mp;
    public Text lvl;
    public Text xp;
    public Text sp;
    public Base loadzone;
    public Granny granny;
    public bool haveCat;
    public string scene;
    public GameObject PauseScreen;
    public static bool PauseOpen = false;


    void Start()
    {
        scene = loadzone.scene;
    }
    void Awake()
    {
        attack.text = ""+Attack;
        def.text = ""+Defence;
        tol.text = ""+Tolerance;
        hp.text = ""+Health;
        mp.text = ""+Mana;
        lvl.text = ""+Level;
        xp.text = ""+Exp;
        sp.text = ""+SkillPoints;
        
    }
    public void LevelUp()
    {
        Level++;
        SkillPoints++;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseOpen)
            {
                PauseScreen.SetActive(false);
                PauseOpen = false;
            } 
            else
            {
                PauseScreen.SetActive(true);
                PauseOpen = true;
            }
        }
    
    }
    public void AttackUp()
    {
        if(SkillPoints > 0)
        {
            Attack++;
            SkillPoints--;
        }
        Awake();
    }
    public void DefenceUp()
    {
        if(SkillPoints > 0)
        {
            Defence++;
            SkillPoints--;
        }
        Awake();
    }
    public void ToleranceUp()
    {
        if(SkillPoints > 0)
        {
            Tolerance++;
            SkillPoints--;
        }
        Awake();
    }
    public void HealthUp()
    {
        if(SkillPoints > 0)
        {
            Health+= 10;
            SkillPoints--;
        }
        Awake();
    }
    public void ManaUp()
    {
        if(SkillPoints > 0)
        {
            Mana+= 5;
            SkillPoints--;
        }
        Awake();
    }

    public void AttackDown()
    {
        if(Attack > 1)
        {
            Attack--;
            SkillPoints++;
        }
        Awake();
    }
    public void DefenceDown()
    {
        if(Defence > 1)
        {
            Defence--;
            SkillPoints++;
        }
        Awake();
    }
    public void ToleranceDown()
    {
        if(Tolerance > 1)
        {
            Tolerance--;
            SkillPoints++;
        }
        Awake();
    }
    public void HealthDown()
    {
        if(Health > 10)
        {
            Health-= 10;
            SkillPoints++;
        }
        Awake();
    }
    public void ManaDown()
    {
        if(Mana > 5)
        {
            Mana-= 5;
            SkillPoints++;
        }
        Awake();
    }



    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Level = data.level;
        Attack = data.attack;
        Defence = data.defence;
        Tolerance = data.tolerance;
        Mana = data.mana;
        Health = data.health;
        Exp = data.xp;
        SkillPoints = data.skillpoints;
        scene = data.scene;
        haveCat = data.haveCat;
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    


}
