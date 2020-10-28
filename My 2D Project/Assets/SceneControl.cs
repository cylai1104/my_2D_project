using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void ChangeScene()
    {
        // 切換場景
        // 場景管理.載入場景("場景名稱")
        SceneManager.LoadScene("遊戲畫面");
    }

    public void DelayChangeScene()
    {
        Invoke("ChangeScene", 0.3f);
    }

    public void Quit()
    {
        // 關閉遊戲並離開
        // 應用程式.離開
        Application.Quit();
    }
}
