using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{ 
#region 欄位

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
    #endregion

    #region 方法
    //欄位語法
    //修飾詞 類型 名稱 指定 值 ;

    //方法 Method - 儲存城市區塊或演算法
    //語法;
    //修飾詞 傳回類型 名稱( ) {城市區塊或演算法}
    //void 無傳回 - 沒有傳回資料
    /// <summary>
    /// YZC 2021.05.05
    /// 這是一個會輸出訊息的測試方法
    /// </summary>
    private void Test()
    {
        //輸出(任何資料類型)
        print("我是測試方法");

    }
    private void Drivre50()
    {}
    //參數語法:類型 名稱
    //呼叫的時候可以決定參數的值
    //類型 名稱，類型 名稱... ...
    /// <summary>
    /// <param name="speed">速度</param>>
    /// <param name="sound">音效</param>
    /// <param name="effect">特效</param>
    private void Drive(int speed, string sound = "ㄏㄏㄏ", string effect = "光芒")
    {
        print("開車速度" + speed);
        print("音效" + sound );
        print("特效" + effect);
    }
 
    #endregion
    #region 事件
    //事件 Event - 在特定時間點會已指定次數執行(程式的入口)
    //開始事件:播放遊戲後會執行一次
    //應用:初始值，初始金錢，初始HP等等... ...

    private void Start()
    {
        //呼叫方法
        //方法名稱();
        Test();
        Drivre50();
        //有幾個參數就要輸入幾個
        Drive(99, "咻咻咻", "灰塵");
        Drive(444, "轟轟轟", "爆炸");

        Drive(50);

    }
    #endregion
}