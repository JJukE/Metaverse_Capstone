using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    //============================================================
    // scaling parameter
    //============================================================
    static Vector3 vec_MB, vec_ATC, vec_T, vec_A, vec_CP, vec_OT,
                    vec_COL, vec_S, vec_CH, vec_SPR, vec_AB, ovec_MB,
                    ovec_ATC, ovec_T, ovec_A, ovec_CP, ovec_OT, ovec_COL,
                    ovec_S, ovec_CH, ovec_SPR, ovec_AB;
    
    static GameObject MainBody, ATC, Table, Axis, ControlPanel, OilTank,
                        Column, Saddle, Chuck, Spring, AlarmBeam;
    public Vector3[] Vecs = new Vector3[11]{vec_MB, vec_ATC, vec_T, vec_A, vec_CP, vec_OT,
                        vec_COL, vec_S, vec_CH, vec_SPR, vec_AB};
    
    public Vector3[] OriginVecs = new Vector3[11]{ovec_MB, ovec_ATC, ovec_T, ovec_A, ovec_CP, ovec_OT,
                        ovec_COL, ovec_S, ovec_CH, ovec_SPR, ovec_AB};
    
    public GameObject[] Objs = new GameObject[11]{MainBody, ATC, Table, Axis, ControlPanel, OilTank,
                        Column, Saddle, Chuck, Spring, AlarmBeam};

    //============================================================
    // 2 times scaling for x axis function
    //============================================================ 
    public void Scale()
    {
        for (int i = 0; i < Vecs.Length; i++) {
            Vecs[i] = Objs[i].transform.localScale;
        }

        for (int i = 0; i < Vecs.Length; i++) {
            Vecs[i].x = 2.0f; // x축 scale 2배로
            Objs[i].transform.localScale = Vecs[i];
        }
    }

    //============================================================
    // Scaling Canceling function
    //============================================================
    public void Cancel()
    {
        for (int i = 0; i < Vecs.Length; i++) {
            Vecs[i] = OriginVecs[i];
            Objs[i].transform.localScale = Vecs[i];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Objs[0] = GameObject.Find("MainBody");
        Objs[1] = GameObject.Find("ATC");
        Objs[2] = GameObject.Find("Table");
        Objs[3] = GameObject.Find("Axis");
        Objs[4] = GameObject.Find("Control");
        Objs[5] = GameObject.Find("OilTank");
        Objs[6] = GameObject.Find("Column");
        Objs[7] = GameObject.Find("Saddle");
        Objs[8] = GameObject.Find("Chuck");
        Objs[9] = GameObject.Find("Spring");
        Objs[10] = GameObject.Find("AlarmBeam");

        // store the origin local scale
        for (int i = 0; i < Vecs.Length; i++) {
            OriginVecs[i] = Objs[i].transform.localScale;
        }
    }

    //============================================================
    // Button Click Triggers
    //============================================================
    
    bool isScalingButtonClicked;
    bool isCancelButtonClicked;

    // Update is called once per frame
    void Update()
    {
        if(isScalingButtonClicked) {
            Scale();
        }
        if(isCancelButtonClicked) {
            Cancel();
        }
    }
}
