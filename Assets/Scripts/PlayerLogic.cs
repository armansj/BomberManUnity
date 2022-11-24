using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    AudioClip audioClip;
   AudioSource audioSource;

   

    float speed=5f;
    float maxX = 2.55f;
    float minX = -2.55f;
    // Start is called before the first frame update
    void Start()
    {
        audioClip = GetComponent<AudioClip>();
        audioSource.PlayOneShot(audioClip);

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;
        if (h > 0)
        {

            currentPosition.x += Time.deltaTime * speed;
        }
        else if (h < 0)
        {
            currentPosition.x -= Time.deltaTime * speed;
        }

        if (currentPosition.x > maxX)
        {
            currentPosition.x = maxX;
        }else if (currentPosition.x < minX)
        {
            currentPosition.x = minX;
        }



        transform.position = currentPosition;

        

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb" )
        {
            Time.timeScale = 0;
            
        }
           

            
        
    }

   
   
}
