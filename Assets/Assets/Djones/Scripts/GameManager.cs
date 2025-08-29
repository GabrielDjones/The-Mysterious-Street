
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mario;
    public GameObject marioMonstro;
    public GameObject richard;
    public GameObject richardMonstro;

    public string sceneName;
    
    NpcInvoker npcInvoker;
    
    ChoiceCode choiceCode;
    
    int npc;
    int quantidadeNpc;
    
    List<int> npcVerify = new List<int> {};

    void Start()
    {
       choiceCode = FindAnyObjectByType(typeof(ChoiceCode)) as ChoiceCode;
       npcInvoker = FindAnyObjectByType(typeof(NpcInvoker)) as NpcInvoker;     
    }


    void Update()
    {
        if (quantidadeNpc == 4) 
        {
            sceneManager();
            npcVerify.Clear();
        }
    }
    private void randomNumber()
    {
        npc = Random.Range(1, 5);
        Debug.Log($" range {npc}");
    }
    public void OpenDoor()
    {
       randomNumber();
        if (npcVerify.Contains(npc))
        {
            OpenDoor();    
        }
        npcVerify.Add(npc);
        npcInvoker.NpcChoicer(npc);
        Debug.Log($"numero final {npc}");
    }


    public void CloseTheDoor()
    {
        if (npc == 1)
        {
            choiceCode.LoseSanity();
            mario.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
        else if (npc == 2)
        {
            choiceCode.SanityGain();
            marioMonstro.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
        else if(npc == 3)
        {
            choiceCode.LoseSanity();
            richard.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
        else if (npc == 4) 
        {
            choiceCode.SanityGain();
            richardMonstro.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
    }

    public void Candy()
    {
        if (npc == 1)
        {
            choiceCode.SanityGain();
            mario.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
        else if (npc == 2)
        {
            choiceCode.LoseSanity();
            marioMonstro.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
        else if (npc == 3)
        {
            choiceCode.SanityGain();
            richard.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
        else if (npc == 4) 
        {
            choiceCode.LoseSanity();
            richardMonstro.SetActive(false);
            quantidadeNpc++;
            TextManager.Instance.CloseText();
        }
    }


    private void sceneManager()
    {
        SceneManager.LoadScene(sceneName);
    }
}
