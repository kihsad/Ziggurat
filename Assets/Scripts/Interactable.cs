using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Outline))]
public class Interactable : MonoBehaviour
{
    private Outline outline;

    private void OnEnable()
    {
        outline = GetComponent<Outline>();
        outline.OutlineWidth = 0;
    }
    public void OnHoverEnter()
    {
        outline.OutlineWidth = 10;
    }
    public void OnHoverExit()
    {
        outline.OutlineWidth = 0;
    }
}
