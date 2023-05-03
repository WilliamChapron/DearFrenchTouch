using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    public float moveSpeed = 1f;

    private Camera cam;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        // Rotation de la caméra
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        cam.transform.Rotate(Vector3.up, mouseX * 0.7f, Space.World);
        cam.transform.Rotate(Vector3.left, mouseY * 0.7f, Space.Self);

        // Calcul de la direction de déplacement en fonction de l'orientation de la caméra
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        // Ajout de la prise en charge du déplacement avec les touches ZQSD
        Vector3 moveHorizontal = right * horizontal;
        Vector3 moveVertical = forward * vertical;
        moveDirection = moveHorizontal + moveVertical;
        moveDirection.Normalize();

        // Déplacement de la caméra dans la direction calculée
        cam.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}