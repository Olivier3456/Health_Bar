using UnityEngine;

public class DragObject : MonoBehaviour     // Permet de faire un drag and drop avec la souris sur l'objet.
{
    private Vector3 screenPoint;
   
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);    
    }

    void OnMouseDrag()
    {
        Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint);
        transform.position = cursorPosition;
    }
}