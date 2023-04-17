using UnityEngine;

public class VisionFollower : MonoBehaviour
{
    [SerializeField] private Transform _contextualMenuHandler;
    [SerializeField] private Transform _target;
    [SerializeField] private float distance = 0.4f;

    private Vector3 initialPos;
    private void Start()
    {
        initialPos = _contextualMenuHandler.localPosition;
    }

    private void Update()
    {
        
     //  transform.position = _contextualMenuHandler.position;
    // transform.position = new Vector3(_contextualMenuHandler.position.x, lPos.y, _contextualMenuHandler.position.z);
     //  transform.LookAt(_target);
     //lPos = transform.TransformPoint(_contextualMenuHandler.position);
    // transform.position = lPos;
   // Debug.Log("Position: "+_contextualMenuHandler.position);
   transform.position = new Vector3(_contextualMenuHandler.position.x, initialPos.y+1.27f, _contextualMenuHandler.position.z);
//   Debug.Log(_contextualMenuHandler.position);
   transform.LookAt(_target);
    }
    
}