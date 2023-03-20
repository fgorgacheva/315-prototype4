using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionTimer : MonoBehaviour
{
    public GameObject blackScreen;
    public GameObject message;
    public GameObject instructions;
    private int clickCount = 0;
    public GameObject bunny;

    // Start is called before the first frame update
    void Start()
    {
        instructions.active = false;
        blackScreen.active = true;
        message.active = true;
    }

    void Update()
    {
        
       if (Input.GetMouseButtonDown(0))
       {
            clickCount++;
            switch(clickCount) 
            {
                case 1:
                    message.active = false;
                    instructions.active = true;
                    break;
                case 2:
                    this.gameObject.active = false;
                    bunny.active = true;
                    break;
            }
       }
    }
}
