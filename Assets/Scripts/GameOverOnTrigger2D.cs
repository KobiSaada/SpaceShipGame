using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;

    public int HitPoints;
    public int MaxHitPoints = 3;
    public GameObject gameOver;
    [SerializeField] ParticleSystem particleSystem;

   

    public HealthBar healthBar;


    [SerializeField] string sceneName;
    
    void Start()
    {
        HitPoints = MaxHitPoints;
        healthBar.SetMaxHealth(MaxHitPoints);
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            //  explo.Play();
            
            Destroy(other.gameObject);
            
            
          
           
            TakeHit(1); 
            Destroy1();
        }
    }
      public void Destroy1()
    {
        Instantiate(particleSystem, transform.position, Quaternion.identity);

       // Destroy(gameObject);
    }

    public void TakeHit(int damage)
    {
        HitPoints -= damage;
        healthBar.SetHealth(HitPoints);
        if (HitPoints <= 0)
        {
            Destroy(this.gameObject);
            gameover();
            
            //SceneManager.LoadScene(sceneName);
            // SceneManager.LoadScene("GameOver");
           
        
        }
    }
  
   public void gameover()
    {
        gameOver.SetActive(true);

    }
        private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}