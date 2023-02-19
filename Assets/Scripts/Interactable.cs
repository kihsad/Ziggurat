using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using Ziggurat;

[RequireComponent(typeof(Outline))]
public class Interactable : UnitCreator
{
    private Outline outline;

    [Header("UI")]    
    
    [SerializeField] private GameObject Uipanel;
    [SerializeField] private Camera _camera;

       
    private void OnEnable()
    {
        outline = GetComponent<Outline>();
        outline.OutlineWidth = 0;
        Uipanel.SetActive(false);
        
        
    }
    public void OnHoverEnter()
    {
        outline.OutlineWidth = 10;
        Uipanel.SetActive(true);
                       
    }
    public void OnHoverExit()
    {
        outline.OutlineWidth = 0;
        Uipanel.SetActive(false);
        
    }
}
