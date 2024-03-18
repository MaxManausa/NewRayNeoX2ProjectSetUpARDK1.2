using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingTargetHit : MonoBehaviour
{
    [SerializeField] public Material hitMaterial;
    [SerializeField] private TargetController targetController;
    [SerializeField] private Scoreboard scoreboard;

    [SerializeField] public Material originalMaterial;
    public new Renderer renderer;

    
    [SerializeField] private GameObject winScreen;
    
    [SerializeField] private AudioSource arrowAudioSource;
    [SerializeField] private AudioClip arrowHitSound;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = originalMaterial;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            renderer.material = hitMaterial;
            if (targetController.enabled == true)
            {
                scoreboard.score += 1;
                scoreboard.UpdateScore();
                PlaySound(arrowHitSound);
            }
            
            if (scoreboard.score > scoreboard.onelessthanwinningScore)
            
            {
                winScreen.SetActive(true);
                Debug.Log("It happened!");
            }
            targetController.enabled = false;
            //Debug.Log(_scoreboard.score);
            Invoke("TargetBackOn",6f);
        }
    }

    void TargetBackOn()
    {
        //turns the target back on
        renderer.material = originalMaterial;
        targetController.enabled = true;
    }

    
    public void PlaySound(AudioClip newSound)
    {
        newSound = arrowHitSound;
        arrowAudioSource.Play();
    }
    
}

