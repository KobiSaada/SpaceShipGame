 using UnityEngine;
 using System.Collections;
 
 public class destroyEnemyOut : MonoBehaviour
 {
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Use this for initialization
    void Awake () {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
       // objectWidth = transform.GetComponent<Transform>().position.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<Transform>().position.y; //extents = size of height / 2
    }
      void Update ()
      {
          // Vector2 screenPosition = MainCamera.WorldToScreenPoint(transform.position);
           if ( objectHeight < -4f )
           Destroy (gameObject);
      }
 }