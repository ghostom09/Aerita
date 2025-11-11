using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManagement.instance.LoadScene(SceneName.Ingame);
    }
    public void QuitGame()
    {
        GameManager.instance.QuitGame();
    }
    public void Setting()
    {
        
    }
}
