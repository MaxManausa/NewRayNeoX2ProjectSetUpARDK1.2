using UnityEngine;

public class PausePlayAudio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    private bool isPaused;

    public void TogglePlayback()
    {
        if (audioSource.isPlaying)
        {
            // Audio is currently playing, so pause it
            audioSource.Pause();
            isPaused = true;
        }
        else if (isPaused)
        {
            // Audio is paused, so resume playing
            audioSource.UnPause();
            isPaused = false;
        }
        else
        {
            // Audio is stopped, so play it
            audioSource.Play();
        }
    }
}
