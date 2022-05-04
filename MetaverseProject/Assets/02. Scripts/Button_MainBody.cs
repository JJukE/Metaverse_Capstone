using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_MainBody : MonoBehaviour
{
    Button button;
    GameObject mainbody;
    GameObject leftdoor;
    GameObject rightdoor;
    public bool istransparent = false;
    public float alpha1 = 0.0f;
    public float alpha2 = 1.0f;

    // Start is called before the first frame update

    public void ButtonOn()
    {
        //Debug.Log("Button ON");
        if (istransparent == false)
        {
            changeAlpha(mainbody.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftdoor.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightdoor.GetComponent<Renderer>().material, alpha1);
            //mainbody.GetComponent<Transform>().Translate(-1, 0, 0);
            istransparent = true;
        }
        else
        {
            changeAlpha(mainbody.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftdoor.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightdoor.GetComponent<Renderer>().material, alpha2);
            //mainbody.GetComponent<Transform>().Translate(1, 0, 0);
            istransparent = false;
        }
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonOn);
        mainbody = GameObject.Find("MCT - MainBody-1");
        leftdoor = GameObject.Find("MCT - LeftDoor-1");
        rightdoor = GameObject.Find("MCT - RightDoor-1");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void changeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }
}
