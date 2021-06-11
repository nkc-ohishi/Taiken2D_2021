using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneDirectorComplete : MonoBehaviour
{
    public GameObject TitleObject;
    public Text timeText;
    public Text countText;
    public Text winText;

    const float MAX_TIME = 15f;
    const int MAX_ITEM = 12;

    public static bool gameFlg;
    public static float lastTime;
    public static int itemCount;

    void Start()
    {
        gameFlg = false;
        lastTime = MAX_TIME;
        itemCount = 0;
    }

    void Update()
    {
        if(gameFlg == false)
        {
            // Enterキーが押されたら
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (itemCount == 0 && lastTime == MAX_TIME)
                {
                    TitleObject.SetActive(false);
                    gameFlg = true;
                }
                else
                {
                    // 終了後エンターキーでリロード
                    SceneManager.LoadScene(0);
                }
            }
        }
        else
        {
            // 残り時間
            lastTime -= Time.deltaTime;
            lastTime = Mathf.Max(lastTime, 0f);
            timeText.text = "残り時間\n" + lastTime.ToString("F2") + "秒";

            // アイテムカウント表示
            countText.text = "Count: " + itemCount.ToString();

            // 終了判定
            if (itemCount >= 12 || lastTime <= 0f)
            {
                winText.text = (itemCount >= 12) ? "CLEAR !!" : "TIME UP!!";
                gameFlg = false;
            }

        }




    }
}
