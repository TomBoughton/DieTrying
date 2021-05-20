using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    
    public Text catText;
    public GameObject textbox;
    public Granny granny;
    public GameObject cat;
    public Stats player;
    int x = 0;

    private void OnTriggerEnter(Collider other)
    {
        textbox.SetActive(true);
        x = 1;   
    }


    void Update()
    {
        if(x == 1)
        {
            catText.text = "*You slowly sneak up on the... Cat? It doesn't look like a cat. It hasn't got legs for starters*";
        }
        else if(x == 2)
        {
            catText.text = "Cat(?): Miaow";
        }
        else if(x == 3)
        {
            catText.text = "You: If you are a cat, you are definitley the ugliest cat I've ever seen. Come on lets get you...";
        }
        else if(x == 4)
        {
            catText.text = "*The cat wretches, and just as you see a streak of green, it jumps onto your arm, and starts burrowing down into the skin*";
        }
        else if(x == 5)
        {
            catText.text = "You: *Clears Throat* AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH!";
        }
        else if(x == 6)
        {
            catText.text = "*You pick up the 'cat' and decide to head back to the old lady, and tell her about what happened*";
        }
        else if(x == 7)
        {
            player.GetCat();
            textbox.SetActive(false);
            
            cat.SetActive(false);
            
        }
    }
    
    public void Clicked()
    {
        x++;
    }


}
