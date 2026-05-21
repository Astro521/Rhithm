using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button pauseButton;
    public GameObject pauseMenu;
    public SongObjectScript song;
    public GameObject pauseMenu;
    public Button pauseButton;

    void Start()
    {
        song = findSong();
    }

    private SongObjectScript findSong()
    {
        return (SongObjectScript)FindObjectOfType(typeof(SongObjectScript));
    }

    public void Resume()
    {
        pauseButton.interactable = true;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseButton.interactable = false;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}