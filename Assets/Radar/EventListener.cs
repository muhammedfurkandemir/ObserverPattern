using UnityEngine;
using UnityEngine.Events; //https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html

public class EventListener : MonoBehaviour
{
    public Event gEvent;
    public UnityEvent response; 
    private void OnEnable()
    {
        gEvent.Register(this);
    }
    private void OnDisable()
    {
        gEvent.Unregister(this);
    }
    public void OnEventOccurs()
    {
        response.Invoke(); 
    }
}
