using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_parametric_design : MonoBehaviour
{
    //============================================================
    // scale 조정
    //============================================================

    public Vector3 shell;
    public GameObject shellObjCopy;

    public void ParamChange()
    {
        shell = shellObjCopy.transform.localScale;
        shell.x = 1.5f; // x축 scale 조정
        shellObjCopy.transform.localScale = shell;
    }

    //============================================================
    // 투명화
    //============================================================
    // 상위 컴포넌트의 색상을 투명, 유색 상태로 전환하기 위해서는 하위 컴포넌트들을 받아야 한다.
    
    // 상위 부품 각각을 불러올 gameobject 선언
    public GameObject cnc_0, cnc_1, cnc_2, cnc_3, cnc_4,
    cnc_5, cnc_6, cnc_7,cnc_8; // 상위 부품 총 9개

    // 상위 부품 각각에 대해 하위 부품을 받아올 list 선언
    public Transform[] List_0, List_1, List_2, List_3, List_4,
    List_5, List_6, List_7, List_8;

    // float a, int mode
    // a가 1이면, 유색, a=0이면 투명
    // mode가 3이면 투명화 모드, mode가 0이면 유색 모드
    // ex) a=0, mode=3 → object 투명화 / a=1, mode=0 → object 유색화
    public void ChangeColor(GameObject Object1, Transform[] List, Render mesh_child, Material mat, float a, int mode)
    {
        List = Object1.transform.GetComponentsInChildren<Transform>();
        if (mode == 3)
        {
            foreach (Transform child in List)
            {
                mesh_child = child.GetComponent<Render>();
                mat = mesh_child.material;
                mat.SetFloat("_Mode", 3);
                mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
                mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                mat.SetInt("_ZWrite", 0);
                mat.DisableKeyword("_ALPHATEST_ON");
                mat.DisableKeyword("_ALPHABLEND_ON");
                mat.EnableKeyword("_ALPHAREMULTIPLY_ON");
                mat.renderQueue = 3000;
                Color oldColor = mat.color;

                // a가 투명도 parameter
                mesh_child.material.color = new Color(oldColor.r, oldColor.g, oldColor.b, a);
            }
        }

        if (mode == 0)
        {
            foreach (Transform child in List)
            {
                mesh_child = child.GetComponent<Renderer>();
                mat = mesh_child.material;
                mat.SetFloat("_Mode", 0);
                mat.SetInt("_SrcBlend", 1);
                mat.SetInt("_DstBlend", 0);
                mat.SetInt("_ZWrite", 1);
                mat.EnableKeyword("_ALPHATEST_ON");
                mat.DisableKeyword("_ALPHABLEND_ON");
                mat.EnableKeyword("_ALPHAPREMULTIPLY_ON");
                mat.renderQueue = 2000;
                Color oldColor = mat.color;

                mesh_child.material.color = new Color(oldColor.r, oldColor.g, oldColor.b, a);
            }
        }
    }

    // transparenting trigger, 7개 상위 부품 transparenting trigger
    bool isTransparent;
    bool is1stButtonClicked;
    bool is2ndButtonClicked;
    bool is3rdButtonClicked;
    bool is4thButtonClicked;
    bool is5thButtonClicked;
    bool is6thButtonClicked;
    bool is7thButtonClicked;

    // 투명화 trigger 함수
    public void StartTransparentTrigger() {
        isTransparent = true;
    }

    public void StopTransparentTrigger() {
        isTransparent = false;
    }

    void Transparenting() {
        // 투명화 진행 시 아예 빼버릴 컴포넌트
        cnc_3.SetActive(false);
        cnc_4.SetActive(false);

        // 처음에는 모두 투명
        ChangeColor(cnc_0, List_0, Rend_0, Mat_0, 0, 3);
        ChangeColor(cnc_1, List_1, Rend_1, Mat_1, 0, 3);
        ChangeColor(cnc_2, List_2, Rend_2, Mat_2, 0, 3);
        ChangeColor(cnc_5, List_5, Rend_5, Mat_5, 0, 3);
        ChangeColor(cnc_6, List_6, Rend_6, Mat_6, 0, 3);
        ChangeColor(cnc_7, List_7, Rend_7, Mat_7, 0, 3);
        ChangeColor(cnc_8, List_8, Rend_8, Mat_8, 0, 3);

        // 버튼 클릭에 따라 각 상위 부품만 유색화
        if (is1stButtonClicked == true) {
            ChangeColor(cnc_0, List_0, Rend_0, Mat_0, 1, 0);
        }
        if (is2ndButtonClicked == true) {
            ChangeColor(cnc_1, List_1, Rend_1, Mat_1, 1, 0);
        }
        if (is3rdButtonClicked == true) {
            ChangeColor(cnc_2, List_2, Rend_2, Mat_2, 1, 0);
        }
        if (is4thButtonClicked == true) {
            ChangeColor(cnc_5, List_5, Rend_5, Mat_5, 1, 0);
        }
        if (is5thButtonClicked == true) {
            ChangeColor(cnc_6, List_6, Rend_6, Mat_6, 1, 0);
        }
        if (is6thButtonClicked == true) {
            ChangeColor(cnc_7, List_7, Rend_7, Mat_7, 1, 0);
        }
        if (is7thButtonClicked == true) {
            ChangeColor(cnc_8, List_8, Rend_8, Mat_8, 1, 0);
        }
    }

    void StopTransparenting() {
        cnc_3.SetActive(true);
        cnc_4.SetActive(true);

        ChangeColor(cnc_0, List_0, Rend_0, Mat_0, 1, 0);
        ChangeColor(cnc_1, List_1, Rend_1, Mat_1, 1, 0);
        ChangeColor(cnc_2, List_2, Rend_2, Mat_2, 1, 0);
        ChangeColor(cnc_3, List_3, Rend_3, Mat_3, 1, 0);
        ChangeColor(cnc_4, List_4, Rend_4, Mat_4, 1, 0);
        ChangeColor(cnc_5, List_5, Rend_5, Mat_5, 1, 0);
        ChangeColor(cnc_6, List_6, Rend_6, Mat_6, 1, 0);
        ChangeColor(cnc_7, List_7, Rend_7, Mat_7, 1, 0);
        ChangeColor(cnc_8, List_8, Rend_8, Mat_8, 1, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        cnc_0 = GameObject.Find("MCT ControlPanelARM");
        cnc_1 = GameObject.Find("MCT ATC");
        cnc_2 = GameObject.Find("MCT ControlPanel");
        cnc_3 = GameObject.Find("MCT MainBody");
        cnc_4 = GameObject.Find("MCT Useless");
        cnc_5 = GameObject.Find("MCT AxisLocation");
        cnc_6 = GameObject.Find("MCT ChuckColumn");
        cnc_7 = GameObject.Find("MCT Saddle");
        cnc_8 = GameObject.Find("MCT Table");
    }

    // Update is called once per frame
    void Update()
    {
        if (isTranscript) {
            Transparenting();
        }
        else {
            StopTransparenting();
        }
    }
}
