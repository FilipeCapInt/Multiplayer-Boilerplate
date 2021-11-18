using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeMat : MonoBehaviour
{
    public Material materialf35;
    public Material materialholof35;
    public GameObject f35;
    public int score = 0;
    public InputActionReference togglereference = null;
    private void Awake()
    {
        togglereference.action.started += Toggle;
    }

    private void OnDestroy()
    {
        togglereference.action.started -= Toggle;
    }

    void Start()
    {
        f35 = GameObject.Find("F_35Hull");
        if (f35 == null)
        {
            Debug.Log("re");
        }
    }

    // Update is called once per frame
    private void Toggle(InputAction.CallbackContext context)
    {
        if (score == 0)
        {
            f35.GetComponent<MeshRenderer>().material = materialf35;
            score += 1;
        }
        else
        {
            f35.GetComponent<MeshRenderer>().material = materialholof35;
            score -= 1;
        }
    }
}
