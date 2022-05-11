using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_ATC : MonoBehaviour
{
    Button button;
    public bool istransparent = false;
    public float alpha1 = 0.0f;
    public float alpha2 = 1.0f;
    GameObject arm, circleplate, cover, holder, port1, port2, port3, port4, port5, port6, port7, port8, port9, port10;
    GameObject port11, port12, port13, port14, port15, port16, port17, port18, port19, port20, port21, port22, port23;
    GameObject port24, port25, port26, port27, port28, port29, port30, safetycover, wheeler;
    // Start is called before the first frame update

    public void ButtonOn()
    {
        //Debug.Log("Button ON");
        if (istransparent == false)
        {
            changeAlpha(arm.GetComponent<Renderer>().material, alpha1);
            changeAlpha(circleplate.GetComponent<Renderer>().material, alpha1);
            changeAlpha(cover.GetComponent<Renderer>().material, alpha1);
            changeAlpha(holder.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port1.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port2.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port3.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port4.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port5.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port6.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port7.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port8.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port9.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port10.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port11.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port12.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port13.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port14.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port15.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port16.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port17.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port18.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port19.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port20.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port21.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port22.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port23.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port24.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port25.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port26.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port27.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port28.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port29.GetComponent<Renderer>().material, alpha1);
            changeAlpha(port30.GetComponent<Renderer>().material, alpha1);
            changeAlpha(safetycover.GetComponent<Renderer>().material, alpha1);
            changeAlpha(wheeler.GetComponent<Renderer>().material, alpha1);
            //arm.GetComponent<Transform>().Translate(-1, 0, 0);
            istransparent = true;
        }
        else
        {
            changeAlpha(arm.GetComponent<Renderer>().material, alpha2);
            changeAlpha(circleplate.GetComponent<Renderer>().material, alpha2);
            changeAlpha(cover.GetComponent<Renderer>().material, alpha2);
            changeAlpha(holder.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port1.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port2.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port3.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port4.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port5.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port6.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port7.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port8.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port9.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port10.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port11.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port12.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port13.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port14.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port15.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port16.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port17.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port18.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port19.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port20.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port21.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port22.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port23.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port24.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port25.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port26.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port27.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port28.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port29.GetComponent<Renderer>().material, alpha2);
            changeAlpha(port30.GetComponent<Renderer>().material, alpha2);
            changeAlpha(safetycover.GetComponent<Renderer>().material, alpha2);
            changeAlpha(wheeler.GetComponent<Renderer>().material, alpha2);
            //arm.GetComponent<Transform>().Translate(1, 0, 0);
            istransparent = false;
        }
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonOn);
        arm = GameObject.Find("MCT - ATCARM-1");
        circleplate = GameObject.Find("MCT - ATCCirclePlate-1");
        cover = GameObject.Find("MCT - ATCCover-1");
        holder = GameObject.Find("MCT - ATCHolder-1");
        port1 = GameObject.Find("MCT - ATCMagazinePort1-1");
        port2 = GameObject.Find("MCT - ATCMagazinePort2-1");
        port3 = GameObject.Find("MCT - ATCMagazinePort3-1");
        port4 = GameObject.Find("MCT - ATCMagazinePort4-1");
        port5 = GameObject.Find("MCT - ATCMagazinePort5-1");
        port6 = GameObject.Find("MCT - ATCMagazinePort6-1");
        port7 = GameObject.Find("MCT - ATCMagazinePort7-1");
        port8 = GameObject.Find("MCT - ATCMagazinePort8-1");
        port9 = GameObject.Find("MCT - ATCMagazinePort9-1");
        port10 = GameObject.Find("MCT - ATCMagazinePort10-1");
        port11 = GameObject.Find("MCT - ATCMagazinePort11-1");
        port12 = GameObject.Find("MCT - ATCMagazinePort12-1");
        port13 = GameObject.Find("MCT - ATCMagazinePort13-1");
        port14 = GameObject.Find("MCT - ATCMagazinePort14-1");
        port15 = GameObject.Find("MCT - ATCMagazinePort15-1");
        port16 = GameObject.Find("MCT - ATCMagazinePort16-1");
        port17 = GameObject.Find("MCT - ATCMagazinePort17-1");
        port18 = GameObject.Find("MCT - ATCMagazinePort18-1");
        port19 = GameObject.Find("MCT - ATCMagazinePort19-1");
        port20 = GameObject.Find("MCT - ATCMagazinePort20-1");
        port21 = GameObject.Find("MCT - ATCMagazinePort21-1");
        port22 = GameObject.Find("MCT - ATCMagazinePort22-1");
        port23 = GameObject.Find("MCT - ATCMagazinePort23-1");
        port24 = GameObject.Find("MCT - ATCMagazinePort24-1");
        port25 = GameObject.Find("MCT - ATCMagazinePort25-1");
        port26 = GameObject.Find("MCT - ATCMagazinePort26-1");
        port27 = GameObject.Find("MCT - ATCMagazinePort27-1");
        port28 = GameObject.Find("MCT - ATCMagazinePort28-1");
        port29 = GameObject.Find("MCT - ATCMagazinePort29-1");
        port30 = GameObject.Find("MCT - ATCMagazinePort30-1");
        safetycover = GameObject.Find("MCT - ATCSafetyCover-1");
        wheeler = GameObject.Find("MCT - ATCWheeler-1");
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
