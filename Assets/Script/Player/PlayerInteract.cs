using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float distance = 3f;//Ray mesafesi
    [SerializeField] private LayerMask mask;

    private PlayerUI playerUI;
    private InputManager inputManager;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        //kamera merkezinden bir ray att�k
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction*distance, Color.yellow);
        RaycastHit hitInfo;//Ray �arp��ma bilgilerimizi saklamak i�in de�i�ken


        //raycast �arpt���nda al�nan bilgileri hitInfo ya atad�k
        if (Physics.Raycast(ray, out hitInfo, distance, mask))//raycast bir�eye �arp�p geri d�n�� al�rsa
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
               playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }

        }
    }
}
