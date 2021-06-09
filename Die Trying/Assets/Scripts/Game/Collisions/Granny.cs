using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Granny : MonoBehaviour
{
    
    public Text grannyText;
    public bool haveCat;
    public GameObject roadblock;
    public GameObject textbox;
    public Stats player;
    public GameObject cam;
    private bool talked = false;
    int x = 0;

    private void OnTriggerEnter(Collider other)
    {
        textbox.SetActive(true);
        cam.GetComponent<Controller>().enabled = false;
        x = 1;
        if(player.haveCat == true)
        {
            //x = 100;
        }
        if(talked == true)
        {
            x = 50;
        }   
    }


    void Update()
    {
        if(x == 1)
        {
            grannyText.text = "*As you approach the madly rocking woman, she looks up, and she stops shouting*";
        }
        else if(x == 2)
        {
            grannyText.text = "You: Why are you shouting? Is it to do with your face?";
        }
        else if(x == 3)
        {
            grannyText.text = "*She turns from looking distraught to incredibly annoyed* ";
        }
        else if(x == 4)
        {
            grannyText.text = "Old Lady: You cheeky little... I'll have you know the reason I look like this is because I was made very close to a deadline. You had weeks to be perfected, and you still look like that";
        }
        else if(x == 5)
        {
            grannyText.text = "*You also become annoyed, because you know that your rigging was an absolute nightmare*";
        }
        else if(x == 6)
        {
            grannyText.text = "You: Anyways... What's wrong? Can I help";
        }
        else if(x == 7)
        {
            grannyText.text = "Old Lady: Awh, you're kinder than you seem. My beautiful kitty has run off. I'm so worried about her...";
        }
        else if(x == 8)
        {
            grannyText.text = "You: Well, I could go and look for her?";
        }
        else if(x == 9)
        {
            grannyText.text = "Old Lady: You would do that? I would be forever grateful if you found my poor little kitty.";
        }
        else if(x == 10)
        {
            grannyText.text = "You: Sure! I'll go and look for it now";
             
        }
        else if(x == 11)
        {
            talked = true;
            textbox.SetActive(false);
            roadblock.SetActive(false);
            cam.GetComponent<Controller>().enabled = true;   
        }

        else if(x == 50)
        {
            grannyText.text = "Old Lady: Have you found my cat yet?";
        }
        else if(x == 51)
        {
            grannyText.text = "You: Oh, sorry. I thought you might say something funny if I talked to you again. I'll go find your cat";
             
        }
        else if(x == 52)
        {
            textbox.SetActive(false);
            roadblock.SetActive(false);
            cam.GetComponent<Controller>().enabled = true;     
        }

        
        if(x == 100)
        {
            grannyText.text = "*You return to the old lady, return her cat, and quickly recap what happened*";
        }
        else if(x == 101)
        {
            grannyText.text = "Old Lady: Oh no lassie. Are you 100% sure thats what happened?";
             
        }
        else if(x == 102)
        {
            grannyText.text = "You: Yeah, thats what happened. I can feel... whatever it is moving up and down my arm.";
             
        }
        else if(x == 103)
        {
            grannyText.text = "Old Lady: In that case, I'm afraid you have become... Corrupted";
             
        }
        else if(x == 104)
        {
            grannyText.text = "You: Corrupted?? What does that mean??";
             
        }
        else if(x == 105)
        {
            grannyText.text = "Old Lady: It happened to my husband. A green worm-like thing attacked him, and he grew sicker and sicker, before eventually passing away. But the strange thing is, once he died, he was brought back to life";
             
        }
        else if(x == 106)
        {
            grannyText.text = "after a big green flash. He seemed almost stronger after that. But after a few days, he passed again, that time for good. Luckily for you, I've been researching this phenomenon ever since, and have found someone who can fix your problem.";
             
        }
        else if(x == 107)
        {
            grannyText.text = "You: Who? I don't want this thing in me";
             
        }
        else if(x == 108)
        {
            grannyText.text = "Old Lady: There are rumour of a shaman in a place, far out of the village. I understand his son lives in a house at the end of Grassy Gardens. You should go and speak to him.";
             
        }
        else if(x == 109)
        {
            grannyText.text = "You: Thank you. I'll go find him now. And again, sorry that you look like that.";
             
        }
        else if(x == 110)
        {
            grannyText.text = "Old Lady: Oi, I'm doing you a favour telling you what I know! And also, I like how I look. I may not be perfect, but I find that gives me a certain charm.";
             
        }
        else if(x == 111)
        {
            grannyText.text = "You: Righttttt. Well thanks anyway, I'll see you around.";
             
        }
        else if(x == 112)
        {
            textbox.SetActive(false);
            roadblock.SetActive(false);
            cam.GetComponent<Controller>().enabled = true;   
        }
    }
    
    public void Clicked()
    {
        x++;
    }


}
