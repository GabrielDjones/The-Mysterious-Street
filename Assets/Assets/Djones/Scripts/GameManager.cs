using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mario;
    public GameObject marioMonstro;

    NpcInvoker npcInvoker;
    ChoiceCode choiceCode;
    int npc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       choiceCode = FindAnyObjectByType(typeof(ChoiceCode)) as ChoiceCode;
       npcInvoker = FindAnyObjectByType(typeof(NpcInvoker)) as NpcInvoker;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        npc = Random.Range(0, 4);
        npcInvoker.NpcChoicer(npc);

    }
    public void CloseTheDoor()
    {
        if (npc == 1 || npc == 2)
        {
          choiceCode.LoseSanity();
          mario.SetActive(false);
        }
        else if (npc == 3 || npc == 4)
        {
          choiceCode.SanityGain();
          marioMonstro.SetActive(false);
        }
    }

}
