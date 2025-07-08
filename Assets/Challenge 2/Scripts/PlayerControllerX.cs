using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 3f;
    public float timeSinceCooldown;

    private void Start()
    {
        timeSinceCooldown = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceCooldown += Time.deltaTime;
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceCooldown >= cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceCooldown = 0f;
            
        }
    }
}
