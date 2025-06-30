using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    float deltaTime = 0.0f;
    float fps = 0.0f;
    float updateInterval = 0.5f; // обновление каждые 0.5 секунды
    float timeSinceLastUpdate = 0.0f;

    GUIStyle style;
    Rect rect;

    void Start()
    {
        int fontSize = Mathf.Max(Screen.height / 25, 14);
        style = new GUIStyle();
        style.fontSize = fontSize;
        style.normal.textColor = Color.white;
        rect = new Rect(10, 10, 200, 40);
    }

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        timeSinceLastUpdate += Time.unscaledDeltaTime;

        if (timeSinceLastUpdate >= updateInterval)
        {
            fps = 1.0f / deltaTime;
            timeSinceLastUpdate = 0.0f;
        }
    }

    void OnGUI()
    {
        string text = string.Format("FPS: {0:0.}", fps);
        GUI.Label(rect, text, style);
    }
}
