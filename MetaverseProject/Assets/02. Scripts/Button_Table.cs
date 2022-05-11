using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Table : MonoBehaviour
{
    Button button;
    public bool istransparent = false;
    public float alpha1 = 0.0f;
    public float alpha2 = 1.0f;
    GameObject table, tablecover1, tablecover2, tablecover3, tablecover4, tablecover5, tablecover6;
    GameObject tablecover7, tablecover8, tablecover9, tablecover10;
    // Start is called before the first frame update

    public void ButtonOn()
    {
        //Debug.Log("Button ON");
        if (istransparent == false)
        {
            changeAlpha(table.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover1.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover2.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover3.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover4.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover5.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover6.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover7.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover8.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover9.GetComponent<Renderer>().material, alpha1);
            changeAlpha(tablecover10.GetComponent<Renderer>().material, alpha1);
            istransparent = true;
        }
        else
        {
            changeAlpha(table.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover1.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover2.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover3.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover4.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover5.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover6.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover7.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover8.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover9.GetComponent<Renderer>().material, alpha2);
            changeAlpha(tablecover10.GetComponent<Renderer>().material, alpha2);
            istransparent = false;
        }
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonOn);
        table = GameObject.Find("MCT - Table-1");
        tablecover1 = GameObject.Find("MCT - TableCover1-1");
        tablecover2 = GameObject.Find("MCT - TableCover2-1");
        tablecover3 = GameObject.Find("MCT - TableCover3-1");
        tablecover4 = GameObject.Find("MCT - TableCover4-1");
        tablecover5 = GameObject.Find("MCT - TableCover5-1");
        tablecover6 = GameObject.Find("MCT - TableCover6-1");
        tablecover7 = GameObject.Find("MCT - TableCover7-1");
        tablecover8 = GameObject.Find("MCT - TableCover8-1");
        tablecover9 = GameObject.Find("MCT - TableCover9-1");
        tablecover10 = GameObject.Find("MCT - TableCover10-1");
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
