using UnityEngine;

public class NpcInvoker : MonoBehaviour
{
    public GameObject mario;
    public GameObject marioMonstro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NpcChoicer(int x)
    {
        if (x == 1 || x == 2)
        {
            MarioInvoke();
        }
        if(x == 3 || x == 4)
        {
            MarioMonstroInvoke();
        }
    }
    private void MarioInvoke()
    {
        mario.SetActive(true);
      
    }
    private void MarioMonstroInvoke()
    {
        marioMonstro.SetActive(true);
  
    }
}
