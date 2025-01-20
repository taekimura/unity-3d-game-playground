using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{


    [SerializeField]
    private Animator animator;

    [SerializeField]
    private CanvasGroup canvasGroup;

    [SerializeField]
    private TMP_Text bubbleText;

    [SerializeField]
    private float speechSpeed;

    [SerializeField]
    private string conversation;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Speak()
    {
        StartCoroutine(FadeIn());
        StartCoroutine(WriteText(conversation));
    }

    private IEnumerator WriteText(string data)
    {
        bubbleText.text = string.Empty;

        for (int i = 0; i < data.Length; i++)
        {
            bubbleText.text += data[i];
            yield return new WaitForSeconds(speechSpeed);
        }
    }

    private IEnumerator FadeIn()
    {
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha = Mathf.MoveTowards(canvasGroup.alpha, 1, Time.deltaTime * 5);
            yield return null;
        }
    }

    private IEnumerator FadeOut(float delay)
    {
        yield return new WaitForSeconds(delay);

        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha = Mathf.MoveTowards(canvasGroup.alpha, 0, Time.deltaTime * 5);
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            animator.Play("Wave_NPC");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.Play("Wave_Bye_NPC");
            StartCoroutine(WriteText("Bye!"));
            StartCoroutine(FadeOut(2));
        }
    }
}
