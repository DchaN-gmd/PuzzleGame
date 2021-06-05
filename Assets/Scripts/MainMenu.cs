using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animation _panelAnimation;

    public GameObject mainInterface;
    public GameObject mainMenu;

    private void Awake()
    {
        _panelAnimation.Stop();
    }
    public void ClickPlayButton()
    {
        _panelAnimation.Play();
        Invoke("OnMainInterface", 1f);
        Invoke("LoadfirstLevel", 1.5f);
    }

    private void OnMainInterface()
    {
        mainInterface.SetActive(true);
        mainMenu.SetActive(false);
    }

    private void LoadfirstLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
