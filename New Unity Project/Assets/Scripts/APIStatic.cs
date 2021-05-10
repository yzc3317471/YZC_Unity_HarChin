using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
partial class APIStatic:MonoBehaviour
    {
        private void Start()
        {
            //使用靜態API
            //屬性
            //可以取得Get、可以設定Set
            //如果看到Read Only 只能取得

            //1.取得靜態的屬性
            //語法:類別,靜態屬性
            print("隨機" + Random.value);

            //2.設定靜態的屬性
            //語法:類別.靜態屬性 指定 值;
            Cursor.visible = false;

            int r = Random.Range(50, 150);
            print ("隨機攻擊力:"+r)
        }


    }
 





}
