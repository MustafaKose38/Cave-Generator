using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //etkileþimi olan bir nesneye baktýðýmýzda mýkacak olan text/mesaj
    public string promptMessage;


    // Player tarafýn çaðýrýlacak fonksiyon
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // bu fonksiyonda herhangi bir kod olmayacak, þablon olarak kullanýlacak
    }

}
