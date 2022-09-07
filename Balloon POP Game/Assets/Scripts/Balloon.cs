using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3; // How many clicks until the ballloon pops
    public float scaleToIncrease = 0.10f; // Each time the balloon is clicked inflate 10%



    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnMouseDown()
    {
        clickToPop -= 1; // Reduce clicks by one

        //Inflate the balloon a certain amount every time it is click on
        transform.localScale += Vector3.one * scaleToIncrease;

        // Check to see if clickToPop has reached zero. If it has then pop balloon
        if(clickToPop == 0)
        {
            Destroy(gameObject);
        }
        
       
    }
}
