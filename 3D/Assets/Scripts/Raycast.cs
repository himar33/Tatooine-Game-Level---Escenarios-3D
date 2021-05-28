using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{

    private GameObject raycastedObj;

    [SerializeField] private int rayLength = 10;
    [SerializeField] private LayerMask layerMaskInteract;

    [SerializeField] private Image uiCrossHair;

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("Object"))
            {
                raycastedObj = hit.collider.gameObject;
                CrossHairActive();
                if (Input.GetKeyDown("e"))
                {
                    Debug.Log("I have interacted with an object");
                    raycastedObj.SetActive(false);
                }
            }
        }
        else
        {
            CrossHairNormal();
        }
    }

    void CrossHairActive()
    {
        uiCrossHair.color = Color.red;
    }

    void CrossHairNormal()
    {
        uiCrossHair.color = Color.white;
    }
}
