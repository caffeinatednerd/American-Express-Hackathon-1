using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Payment : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public GameObject viewCanvas;
    public GameObject selectionCanvas;
    public GameObject payWithCashButton;
    public GameObject payWithCardButton;
    public GameObject payWithSwiprOrDipButton;
    public GameObject payWithTaplessButton;
    public Text buyText;

    private void OnTriggerEnter(Collider other)
    {
        viewCanvas.SetActive(true);
        StartCoroutine(showPaymentCanvas());
    }

    IEnumerator showPaymentCanvas()
    {
        Debug.Log("Inside show payment canvas");
        yield return new WaitForSeconds(1f);
        viewCanvas.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        selectionCanvas.SetActive(true);
        mainCamera.SetActive(true);
        player.SetActive(false);
        string sentence = buyText.text;
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        buyText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            buyText.text += letter;
            yield return null;
        }
        payWithCashButton.SetActive(true);
        payWithCardButton.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void PayWithCash()
    {
        //change to hard mode
        SceneManager.LoadScene("SampleScene Hard");
    }

    public void PayWithCard()
    {
        //setting active to the dip/swipe and tapless
        payWithSwiprOrDipButton.SetActive(true);
        payWithTaplessButton.SetActive(true);

        //setting deactive to the cash and card button
        payWithCardButton.SetActive(false);
        payWithCashButton.SetActive(false);
    }

    public void PayWithSwipeAndDip()
    {
        //change to medium mode
        SceneManager.LoadScene("SampleScene Medium");
    }

    public void PayWithTapless()
    {
        //change to easy mode
        SceneManager.LoadScene("SampleScene Easy");
    }
}
