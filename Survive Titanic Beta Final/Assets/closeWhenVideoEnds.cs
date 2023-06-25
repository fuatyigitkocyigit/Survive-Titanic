using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class closeWhenVideoEnds : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Drag your VideoPlayer here in the inspector
    public GameObject canvasPanel; // Drag your CanvasPanel here in the Inspector

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    private void OnVideoEnded(VideoPlayer source)
    {
        canvasPanel.SetActive(false);
    }
}
