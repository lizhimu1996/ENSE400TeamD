using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
  public string sceneToLoad;
  public int health = 100 ;

  public GameObject deathEffect;

  public bool isInvulnerable = false;

  public void TakeDamage(int damage)
  {
    if (isInvulnerable)
      return;

    health -= damage;

    if (health <= 0)
    {
      Die();
    }
  }

  void Die()
  {
    Instantiate(deathEffect, transform.position, Quaternion.identity);
    Destroy(gameObject);
    PlayerController2.Gold += 5;

    	SceneManager.LoadSceneAsync(sceneToLoad);



  }

}
