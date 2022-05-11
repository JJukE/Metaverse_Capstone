using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Column : MonoBehaviour
{
    Button button;
    GameObject column, columncover1, columncover2, columncover3, columninside;
    public bool istransparent = false;
    public float alpha1 = 0.0f;
    public float alpha2 = 1.0f;

    // Start is called before the first frame update

    public void ButtonOn()
    {
        //Debug.Log("Button ON");
        if (istransparent == false)
        {
            changeAlpha(column.GetComponent<Renderer>().material, alpha1);
            changeAlpha(columncover1.GetComponent<Renderer>().material, alpha1);
            changeAlpha(columncover2.GetComponent<Renderer>().material, alpha1);
            changeAlpha(columncover3.GetComponent<Renderer>().material, alpha1);
            changeAlpha(columninside.GetComponent<Renderer>().material, alpha1);
            istransparent = true;
        }
        else
        {
            changeAlpha(column.GetComponent<Renderer>().material, alpha2);
            changeAlpha(columncover1.GetComponent<Renderer>().material, alpha2);
            changeAlpha(columncover2.GetComponent<Renderer>().material, alpha2);
            changeAlpha(columncover3.GetComponent<Renderer>().material, alpha2);
            changeAlpha(columninside.GetComponent<Renderer>().material, alpha2);
            istransparent = false;
        }
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonOn);
        column = GameObject.Find("MCT - Column-1");
        columncover1 = GameObject.Find("MCT - ColumnCover1-1");
        columncover2 = GameObject.Find("MCT - ColumnCover2-1");
        columncover3 = GameObject.Find("MCT - ColumnCover3-1");
        columninside = GameObject.Find("MCT - ColumnInside-1");
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
