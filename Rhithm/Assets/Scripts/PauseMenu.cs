using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public Button pauseButton;
    public GameObject pauseMenu;
<<<<<<< HEAD
>>>>>>> Stashed changes
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
=======
>>>>>>> 51e964b19cd873c1dd66947dd861373cf0e8b383

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