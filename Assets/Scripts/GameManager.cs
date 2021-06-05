using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.V))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        if (Input.GetKey(KeyCode.C))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }
}
