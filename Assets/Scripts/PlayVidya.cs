using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVidya : MonoBehaviour
{
    [SerializeField] private GameObject videoPlayer;
    private float timer = 10f;

    public void PlaySpecialVideo()
    {
        videoPlayer.SetActive(true);
        StartCoroutine(DeactivateAfterDelay());
    }

    private IEnumerator DeactivateAfterDelay()
    {
        yield return new WaitForSeconds(timer);
        videoPlayer.SetActive(false);
    }
}
