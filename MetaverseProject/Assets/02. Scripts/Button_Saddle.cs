using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Saddle : MonoBehaviour
{
    Button button;
    public bool istransparent = false;
    public float alpha1 = 0.0f;
    public float alpha2 = 1.0f;
    GameObject saddle, leftsaddlecover1, leftsaddlecover2, leftsaddlecover3, leftsaddlecover4, leftsaddlecover5;
    GameObject leftsaddlecover6, leftsaddlecover7, leftsaddlecover8, leftsaddlecover9, leftsaddlecover10, leftsaddlecover11;
    GameObject rightsaddlecover1, rightsaddlecover2, rightsaddlecover3, rightsaddlecover4, rightsaddlecover5;
    GameObject rightsaddlecover6, rightsaddlecover7, rightsaddlecover8, rightsaddlecover9, rightsaddlecover10, rightsaddlecover11;
    GameObject midsaddlecover1, midsaddlecover2, midsaddlecover3, midsaddlecover4, midsaddlecover5; 
    GameObject leftsaddleholder, leftsaddleinside, rightsaddleholder, rightsaddleinside, midsaddleinside;
    // Start is called before the first frame update

    public void ButtonOn()
    {
        //Debug.Log("Button ON");
        if (istransparent == false)
        {
            changeAlpha(saddle.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover1.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover2.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover3.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover4.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover5.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover6.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover7.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover8.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover9.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover10.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddlecover11.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover1.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover2.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover3.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover4.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover5.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover6.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover7.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover8.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover9.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover10.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddlecover11.GetComponent<Renderer>().material, alpha1);
            changeAlpha(midsaddlecover1.GetComponent<Renderer>().material, alpha1);
            changeAlpha(midsaddlecover2.GetComponent<Renderer>().material, alpha1);
            changeAlpha(midsaddlecover3.GetComponent<Renderer>().material, alpha1);
            changeAlpha(midsaddlecover4.GetComponent<Renderer>().material, alpha1);
            changeAlpha(midsaddlecover5.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddleholder.GetComponent<Renderer>().material, alpha1);
            changeAlpha(leftsaddleinside.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddleholder.GetComponent<Renderer>().material, alpha1);
            changeAlpha(rightsaddleinside.GetComponent<Renderer>().material, alpha1);
            changeAlpha(midsaddleinside.GetComponent<Renderer>().material, alpha1);
            istransparent = true;
        }
        else
        {
            changeAlpha(saddle.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover1.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover2.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover3.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover4.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover5.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover6.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover7.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover8.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover9.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover10.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddlecover11.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover1.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover2.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover3.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover4.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover5.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover6.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover7.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover8.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover9.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover10.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddlecover11.GetComponent<Renderer>().material, alpha2);
            changeAlpha(midsaddlecover1.GetComponent<Renderer>().material, alpha2);
            changeAlpha(midsaddlecover2.GetComponent<Renderer>().material, alpha2);
            changeAlpha(midsaddlecover3.GetComponent<Renderer>().material, alpha2);
            changeAlpha(midsaddlecover4.GetComponent<Renderer>().material, alpha2);
            changeAlpha(midsaddlecover5.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddleholder.GetComponent<Renderer>().material, alpha2);
            changeAlpha(leftsaddleinside.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddleholder.GetComponent<Renderer>().material, alpha2);
            changeAlpha(rightsaddleinside.GetComponent<Renderer>().material, alpha2);
            changeAlpha(midsaddleinside.GetComponent<Renderer>().material, alpha2);
            istransparent = false;
        }
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonOn);
        saddle = GameObject.Find("MCT - Saddle-1");
        leftsaddlecover1 = GameObject.Find("MCT - LeftSaddleCover1-1");
        leftsaddlecover2 = GameObject.Find("MCT - LeftSaddleCover2-1");
        leftsaddlecover3 = GameObject.Find("MCT - LeftSaddleCover3-1");
        leftsaddlecover4 = GameObject.Find("MCT - LeftSaddleCover4-1");
        leftsaddlecover5 = GameObject.Find("MCT - LeftSaddleCover5-1");
        leftsaddlecover6 = GameObject.Find("MCT - LeftSaddleCover6-1");
        leftsaddlecover7 = GameObject.Find("MCT - LeftSaddleCover7-1");
        leftsaddlecover8 = GameObject.Find("MCT - LeftSaddleCover8-1");
        leftsaddlecover9 = GameObject.Find("MCT - LeftSaddleCover9-1");
        leftsaddlecover10 = GameObject.Find("MCT - LeftSaddleCover10-1");
        leftsaddlecover11 = GameObject.Find("MCT - LeftSaddleCover11-1");
        rightsaddlecover1 = GameObject.Find("MCT - RightSaddleCover1-1");
        rightsaddlecover2 = GameObject.Find("MCT - RightSaddleCover2-1");
        rightsaddlecover3 = GameObject.Find("MCT - RightSaddleCover3-1");
        rightsaddlecover4 = GameObject.Find("MCT - RightSaddleCover4-1");
        rightsaddlecover5 = GameObject.Find("MCT - RightSaddleCover5-1");
        rightsaddlecover6 = GameObject.Find("MCT - RightSaddleCover6-1");
        rightsaddlecover7 = GameObject.Find("MCT - RightSaddleCover7-1");
        rightsaddlecover8 = GameObject.Find("MCT - RightSaddleCover8-1");
        rightsaddlecover9 = GameObject.Find("MCT - RightSaddleCover9-1");
        rightsaddlecover10 = GameObject.Find("MCT - RightSaddleCover10-1");
        rightsaddlecover11 = GameObject.Find("MCT - RightSaddleCover11-1");
        midsaddlecover1 = GameObject.Find("MCT - MidSaddleCover1-1");
        midsaddlecover2 = GameObject.Find("MCT - MidSaddleCover2-1");
        midsaddlecover3 = GameObject.Find("MCT - MidSaddleCover3-1");
        midsaddlecover4 = GameObject.Find("MCT - MidSaddleCover4-1");
        midsaddlecover5 = GameObject.Find("MCT - MidSaddleCover5-1");
        leftsaddleholder = GameObject.Find("MCT - LeftSaddleHolder-1");
        leftsaddleinside = GameObject.Find("MCT - LeftSaddleInside-1");
        rightsaddleholder = GameObject.Find("MCT - RightSaddleHolder-1");
        rightsaddleinside = GameObject.Find("MCT - RightSaddleInside-1");
        midsaddleinside = GameObject.Find("MCT - MidSaddleInside-1");
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
