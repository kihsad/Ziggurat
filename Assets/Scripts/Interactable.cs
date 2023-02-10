using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ziggurat;

[RequireComponent(typeof(Outline))]
public class Interactable : UnitCreator
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
        
        InstantiateKnightUnit();      
    }
    public void OnHoverExit()
    {
        outline.OutlineWidth = 0;
    }
}
