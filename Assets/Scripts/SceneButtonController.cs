using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneButtonController : MonoBehaviour
{
    // Button to resume the game
    public GameObject resumeButton;

    // Button to restart the game.
    public GameObject restartButton;

    // Button to go to the next level.
    public GameObject nextLevelButton;

    // Button to go to the start menu.
    public GameObject startMenuButton;

    // Game pause status.
    private static bool isPaused = false;

    // Read-only public property to query pause status.
    public static bool IsPaused => isPaused;

    // Start is called before the first frame update.
    private void Start()
    {
        // Set button visibility.
        UpdateButtonVisibility();
    }

    /* // Update is called once per frame.
    void Update()
    {
        
    }*/

    // Checks if the pause button was pressed and toggles the pause status.
    public void OnPause(InputValue pauseValue)
    {
        if (pauseValue.isPressed)
        {
            TogglePause();
        }
    }

    // Toggles the paused status and updates the game's timescale.
    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        UpdateButtonVisibility();
    }

    // Updates the visibility of UI buttons based on the paused status.
    private void UpdateButtonVisibility()
    {
        resumeButton.SetActive(isPaused);
        restartButton.SetActive(isPaused);
        startMenuButton.SetActive(isPaused);

        if (SceneManager.GetActiveScene().name == "Level4_VR")
        {
            nextLevelButton.SetActive(false);
        }
        else
        {
            nextLevelButton.SetActive(isPaused);
        }
    }

    // Resumes the game when the resume button is clicked.
    public void OnResumeButtonClicked()
    {
        if (isPaused)
        {
            TogglePause();
        }
    }

    // Method for loading Level 1.
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    // Method for loading Level 2.
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    // Method for loading Level 3.
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    // Method for loading Level 4 (VR).
    public void LoadLevel4VR()
    {
        SceneManager.LoadScene("Level4_VR");
    }

    // Method to restart the current level.
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Method for loading the next level.
    public void LoadNextLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        switch (currentScene)
        {
            case "Level1":
                LoadLevel2();
                break;
            case "Level2":
                LoadLevel3();
                break;
            case "Level3":
                LoadLevel4VR();
                break;
        }
    }

    // Method for loading the start menu
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
