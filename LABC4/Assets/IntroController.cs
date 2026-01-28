using UnityEngine;
using UnityEngine.Video;

public class IntroController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject introCanvas; // Canvas chứa RawImage + nút Skip

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        EndIntro();
    }

    public void SkipIntro()
    {
        EndIntro();
    }

    void EndIntro()
    {
        videoPlayer.Stop();
        introCanvas.SetActive(false);
    }
}
