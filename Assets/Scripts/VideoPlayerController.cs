using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Collections.Generic;

public class VideoPlayerController : MonoBehaviour
{
    public RawImage videoImage;
    public VideoPlayer videoPlayer;
    public List<Toggle> toggles;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.Prepare();
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        foreach (Toggle toggle in toggles)
        {
            if (toggle.isOn)
            {
                switch (toggle.gameObject.name)
                {
                    case "Toggle1":
                        Debug.Log("Toggle1 está activado");
                        break;
                    case "Toggle2":
                        Debug.Log("Toggle2 está activado");
                        break;
                }
            }
        }
    }
}
