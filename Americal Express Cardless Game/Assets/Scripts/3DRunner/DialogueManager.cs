using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    public GameObject canvas;
    public GameObject player;
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);

        //nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            StartCoroutine(EndDialogue());
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        //dialogueText.text = sentence;
    }

    IEnumerator TypeSentence (string sentece)
    {
        dialogueText.text = "";
        foreach (char letter in sentece.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    IEnumerator EndDialogue()
    {
        Debug.Log("Conversation ended");
        animator.SetBool("isOpen", false);
        yield return new WaitForSeconds(1f);
        canvas.SetActive(false);
        mainCamera.SetActive(false);
        player.SetActive(true);
    }
}
