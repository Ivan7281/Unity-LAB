using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    private Animator animator;
    private bool isCollected = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            isCollected = true;
            animator.SetTrigger("Collect");
            StartCoroutine(DestroyCoinAfterAnimation());
        }
    }

    private IEnumerator DestroyCoinAfterAnimation()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
