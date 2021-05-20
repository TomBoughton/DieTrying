using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VenusFlyTrap : MonoBehaviour
{
    
    public GameObject textbox;
    public int x = 0;
    public Text sonText;
    public GameObject battleScene;
    public GameObject gameScene;
    
    
    public Stats lindza;
    

    private void OnTriggerEnter(Collider ccc)
    {
        textbox.SetActive(true);
        x++;
        
    }


    void Update()
    {
        if(x == 1)
        {
            sonText.text = "*You see a face in the window of the house with the odd plant sprawling out of it*";
        }
        else if(x == 2)
        {
            sonText.text = "???: Help me!";
        }
        else if(x == 3)
        {
            sonText.text = "*The person frantically bangs on the door*";
        }
        else if(x == 4)
        {
            sonText.text = "You: What's wrong? What do you want me to do? Who are you?";
        }
        else if(x == 5)
        {
            sonText.text = "Shamans' Son: I'm the son of the shaman! I moved into this house a few weeks ago, but this big venus fly trap is keeping me prisoner here! Please kill it!";
        }
        else if(x == 6)
        {
            sonText.text = "You: Well, I need to talk to you about finding your dad, so I suppose I better kill it for you!";
        }
        else if(x == 7)
        {
            
            battleScene.SetActive(true);
            gameScene.SetActive(false);
            textbox.SetActive(false);
            lindza.LoadPlayer();
            
        }
        else if(x == 8)
        {
            sonText.text = "Shamans' Son: Wow! That was incredible. You might be the Viboros...";
        }
        else if(x == 9)
        {
            sonText.text = "You: Viboros? What's that?";
        }
        else if(x == 10)
        {
            sonText.text = "Shamans' Son: Viboros means saviour in an ancient language. It is told that one day a selfless fighter with an inner demon will save the realm of spirits.";
        }
        else if(x == 11)
        {
            sonText.text = "You: Realm of spirits?";
        }
        else if(x == 12)
        {
            sonText.text = "Shamans' Son: A plane that runs horizontal with ours. It is said that there are some links between our world and theirs, if you could find it you could certianly become the viboros";
        }
        else if(x == 13)
        {
            sonText.text = "You: What if I don't want to become the viboros? What if I just want this parasite removed from me?";
        }
        else if(x == 14)
        {
            sonText.text = "Shamans' Son: If you don't want to save the realm of spirits, then that is your choice. My father can remove your unwanted guest, but you will need to defeat him in battle";

        }
        else if(x == 15)
        {
            sonText.text = "You: Ok! That should be easy. I'll go and do that now.";
        }
        else if(x == 16)
        {
            sonText.text = "*The Shamans' son laughs heartily*";
        }
        else if(x == 17)
        {
            sonText.text = "Shamans' Son: You amumse me, viboros. You will need better weapons to defeat my father in battle. A dwavern weapon, with the appropriate charging crystal should do the trick.";
        }
        else if(x == 18)
        {
            sonText.text = "You: OK, got it. Dwarf weapon. Byeeee, thanks for the help!";
        }
        else if(x == 19)
        {
            sonText.text = "Shamans' Son: I haven't told you where to find them yet!";
        }
        else if(x == 20)
        {
            sonText.text = "You: I'm sure I'll work it out. Byeee!";
        }
        else if(x == 21)
        {
            sonText.text = "*This is the end of the test build for Die Trying.*";
        }


    }


    public void Clicked()
    {
        x++;
    }
}
