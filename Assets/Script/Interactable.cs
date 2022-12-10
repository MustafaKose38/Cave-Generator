using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //etkile�imi olan bir nesneye bakt���m�zda m�kacak olan text/mesaj
    public string promptMessage;


    // Player taraf�n �a��r�lacak fonksiyon
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // bu fonksiyonda herhangi bir kod olmayacak, �ablon olarak kullan�lacak
    }

}
