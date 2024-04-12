using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Enemy_Target : MonoBehaviour
{
    public float health = 50f;

    

    

    public void TakeDamage(float amount){
        health -= amount;
        if(health <= 0f){
            
            Die();
        }
    }

    

    void Die(){
        Destroy(gameObject);
      
    }
    
     
}


