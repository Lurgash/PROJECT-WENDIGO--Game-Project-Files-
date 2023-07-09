using UnityEngine;
using UnityEngine.Video;
using System.Collections.Generic;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public List<GameObject> targets;

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
        foreach (GameObject target in targets)
        {
            if (target.activeSelf)
            {
                target.SetActive(false);
            }
            else
            {
                target.SetActive(true);
            }
        }
    }
}
