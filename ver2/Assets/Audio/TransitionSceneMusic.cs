using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionSceneMusic : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        // Check if the AudioSource component is available.
        audioSource = GetComponent<AudioSource>();


        if ((SceneManager.GetActiveScene().buildIndex == 5) || (SceneManager.GetActiveScene().buildIndex == 6))
        {
            // Play the sound.
            audioSource.Play();
        }
    }
}