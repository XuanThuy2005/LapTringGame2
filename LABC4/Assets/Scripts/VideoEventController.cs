using UnityEngine;
using UnityEngine.Video;

public class VideoEventController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endPanel;

    void Start()
    {
        // Đăng ký event
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        // Chuẩn bị video
        videoPlayer.Prepare();
    }

    // Event: video chuẩn bị xong
    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video prepared");
        vp.Play();
    }

    // Event: video chạy hết
    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video finished");

        if (endPanel != null)
        {
            endPanel.SetActive(true);
        }
    }
}
