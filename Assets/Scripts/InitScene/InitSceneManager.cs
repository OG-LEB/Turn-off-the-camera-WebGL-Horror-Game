using UnityEngine;
using UnityEngine.SceneManagement;

public class InitSceneManager : MonoBehaviour
{
    [SerializeField] private GameObject VersionObj;
    [SerializeField] private int MainSceneId;
    void Start()
    {
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(VersionObj);
        SceneManager.LoadScene(MainSceneId);
    }

}
