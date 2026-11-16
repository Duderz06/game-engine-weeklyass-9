using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{

    public void LoadSceneName(string Scene)
    {
        SceneManager.LoadScene(Scene);

    }

}
