using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Rigidbody of the player.
    private Rigidbody rb;

    // Variable to keep track of collected "PickUp" objects.
    private int count;

    // Movement along X and Y axes.
    private float movementX;
    private float movementY;

    // Speed at which the player moves.
    public float speed = 0f;

    // Base jump force for a short press.
    public float baseJumpForce = 0f;

    // Variable to verify if the player is in contact with the ground.
    private bool isGrounded;

    // Variable to check if the player has been defeated.
    private bool isDefeated = false;

    // UI text component to display count of "PickUp" objects collected.
    public TextMeshProUGUI countText;

    // UI object to display winning text.
    public GameObject winTextObject;

    // Button to restart the game.
    public GameObject restartButton;

    // Button to go to the next level.
    public GameObject nextLevelButton;

    // Button to go to the start menu.
    public GameObject startMenuButton;

    // Pickup audio.
    private AudioSource pickupAudioSource;

    // Victory audio.
    private AudioSource victoryAudioSource;

    // Defeat audio.
    private AudioSource defeatAudioSource;

    // Start is called before the first frame update.
    void Start()
    {
        // Get and store the Rigidbody component attached to the player.
        rb = GetComponent<Rigidbody>();

        // Initialize count to zero.
        count = 0;

        // Update the count display.
        SetCountText();

        // Initially set the win text to be inactive.
        winTextObject.SetActive(false);

        // Disable the buttons at the start.
        restartButton.SetActive(false);
        nextLevelButton.SetActive(false);
        startMenuButton.SetActive(false);

        // Get the AudioSource components.
        AudioSource[] audioSources = GetComponents<AudioSource>();
        pickupAudioSource = audioSources[0];
        victoryAudioSource = audioSources[1];
        defeatAudioSource = audioSources[2];
    }

    // This function is called when a move input is detected.
    void OnMove(InputValue movementValue)
    {
        // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Store the X and Y components of the movement.
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // This function is called when a jump input is detected.
    void OnJump(InputValue jumpValue)
    {
        // Only allow jumping if the player is in contact with the ground.
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * baseJumpForce, ForceMode.Impulse);
            isGrounded = false; // After jumping, the player is no longer in contact with the ground.
        }
    }

    // FixedUpdate is called once per fixed frame-rate frame.
    private void FixedUpdate()
    {
        // Do not execute movement logic if the game is paused.
        if (SceneButtonController.IsPaused)
        {
            return;
        }

        // Create a 3D movement vector using the X and Y inputs.
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        // Apply force to the Rigidbody to move the player.
        rb.AddForce(movement * speed);
    }

    // Method called when this collider enters another trigger collider.
    void OnTriggerEnter(Collider other)
    {
        // Check if the object the player collided with has the "PickUp" tag.
        if (other.gameObject.CompareTag("PickUp") && !isDefeated)
        {
            // Deactivate the collided object (making it disappear).
            other.gameObject.SetActive(false);

            // Increment the count of "PickUp" objects collected.
            count = count + 1;

            // Update the count display.
            SetCountText();

            // Play the audio of the collectible.
            pickupAudioSource.Play();
        }
    }

    // Function to update the displayed count of "PickUp" objects collected.
    void SetCountText()
    {
        // Update the count text with the current count.
        countText.text = "Count: " + count.ToString();

        // Check if the count has reached or exceeded the win condition.
        if (count >= 10)
        {
            // Display the win text.
            // winTextObject.SetActive(true);
            ShowWinUI();

            // Destroy the enemy GameObject.
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    // Method called when this collider collides with another collider.
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player is in contact with the ground to enable the jump.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Enemy") && !isDefeated)
        {
            // Destroy the current object
            // Destroy(gameObject);

            // Update the winText to display "You Lose!"
            // winTextObject.gameObject.SetActive(true);
            // winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
            // ShowLoseUI();

            // Avoid multiple collisions that reset the status.
            isDefeated = true;

            // Call the corrutine to display the defeat UI and destroy the player.
            StartCoroutine(HandlePlayerDefeat());
        }
    }

    // Coroutine to handle player defeat sequence.
    private IEnumerator HandlePlayerDefeat()
    {
    // Show the defeat UI and play the audio.
    ShowLoseUI();

    // Disable the player.
    GetComponent<MeshRenderer>().enabled = false;

    // Disable the collider and the movement.
    GetComponent<Collider>().enabled = false;
    GetComponent<Rigidbody>().isKinematic = true;

    // Wait for the duration of the audio before destroying the player.
    yield return new WaitForSeconds(defeatAudioSource.clip.length);

    // Finally, destroy the player.
    Destroy(gameObject);
    }

    // Method called when this collider stops colliding with another collider.
    private void OnCollisionExit(Collision collision)
    {
        // When the player is no longer in contact with the ground.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    // Display the win UI and end game buttons.
    private void ShowWinUI()
    {
        winTextObject.SetActive(true);
        // winTextObject.GetComponent<TextMeshProUGUI>().text = "You Win!";

        // Play the player's victory audio.
        victoryAudioSource.Play();

        ShowEndGameButtons();
    }

    // Display the lose UI and end game buttons.
    private void ShowLoseUI()
    {
        winTextObject.SetActive(true);
        // winTextObject.gameObject.SetActive(true);
        winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";

       // Play the player's defeat audio.
       defeatAudioSource.Play();

       ShowEndGameButtons();
    }

    // Display the end game buttons based on the current level.
    private void ShowEndGameButtons()
    {
        restartButton.SetActive(true);
        startMenuButton.SetActive(true);

        // Show the button to go to the next level only if the current level is not the last one.
        if (SceneManager.GetActiveScene().name != "Level3")
        {
            nextLevelButton.SetActive(true);
        }
    }
}
