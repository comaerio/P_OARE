using UnityEngine.UI;
using UnityEngine;

public class Talk_Font : MonoBehaviour
{
    public GameObject talkpanel;
    public int RDN; //�������� ����� ��簡 ���� ��� ���
    public Text textwindow;
    public string[] DialogueBox;//���� ��µ� ���
    //NPC ��� 
    string RDNRandom(int dialognumber, string NPCTarget) // ó������ n������ ���� ��縦 ����
    {
        RDN = Random.Range(0, dialognumber - 1);
        return DialogueBox[RDN];
    }
    
    ///NPC���� ������ Ŭ�� Ȥ�� ��ġ���� ��,
    ///��ȭ â�� �����鼭 �ش� NPC�� �̸��� ��ȭ �����͸� �����ϰ�,
    ///��ȭ â�� �Ʒ������� �ø��鼭 õõ�� �ؽ�Ʈ �� ���ھ� ����Ѵ�.
    ///��ȭ â�� ��ġ�� ���ϰ�, �� �Ʒ������� õõ�� �о�ø��� �Ѵ�.
    ///��ȭ â�� ���� ��ġ�� �ٴٸ���, 0.2�� �� �ؽ�Ʈ�� ��µȴ�.
    ///�ؽ�Ʈ�� �ڷ�ƾ�� ���� 0.05�ʸ��� �� ���ھ� ��µȴ�.
    ///= �ؽ�Ʈ�� �ʴ� 20���ڸ� ����Ѵ�.
}
