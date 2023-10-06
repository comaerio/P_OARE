using UnityEngine;
using UnityEngine.UI;

public class EventDB : MonoBehaviour
{
    public GameObject Player;
    public GameObject EventTarget; // NPC Ȥ�� �̺�Ʈ�� ��ȣ�ۿ�
    public GameObject TextBox; // �ؽ�Ʈ ����� ���� UI
    public GameObject ImageBox; // �̹��� ����� ���� UI, ���� �� �̹��� ��Ȱ��ȭ
    public Image ImageHolder; // ImageBox�� �� �̹���, ������ ImageBox ��Ȱ��
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
