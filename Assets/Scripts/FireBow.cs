using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBow : MonoBehaviour
{
    [SerializeField] private GameObject arrowSpawnPoint;
    [SerializeField] public Animator bowAnimation;
    [SerializeField] public GameObject fakeArrow;
    [SerializeField] public Text numberOfArrowsFired;
    [SerializeField] private Text winArrowCount;

    public float fireRate = 0.5f;
    public GameObject arrowPrefab;
    public float arrowForce = .1f;

    
    [SerializeField] private AudioSource arrowAudioSource;
    [SerializeField] private AudioClip arrowWhooshSound;
    

    public float arrowsFired;
    public float targetsToHit = 3;

    
    public void OnButtonSmash()
    {
        //Invoke("DrawBack",.1f);
        Invoke("ShootArrow",.4f);
        Invoke("ReenableArrow",.8f);
    }

    public void FiveShots()
    {
        int i = 0;
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
    }

    public void DrawBack()
    {
        bowAnimation = GetComponent<Animator>();
        bowAnimation.enabled = true;
        bowAnimation.Play("GetShotBoi");
    }

    public void ShootArrow()
    {
        fakeArrow.SetActive(false);
        Transform arrowSpawnPos = arrowSpawnPoint.transform;
        DrawBack();
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPos.position, arrowSpawnPos.rotation);
        Rigidbody arrowRb = arrow.GetComponent<Rigidbody>();
        arrowRb.AddForce(arrowSpawnPos.forward * arrowForce, ForceMode.Impulse);
        PlaySound(arrowWhooshSound);
        arrowsFired = arrowsFired + 1;
        numberOfArrowsFired.text = ("Arrows Fired: " + arrowsFired);
        float result = (targetsToHit / arrowsFired ) * 100f;
        float roundedResult = Mathf.Round(result * 100f) / 100f;
        string formattedResult = string.Format("{0:0.00}%", roundedResult);
        winArrowCount.text = ("It only took you " + arrowsFired + " arrows to hit " + targetsToHit + 
                              " targets! You were " + formattedResult + " accurate!");
        Destroy(arrow, 5f);
        //Debug.Log("hi!!!!!!!");
    }

    public void ReenableArrow()
    {
        fakeArrow.SetActive(true);
    }
    
    
    private void PlaySound(AudioClip newSound) 
    {
        arrowAudioSource.Play();
    }

    public void ResetArrowsFired()
    {
        arrowsFired = 0;
    }
}