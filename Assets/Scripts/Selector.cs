using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;
    private Interactable previousInteractable;

    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.TryGetComponent(out Interactable interactable))
                {
                    interactable.OnHoverEnter();
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.TryGetComponent(out Interactable interactable))
                {
                    interactable.OnHoverEnter();
                }
            }
        }


    }
}
