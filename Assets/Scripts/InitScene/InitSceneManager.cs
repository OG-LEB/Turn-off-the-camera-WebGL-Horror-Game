using UnityEngine;
using UnityEngine.SceneManagement;

public class InitSceneManager : MonoBehaviour
{
    [SerializeField] private GameObject VersionObj;
    [SerializeField] private int MainSceneId;
    void Start()
    {
        DontDestroyOnLoad(VersionObj);
        SceneManager.LoadScene(MainSceneId);
    }

}
