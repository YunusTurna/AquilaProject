using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPig : MonoBehaviour
{
    public GameObject pigs;

    
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.gameObject.CompareTag("Player")){
                Destroy(pigs);
            }
        }
        
    
}
