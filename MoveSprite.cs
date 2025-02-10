using UnityEngine;

public class MoveSprite : MonoBehaviour
{
    public KeyCode keyPress;
    public KeyCode quitKey;
    
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPress))
        {
            Vector3 position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
            transform.SetPositionAndRotation(position, Quaternion.identity);
        }
        
        if (Input.GetKeyDown(quitKey))
         {
            Application.Quit();
         }
    }
}
