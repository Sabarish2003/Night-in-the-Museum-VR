using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject altspacevr;
    public GameObject mergevr;
    public GameObject quantumCapture;
    public GameObject neurable;
    public GameObject decentraland;

    public GameObject canvas;

    public void Click()
    {
        altspacevr.GetComponent<AudioSource>().Play();
        mergevr.GetComponent<AudioSource>().Play();
        quantumCapture.GetComponent<AudioSource>().Play();
        neurable.GetComponent<AudioSource>().Play();
        decentraland.GetComponent<AudioSource>().Play();
        canvas.SetActive(false);
    }
}
