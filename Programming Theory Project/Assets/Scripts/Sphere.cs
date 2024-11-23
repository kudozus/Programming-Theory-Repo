using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeColor", 0.0f, 0.1f); //INHERITANCE & ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shapeClassP = gameObject.name; //INHERITANCE
            DisplayText(); //ABSTRACTION
            CancelInvoke(); //ABSTRACTION
        }
        if (Input.GetMouseButtonDown(1))
        {
            displayedText.SetActive(false);
            InvokeRepeating("ChangeColor", 0.0f, 0.1f); //INHERITANCE & ABSTRACTION
        }
    }

    protected override void DisplayText() //POLYMORPHISM
    {
        //Debug.Log("Overridden DisplayText Method Accessed");
        textToDisplay.text = "You have clicked a " + shapeClassP + "!"; //INHERITANCE
        displayedText.SetActive(true);
    }
}
