using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;

    // Makes the private variable visible in the Inspector
    [SerializeField]
    private  GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        // Limit the frame rate to 60
        Application.targetFrameRate = 60;
        
        // Instantiate redObj at (2, 0, 0) with zero rotation
        Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);

        // Instantiate blueObj at (-2, 0, 0) with zero rotation
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
