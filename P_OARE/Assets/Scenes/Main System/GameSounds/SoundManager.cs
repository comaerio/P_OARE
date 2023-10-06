using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip MainBGM;//���ʸ���
    public AudioClip ShopBGM;//���� ����
    public AudioClip ButtonGS;//��ư �Ҹ�
    public AudioClip CancelGS;//��ҹ�ư �Ҹ�
    public AudioClip ChatGS;//��ȭ ��¼Ҹ�
    public AudioSource BGM;//����� ���� ��ġ

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
        { //BGM�� ���¸� ������Ʈ��.
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
        ///���� �ڵ� ��� ��ư. ���� BGM�� ��� �ð��� 1�� 10�ʿ� ó���� ���� ������ �ֱ� ����.
    }
}
