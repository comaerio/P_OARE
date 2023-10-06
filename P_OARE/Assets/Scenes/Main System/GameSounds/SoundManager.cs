using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip MainBGM;//태초마을
    public AudioClip ShopBGM;//상점 내부
    public AudioClip ButtonGS;//버튼 소리
    public AudioClip CancelGS;//취소버튼 소리
    public AudioClip ChatGS;//대화 출력소리
    public AudioSource BGM;//출력할 음악 위치

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        BGM.Play();
        BGM.loop = true;
    }
    void BGMUpdate(int BGMnumber, float Volume)
    {
        switch (BGMnumber)
        { //BGM의 상태를 업데이트함.
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
        BGM.volume = Volume;
    }
    void BGMStop()
    {
        BGM.Stop();
    }
    void BGMPlay() { BGM.Play(); }
    float BGMState()
    {
        return BGM.clip.length;
    }


    // Update is called once per frame
    void Update()
    {
        if (BGM.clip == MainBGM && BGM.time >= 68f)
        {
            BGM.time = 0.7f;
        }
        ///음악 자동 재생 버튼. 메인 BGM의 재생 시간은 1분 10초에 처음과 끝이 공백이 있기 때문.
    }
}
