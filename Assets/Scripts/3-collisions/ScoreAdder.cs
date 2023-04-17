using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField scoreField;
    [SerializeField] int pointsToAdd;
   // [SerializeField] ParticleSystem particleSystem;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && scoreField!=null) {
           // particleSystem.Play();
            scoreField.AddNumber(pointsToAdd);
           
            
         
        }
   
    }
    //  private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.collider.CompareTag(triggeringTag))
    //     {
    //         Destroy1();
    //     }
    // }

    // public void Destroy1()
    // {
    //     Instantiate(particleSystem, transform.position, Quaternion.identity);

    //    // Destroy(gameObject);
    // }


    public void SetScoreField(NumberField newTextField) {
        this.scoreField = newTextField;
    }
}
