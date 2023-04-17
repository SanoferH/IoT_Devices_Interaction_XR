using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGaze : MonoBehaviour
{

    [SerializeField] private GameObject _lampUI;
    [SerializeField] private GameObject _DysonUI;
    // Start is called before the first frame update
    void Start()
    {
        _lampUI.SetActive(false);
        _DysonUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,
                Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit: "+ hit.collider.gameObject.name);

            if (hit.collider.GetComponent<LampIdentifier>())
            {
                _lampUI.SetActive(true);
                _DysonUI.SetActive(false);
            }

            if (hit.collider.GetComponent<DysonIdentifier>())
            {
                _DysonUI.SetActive(true);
                _lampUI.SetActive(false);
            }
        }
       
    }
}
