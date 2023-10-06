using UnityEngine.UI;
using UnityEngine;

public class Talk_Font : MonoBehaviour
{
    public GameObject talkpanel;
    public int RDN; //랜덤으로 출력할 대사가 있을 경우 사용
    public Text textwindow;
    public string[] DialogueBox;//랜덤 출력될 대사
    //NPC 대상 
    string RDNRandom(int dialognumber, string NPCTarget) // 처음부터 n까지의 랜덤 대사를 응용
    {
        RDN = Random.Range(0, dialognumber - 1);
        return DialogueBox[RDN];
    }
    
    ///NPC에게 접근해 클릭 혹은 터치했을 때,
    ///대화 창이 나오면서 해당 NPC의 이름과 대화 데이터를 수집하고,
    ///대화 창을 아래서부터 올리면서 천천히 텍스트 한 글자씩 출력한다.
    ///대화 창의 위치를 구하고, 맨 아래서부터 천천히 밀어올리게 한다.
    ///대화 창의 원래 위치에 다다르면, 0.2초 후 텍스트가 출력된다.
    ///텍스트는 코루틴을 통해 0.05초마다 한 글자씩 출력된다.
    ///= 텍스트는 초당 20글자를 출력한다.
}
