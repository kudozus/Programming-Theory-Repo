using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    [SerializeField] private protected Renderer rendrer;
    [SerializeField] private protected GameObject displayedText;
    [SerializeField] private protected TMP_Text textToDisplay;
    private string shapeClassF;

    public string shapeClassP
    {
        get { return shapeClassF; }
        set { shapeClassF = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        displayedText = GameObject.Find("displayedText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void ChangeColor()
    {
        //Debug.Log("ChangeColor Method Accessed");
        rendrer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1.0f);
    }

    protected virtual void DisplayText()
    {
        //Debug.Log("DisplayText Method Accessed");
        displayedText.SetActive(true);
    }
}
