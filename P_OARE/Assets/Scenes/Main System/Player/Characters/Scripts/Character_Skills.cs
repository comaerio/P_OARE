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
        skillnames = new string[] {"�̻��","�Ϲ� ����", "������","���","��ȣ��",""};//�̰��� ��ų DB ���� �Է�
        skills = new int[] { 0, 1,2,3,4,5,6 };//�̰��� ��ų ��ȣ �Է�
        SkillSlots = new int[4] { 0, 0, 0, 0 }; // 0 = �̻��, 1~ = ��ų�� ����
        SkillInforms = new string[] {"���� �������� �ʰ�, ������� �������� �ʴ� ��ų.\n���� �̰��� ����� ���� ������?",
        "����� �⺻������ ������ ���� ���� �ֵθ���.\n"+skillPower+"","","","",""};
        skillPower = new int[] { 0, 10, 0, 0, 0, 0};
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
