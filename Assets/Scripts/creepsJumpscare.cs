using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creepsJumpscare : MonoBehaviour
{
    public Animator creepsAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            creepsAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}
