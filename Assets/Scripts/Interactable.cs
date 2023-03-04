using System.Runtime.Remoting.Messaging;
using UnityEngine;

[RequireComponent(typeof(Outline))]
public class Interactable : MonoBehaviour
{
    private Outline outline;

    [Header("UI")]

    [SerializeField] private GameObject Uipanel;
    [SerializeField] private Camera _camera;
    [SerializeField] private CameraFly _cameraFly;

    //private GameObject Uipanel;


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
        _cameraFly.GetComponent<CameraFly>().enabled = false;


    }
    public void OnHoverExit()
    {
        outline.OutlineWidth = 0;
        Uipanel.SetActive(false);
        _cameraFly.GetComponent<CameraFly>().enabled = true;

    }



}

