using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class DoorOpenScript : MonoBehaviour
{
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPress()
    {
        animator.SetBool("open", true);
        StartCoroutine(waitThreeSeconds());
    }

    IEnumerator waitThreeSeconds()
    {
        yield return new WaitForSeconds(3);
        animator.SetBool("open", false);
    }
}
