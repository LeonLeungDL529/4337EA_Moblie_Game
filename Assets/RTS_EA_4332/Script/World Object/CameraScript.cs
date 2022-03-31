using UnityEngine;

public class CameraScript : MonoBehaviour {

    private Vector3 screenRight = new Vector3(Screen.width - 30, 0, 0);
    private Vector3 screenLeft = new Vector3(30, 0, 0);
    private Vector3 screenTop = new Vector3(0, Screen.height - 30, 0);
    private Vector3 screenBottom = new Vector3(0, 30, 0);
    public GameObject TheCam;

    public float cameraSpeed = 0.35f;
    public float mouseApproachSpeed;
    //float maxHeight =40;
    //float minHight = 4;
    public bool DoMouseMovement = true;
    public float scrollSpeed = 5;
    public Vector3 minpos;
    public Vector3 maxpos;


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            DoMouseMovement = !DoMouseMovement;
        }
        if (DoMouseMovement) 
        {
            MouseMovement();


           /* 
            float scroll = Input.GetAxis("Mouse ScrollWheel") * 10;
             pos.y -= scroll * scrollSpeed * Time.deltaTime;
           Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, minpos.x, maxpos.x);
           
            pos.y = Mathf.Clamp(pos.z, minpos.z, maxpos.z);
           
            pos.z = Mathf.Clamp(pos.z, minpos.z, maxpos.z);
            transform.position = pos;*/


           


        }


        if (Input.GetKey(KeyCode.Space))
        {
            transform.position= new Vector3(0,10,0);

        }

        if ( Input.GetKey(KeyCode.LeftShift))
        {
            cameraSpeed = 10;

        }
        else
        {
            cameraSpeed = 3;
        }
        if (Input.GetKey("left ctrl"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        if (Input.GetKey(KeyCode.F))
        {
           // GameObject.Instantiate(TheCam, new Vector3(0,0,0));
            transform.position = transform.position + new Vector3(0,0,0);

        }


    }

    void MouseMovement()
    {
        //Vertical Mouse and keyboard movement
        if ( Input.GetKey(KeyCode.A))
        {
            mouseApproachSpeed = -(Screen.width - 30) / 30;
            transform.Translate(mouseApproachSpeed * (Time.deltaTime * cameraSpeed), 0, 0);
        }
        else if ( Input.GetKey(KeyCode.D))
        {
            mouseApproachSpeed = (Screen.width - 30) / 30;
            transform.Translate(mouseApproachSpeed * (Time.deltaTime * cameraSpeed), 0, 0);
        }

        //Move Y position
        if ( Input.GetKey(KeyCode.S))
        {
            //mouseApproachSpeed = ((Screen.height - 30) - Input.mousePosition.y) / 30;
            mouseApproachSpeed = (30 - Input.mousePosition.y) / 30;
            transform.Translate(0, 0, mouseApproachSpeed * (Time.deltaTime * cameraSpeed));
        }
         if ( Input.GetKey(KeyCode.W))
        {
            mouseApproachSpeed = (30 + Input.mousePosition.y) / 30;
            transform.Translate(0, 0, mouseApproachSpeed * (Time.deltaTime * cameraSpeed));
        }
         //else


            //Horizontal Mouse movement
        if (Input.GetKey("left alt") && Input.mousePosition.x >= screenTop.x)
        {
            mouseApproachSpeed = -((Screen.width - 30) - Input.mousePosition.x) / 30;
            //mouseApproachSpeed = ((Screen.width - 30) + Input.mousePosition.x) / 30;
            transform.Rotate(0, mouseApproachSpeed * (Time.deltaTime * cameraSpeed),0 );
        }
        if (Input.GetKey("left alt") && Input.mousePosition.x <= screenBottom.x)
        {
            mouseApproachSpeed = -((Screen.width - 30) - Input.mousePosition.x) / 30;
            //mouseApproachSpeed = ((Screen.width - 30) + Input.mousePosition.x) / 30;
            transform.Rotate(0, -mouseApproachSpeed * (Time.deltaTime * cameraSpeed), 0);
        }
        

        float scroll = Input.GetAxis("Mouse ScrollWheel") * 10;
            transform.Translate(0, -scroll * scrollSpeed * Time.deltaTime, 0);
       //This script is to make map size of the sam.
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minpos.x, maxpos.x), Mathf.Clamp(transform.position.y, minpos.y, maxpos.y), Mathf.Clamp(transform.position.z, minpos.z, maxpos.z));







    }
}
