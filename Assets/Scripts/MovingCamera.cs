using UnityEngine;

public class MovingCamera : MonoBehaviour {
      
   //I got this code from a youtube tutorial.

    public float panSpeed = 50f; 
    public float panBoarder = 25f;
   // public Vector2 panLimit;

    public float scrollSpeed = 50f;
    public float minY = 20f;
    public float maxY = 500f;

	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position; // x, y & z coordinate stored in pos variable

        if (Input.GetKey("w")|| Input.mousePosition.y >= Screen.height - panBoarder)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBoarder)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBoarder)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBoarder)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        //pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        //pos.z = Mathf.Clamp(pos.y, -panLimit.y, panLimit.y);

        transform.position = pos;    
	}
}
