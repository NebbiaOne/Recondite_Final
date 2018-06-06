using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Transform playerCam, character, cameraBase;
    private float mouseX, mouseY;
    public float mouseSensitivity = 7f;
    public float mouseYPosition = 5f;
    private float moveFB, moveLR;
    private float moveFBRaw, moveLRRaw;
    public float moveSpeed = 1f;
    public float jumpheight = 10000;
    public float rotationSpeed = 5f;
    public Rigidbody rbody;
    public static GameObject _player;
    Animator animator;

    void Start () {
        _player = gameObject;
        rbody = GetComponent<Rigidbody> ();
        //thisVector3 = Vector3(98,-5,12);
        animator = GetComponent<Animator>();
    }

    void Update () {

       /* if (Input.GetButtonDown("Jump")) {

            GetComponent<Rigidbody>().AddForce (0, jumpheight * Time.deltaTime, 0);

        }*/

        cameraBase.transform.position = transform.position;

        mouseX += Input.GetAxis ("Mouse X") * mouseSensitivity;
        mouseY -= Input.GetAxis ("Mouse Y") * mouseSensitivity;

        mouseY = Mathf.Clamp (mouseY, -40f, 40f);
       
        cameraBase.localEulerAngles = new Vector3 (mouseY, mouseX, 0);

        moveFB = Input.GetAxis ("Vertical") ;//* moveSpeed * Time.deltaTime; 
        moveLR = Input.GetAxis ("Horizontal"); //* moveSpeed * Time.deltaTime;
        moveFBRaw = Input.GetAxisRaw ("Vertical");
        moveLRRaw = Input.GetAxisRaw ("Horizontal");
        animator.SetFloat("xMov", moveFB);
        animator.SetFloat("yMov", moveLR);

        if (moveFB != 0 || moveLR != 0) {

            if (moveFBRaw != 0 || moveLRRaw != 0) {
                //Match to camera base rotation
                transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, cameraBase.localEulerAngles.y, transform.localEulerAngles.z);
            }
    
            Vector3 movement = new Vector3 (moveLR, 0, moveFB);
            movement = transform.TransformDirection (movement * moveSpeed * Time.deltaTime);
            rbody.velocity = new Vector3 (movement.x, rbody.velocity.y, movement.z);

       

        }
             if (moveFB != 0 || moveLR != 0) {
                animator.SetBool("Moving", true);
            }else{
                  animator.SetBool("Moving", false);

            }
    }
}