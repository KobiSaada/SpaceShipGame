using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
/**
 * This component moves its object in a fixed velocity.
 * NOTE: velocity is defined as speed+direction.
 *       speed is a number; velocity is a vector.
 */
public class Mover: MonoBehaviour {
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;
     [SerializeField] ParticleSystem particleSystem;

    void Update() {
        if( transform.position.y<=-4.9){
           // particleSystem.Play();
            Destroy1();
            Destroy(this.gameObject);
        }
        transform.position += velocity * Time.deltaTime;
    }
 

    public void Destroy1()
    {
        Instantiate(particleSystem, transform.position, Quaternion.identity);

       // Destroy(gameObject);
    }

    public void SetVelocity(Vector3 newVelocity) {
        this.velocity = newVelocity;
    }
}
