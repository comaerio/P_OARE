using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Character_Skills : MonoBehaviour
{
    public GameObject SkillDB;
    public string[] skillnames;
    public int[] skills;
    public float[] skillcooldowns; //50 Frame = 1 Second
    public int[] SkillSlots;
    public string[] SkillInforms;
    public Button[] SkillButtons = new Button[4];
    public int[] skillPower; //Damage Input/Output
    // Start is called before the first frame update
    void Start()
    {
        skillnames = new string[] {"미사용","일반 공격", "강공격","방어","경호원",""};//이곳에 스킬 DB 네임 입력
        skills = new int[] { 0, 1,2,3,4,5,6 };//이곳에 스킬 번호 입력
        SkillSlots = new int[4] { 0, 0, 0, 0 }; // 0 = 미사용, 1~ = 스킬들 장착
        SkillInforms = new string[] {"전혀 사용되지도 않고, 기능조차 존재하지 않는 스킬.\n과연 이것을 사용할 일이 있을까?",
        "용사라면 기본적으로 가지고 있을 검을 휘두른다.\n"+skillPower+"","","","",""};
        skillPower = new int[] { 0, 10, 0, 0, 0, 0};
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
