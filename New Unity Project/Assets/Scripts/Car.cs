using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //單行註解 SOSO 2021.04.28

    /*
     * 多行註解
     * 多行註解
     * /

     /*欄位
      * 整數:int
      * 浮點數:float
      * 字串:string
      * 布林值:bool
      * ex: int test；(一個整數叫test)
      */

    //私人:不顯示 private (預設)
    //公開:顯示 public

    //屬性欄位:放在欄位前面或上面
    //語法:
    //[屬性名稱(值)]
    //標題 Header (字串)
    //提示 Toolip (字串)
    //範圍 Range (最小值，最大值)，僅限於數值類型int，float
    [Header("這是汽車CC數")]
    [Tooltip("可以調整汽車CC數的多寡")]
    [Range(1000,5000)]
    public int cc = 2000;
    [Header("汽車重量"),Range(1f,5f)]
    public float weight = 3.5f;
    public string brand = "賓士";
    public bool openCold = false;

    //其他類型
    //顏色 Color
    public Color color;
    public Color red = Color.red;
    public Color yellow = Color.yellow;
    //Color(紅，綠，藍) - 值介於0 - 1
    public Color color1 = new Color(0.5f, 0.6f, 0);
    //Color(紅，綠，藍，透明度) - 值介於0 - 1
    public Color color2 = new Color(0, 0.5f, 0.9f, 0.5f);

    //座標 Vector2 - 4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2myl = new Vector2(3.5f, 9);

    public Vector3 v3;
    public Vector4 v4;

    //輸入按鍵 KayCode
    public KeyCode key;
    public KeyCode a = KeyCode.A;
    public KeyCode mouse = KeyCode.Mouse0;
    public KeyCode joy = KeyCode.Joystick1Button15;

    //遊戲物件與元件
    public GameObject obj;


    public Transform tra;
    public Camera cam;
    public AudioListener aud;

}
