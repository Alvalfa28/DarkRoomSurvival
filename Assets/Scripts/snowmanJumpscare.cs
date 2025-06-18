using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snowmanJumpscare : MonoBehaviour
{
    public Animator creepsAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;
    public enemyMonsterAI monsterscript;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            monsterscript.enabled = false;
            creepsAnim.ResetTrigger("idle");
            creepsAnim.ResetTrigger("walk");
            creepsAnim.ResetTrigger("run");
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
