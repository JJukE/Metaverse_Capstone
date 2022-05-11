using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Chuck : MonoBehaviour
{
    Button button;
    GameObject chuck, chuckcover, mainshaft, servomotor, spindleswitch, spindle;
    public bool istransparent = false;
    public float alpha1 = 0.0f;
    public float alpha2 = 1.0f;

    // Start is called before the first frame update

    public void ButtonOn()
    {
        //Debug.Log("Button ON");
        if (istransparent == false)
        {
            changeAlpha(chuck.GetComponent<Renderer>().material, alpha1);
            changeAlpha(chuckcover.GetComponent<Renderer>().material, alpha1);
            changeAlpha(mainshaft.GetComponent<Renderer>().material, alpha1);
            changeAlpha(servomotor.GetComponent<Renderer>().material, alpha1);
            changeAlpha(spindleswitch.GetComponent<Renderer>().material, alpha1);
            changeAlpha(spindle.GetComponent<Renderer>().material, alpha1);
            //mainbody.GetComponent<Transform>().Translate(-1, 0, 0);
            istransparent = true;
        }
        else
        {
            changeAlpha(chuck.GetComponent<Renderer>().material, alpha2);
            changeAlpha(chuckcover.GetComponent<Renderer>().material, alpha2);
            changeAlpha(mainshaft.GetComponent<Renderer>().material, alpha2);
            changeAlpha(servomotor.GetComponent<Renderer>().material, alpha2);
            changeAlpha(spindleswitch.GetComponent<Renderer>().material, alpha2);
            changeAlpha(spindle.GetComponent<Renderer>().material, alpha2);
            //mainbody.GetComponent<Transform>().Translate(1, 0, 0);
            istransparent = false;
        }
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonOn);
        chuck = GameObject.Find("MCT - Chuck-1");
        chuckcover = GameObject.Find("MCT - ChuckCover-1");
        mainshaft = GameObject.Find("MCT - MainShaft-1");
        servomotor = GameObject.Find("MCT - ServoMotorZ-1");
        spindleswitch = GameObject.Find("MCT - SpindleSwitch-1");
        spindle = GameObject.Find("MCT - Spindle-1");
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
