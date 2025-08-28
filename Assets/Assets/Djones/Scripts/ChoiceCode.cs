using UnityEngine;
using UnityEngine.UI;

public class ChoiceCode : MonoBehaviour
{
    int npcNumber;
    public Slider slider;
    public float life = 100f;// float pois o jogador não se movimenta no eixo x 0.1 unidades no trecho de um frame
    public float lifeMax = 100f;
    public float danoPorSegundo = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life = Mathf.Clamp(life, 0, lifeMax);// limita a vida para menos q 0 
        slider.value = life;
        slider.maxValue = lifeMax;
        life -= danoPorSegundo * Time.deltaTime;
        if (life <= 0)
        {
            Debug.Log("perdeu");
        }
    }
    

    public void LoseSanity()
    {
        life += 10;
    }

    public void SanityGain() 
    {
       life -= 30;
    }

}
