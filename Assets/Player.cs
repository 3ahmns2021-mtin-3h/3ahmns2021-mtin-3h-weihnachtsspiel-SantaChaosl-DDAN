using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    int countCollisions = 0;
    public bool carryingCookie = false;
    public int points = 0;
    public GameObject feedbackSantaCookie;
    public TextMeshProUGUI scoreDisplay;


    // Start is called before the first frame update
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Milk")
        {
            points--;
        }
        
        else if (collision.name.Contains("Cookie") && !carryingCookie)
        {
            Destroy(collision.gameObject);
            carryingCookie = false;
            points++;
            feedbackSantaCookie.SetActive(true);
            scoreDisplay.text = points.ToString();
        }


        Debug.Log("count Collisions " + countCollisions);
        Debug.Log("In Player, collide with " + collision);

    }
    
}
