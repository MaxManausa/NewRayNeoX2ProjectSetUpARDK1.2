using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingMonsterHit : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    [SerializeField] private ParticleSystem particleSystem;

    [SerializeField] private Scoreboard scoreboard;
    [SerializeField] private GameObject winScreen;

    [SerializeField] private AudioSource explosionAudioSource;
    [SerializeField] private AudioClip explosionSound;
    
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            if (skinnedMeshRenderer.enabled == true)
            {
                scoreboard.score += 1;
                scoreboard.UpdateScore();
                PlayExplosionSound(explosionSound);
            }
            skinnedMeshRenderer.enabled = false;
            particleSystem.Play();
            
            if (scoreboard.score > scoreboard.onelessthanwinningScore)
            {
                winScreen.SetActive(true);
                Debug.Log("It happened!");
            }
            //Debug.Log(_scoreboard.score);
            Invoke("TargetBackOn",6f);
        }
    }

    public void MonsterHit()
    {
        PlayExplosionSound(explosionSound);
        skinnedMeshRenderer.enabled = false;
        particleSystem.Play();
        
        Invoke("TargetBackOn",6f);
    }

    void TargetBackOn()
    {
        //turns the target back on
        skinnedMeshRenderer.enabled = true;
    }


    public void PlayExplosionSound(AudioClip newSound)
    {
        newSound = explosionSound;
        explosionAudioSource.Play();
    }

}
