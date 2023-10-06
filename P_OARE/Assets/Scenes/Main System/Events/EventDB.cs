using UnityEngine;
using UnityEngine.UI;

public class EventDB : MonoBehaviour
{
    public GameObject Player;
    public GameObject EventTarget; // NPC 혹은 이벤트에 상호작용
    public GameObject TextBox; // 텍스트 출력을 위한 UI
    public GameObject ImageBox; // 이미지 출력을 위한 UI, 없을 시 이미지 비활성화
    public Image ImageHolder; // ImageBox에 들어갈 이미지, 없을시 ImageBox 비활성
    public string[] Dialogue;
    // Start is called before the first frame update
    void Start()
    {
        TextBox.SetActive(false);
        ImageBox.SetActive(false);

        Dialogue = new string[] { };
    }
    void DialogueGet(string[] Dialog)
    {
        Dialogue = new string[] { };
    }
    public bool isImageAvailable()
    {
        if (ImageHolder.GetComponent<Image>().sprite == null)
        {
            return false;
        } 
        else return true;

    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
