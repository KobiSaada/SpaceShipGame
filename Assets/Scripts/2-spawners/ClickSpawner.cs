using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class ClickSpawner: MonoBehaviour {
    [SerializeField] protected InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    // public ParticleSystem particleSystem;

    bool canShot= true;
    float coolDown= 0.5f;
    float timeStamp;

    void OnEnable()  {
        spawnAction.Enable();
    }

    void OnDisable()  {
        spawnAction.Disable();
    }

    protected virtual GameObject spawnObject() {
        Debug.Log("Spawning a new object");

        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
      //  Destroy1();
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover) {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }
    // public void Destroy1()
    // {
    //     Instantiate(particleSystem, transform.position, Quaternion.identity);

        
    // }
    private void Update() {
        if (canShot && spawnAction.WasPressedThisFrame()) {
            spawnObject();
      timeStamp= Time.time + coolDown;
            canShot =false;
        }
        else if(Time.time >= timeStamp){
            canShot = true;
        }
    }
}
