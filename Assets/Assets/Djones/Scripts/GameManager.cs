using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mario;
    int npc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenDoor()
    {
        npc = Random.Range(0, 9);

    }
    private void MarioInvoke()
    {
        Instantiate(mario, transform.position, transform.rotation);
    }
}
