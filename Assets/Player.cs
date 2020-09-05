using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    [Tooltip("In ms/s")][SerializeField] float xSpeed = 12f;
    [Tooltip("In ms/s")][SerializeField] float ySpeed = 6f;

    int xBounds = 8;
    int yBounds = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float rawNewXPos = transform.localPosition.x + xOffset;
        float actualXPos = Mathf.Clamp(rawNewXPos, -xBounds, xBounds);

        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * ySpeed * Time.deltaTime;
        float rawNewYPos = transform.localPosition.y + yOffset;
        float actualYPos = Mathf.Clamp(rawNewYPos, -yBounds, yBounds);

        transform.localPosition = new Vector3(actualXPos, actualYPos, transform.localPosition.z);
    }
}
