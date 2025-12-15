using UnityEngine;
using UnityEngine.Video;

public class UI_VideoPlayer : MonoBehaviour // 영상에 대한 전반적인 출력를 관리하기 위한 스크립트
{
    [SerializeField] string VideoFileName;

    private VideoPlayer videoPlayer;
    

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        PlayVideo();
    }
    
    public void PlayVideo()
    {
        if (videoPlayer)
        {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, VideoFileName);
            videoPlayer.url = videoPath;
            videoPlayer.Play();
            Debug.Log(VideoFileName + " 실행");
        }
    }
}
