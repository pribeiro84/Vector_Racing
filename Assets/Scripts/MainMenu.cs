using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public AudioClip buttonPress;

    public void Start()
    {
        audioSource.clip = buttonPress;
    }

    public void StartGame()
    {
        audioSource.Play();
        animator.SetTrigger("FadeOut");
        Invoke("LoadNextScene", 1);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Selector");
    }
}
