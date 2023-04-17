using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
     public ParticleSystem particleSystem;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
          
          
          

          Destroy(this.gameObject);
          Destroy1();
        //  particleSystem.Play();
          Destroy(other.gameObject);
          
         
        }
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(triggeringTag))
        {
            Destroy1();
        }
    }

    public void Destroy1()
    {
        Instantiate(particleSystem, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }


    private void Update() {
        /* Just to show the enabled checkbox in Editor */
        
    }
}