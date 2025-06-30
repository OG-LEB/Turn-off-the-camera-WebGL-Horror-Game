using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneById(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }
}
