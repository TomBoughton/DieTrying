using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PyramidMachinePuzzle : MonoBehaviour
{
    public GameObject sswitchOn;
    public GameObject sswitchOff;
    public GameObject leverUp;
    public GameObject leverDown;
    private bool leverSetting;
    private bool sswitchSetting;
    private string buttonSetting;
    public Text TextBox;
    // Start is called before the first frame update
    void Start()
    {
        TextBox.text = ("There are a series of buttons, switches and levers here. The switch and lever must be in their correct positions, and only one button is correct");
    }

    // Update is called once per frame
    void Check()
    {
        if(sswitchSetting == true && leverSetting == false && buttonSetting == "bird")
        {
            TextBox.text = ("You hear a clicking noise, then grinding, then the archeologist cursing. A door in the room opens");
            Invoke("Fineshed", 5);
        }
        else
        {
            Wrong();
        }
    }

    public void ClickOn()
    {
        sswitchOn.SetActive(false);
        sswitchOff.SetActive(true);
        sswitchSetting = false;
    } 

    public void ClickOff()
    {
        sswitchOn.SetActive(true);
        sswitchOff.SetActive(false);
        sswitchSetting = true;
    } 

    public void LeverUp()
    {
        leverUp.SetActive(false);
        leverDown.SetActive(true);
        leverSetting = false;
    } 

    public void LeverDown()
    {
        leverUp.SetActive(true);
        leverDown.SetActive(false);
        leverSetting = true;
    }

    public void AnkhClicked()
    {
        buttonSetting = "ankh";
        Check();
    }   

    public void BirdClicked()
    {
        buttonSetting = "bird";
        Check();
    }    

    public void FeatherClicked()
    {
        buttonSetting = "feather";
        Check();
    }
    void Wrong()
    {
        int x = 0;
        if(sswitchSetting != true)
        {
            x++;
        }
        if(leverSetting == true)
        {
            x++;
        }
        if(buttonSetting != "bird")
        {
            x++;
        }
        TextBox.text =("You got "+x+" of the components wrong. Try again.");
    }
    void Reset()
    {
        buttonSetting = "";
        LeverDown();
        ClickOn();
    } 
    void Fineshed()
    {
        SceneManager.LoadScene("Game");
    }
}
