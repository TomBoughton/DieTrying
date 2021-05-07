using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BookPuzzle : MonoBehaviour
{

    public Text TextBox;
    
    public GameObject space1;
    public GameObject space2;
    public GameObject space3;
    public GameObject space4;
    public GameObject space5;
    public GameObject redBook;
    public GameObject blueBook;
    public GameObject yellowBook;
    public GameObject purpleBook;
    public GameObject greenBook;
    public int x = 0;
    public GameObject currentBook;
    public GameObject[] playerOrder;
    public GameObject[] correctOrder;
    public Vector2 redBookPos;
    public Vector2 blueBookPos;
    public Vector2 yellowBookPos;
    public Vector2 purpleBookPos;
    public Vector2 greenBookPos;
    public GameObject empty;
    public bool canClick = true;

    
    
    

    void Start()
    {
        TextBox.text =("There are five books here. If they are placed in the correct order, You will get the key you need.");
        currentBook = space1;
        SetPos();
        
        
    }

    void Update()
    {
        
        
        
    }

    public void BlueClicked()
    {
        if(canClick == true)
        {
            Vector2 z = currentBook.transform.position;
            blueBook.transform.position = new Vector2(z.x,z.y);
            playerOrder[x] = blueBook;
            x++;
            canClick = false;
            Increment();
            ResetClick();
        }
            
    }

    public void GreenClicked()
    {
        if(canClick == true)
        {
            Vector2 z = currentBook.transform.position;
            greenBook.transform.position = new Vector2(z.x,z.y);
            playerOrder[x] = greenBook;
            x++;
            canClick = false;
            Increment();
            ResetClick();
        }
  
    }

    public void RedClicked()
    {
        if(canClick == true)
        {
            Vector2 z = currentBook.transform.position;
            redBook.transform.position = new Vector2(z.x,z.y);
            playerOrder[x] = redBook;
            x++;
            canClick = false;
            Increment();
            ResetClick();
        }
    }

    public void YellowClicked()
    {
        if(canClick == true)
        {
            Vector2 z = currentBook.transform.position;
            yellowBook.transform.position = new Vector2(z.x,z.y);
            playerOrder[x] = yellowBook;
            x++;
            canClick = false;
            Increment();
            ResetClick();
        }
    }
    public void PurpleClicked()
    {
        if(canClick == true)
        {
            Vector2 z = currentBook.transform.position;
            purpleBook.transform.position = new Vector2(z.x,z.y);
            playerOrder[x] = purpleBook;
            x++;
            canClick = false;
            Increment();
            ResetClick();
        }
    }

    void Increment()
    {
        if(x==5)
        {
            Check();
        }

        
        if (x == 0)
        {
            currentBook = space1;
        }
        if (x == 1)
        {
            currentBook = space2;
        }
        if (x == 2)
        {
            currentBook = space3;
        }
        if (x == 3)
        {
            currentBook = space4;
        }
        if (x == 4)
        {
            currentBook = space5;
        }

        
    }

    void Check()
    {
        if(playerOrder[0] == correctOrder[0] && playerOrder[1] == correctOrder[1] && playerOrder[2] == correctOrder[2] && playerOrder[3] == correctOrder[3] && playerOrder[4] == correctOrder[4])
        {
            TextBox.text = ("The bookshelf stays in tact, and you hear the cabinet swing open, revealing the Snake Key.");
            Invoke("Fineshed",5);
        }

        else
        {
            x = 0;
            currentBook = space1;
            WrongText();
        }
    }


    void WrongText()
    {
        int numCorrect = 0;
        for (int i = 0; i < 5; i++) 
        {
            if (playerOrder[i] == correctOrder[i])
            {
                numCorrect++;
            }


        }
        TextBox.text = ("There are "+numCorrect+" books in their correct place");
        if(playerOrder[0] != correctOrder[0] && playerOrder[1] != correctOrder[1] && playerOrder[2] != correctOrder[2] && playerOrder[3] != correctOrder[3] && playerOrder[4] != correctOrder[4])
        {
            TextBox.text = ("All of the books fall down.");
        }
        Invoke("Restart", 4);

    }

    void Restart()

    {
        TextBox.text =("You set the books back up and try again.");
        x = 0;
        purpleBook.transform.position = purpleBookPos;
        redBook.transform.position = redBookPos;
        blueBook.transform.position = blueBookPos;
        greenBook.transform.position = greenBookPos;
        yellowBook.transform.position = yellowBookPos;
        for (int i = 0; i < 5; i++) 
        {
            playerOrder[i] = empty;
            
        }
        
    }

    void SetPos()
    {
        redBookPos = redBook.transform.position;
        blueBookPos = blueBook.transform.position;
        purpleBookPos = purpleBook.transform.position;
        yellowBookPos = yellowBook.transform.position;
        greenBookPos = greenBook.transform.position;
    }
    
    void ResetClick()
    {
        
        canClick = true;
        
    }

    void Fineshed()
    {
        SceneManager.LoadScene("Game");
    }


}