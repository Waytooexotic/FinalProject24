using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pickup : MonoBehaviour
{
    public int pointValue = 1; //Value to increase points by
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //If pickup hit an object with a “Player” tag...
        {
            GameManager.Instance.UpdateScore(pointValue);
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); //Value that makes Time ruin at a computers unique FPS (So “Update” is accurate)
    }
}