using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object on X, Y, and Z axes by specified amounts, adjusted for frame rate.
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime); //15, 30, 45
    }

}