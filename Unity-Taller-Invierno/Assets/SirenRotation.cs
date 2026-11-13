using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    public float rotationSpeed = 200f; 

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0); 
    }
}