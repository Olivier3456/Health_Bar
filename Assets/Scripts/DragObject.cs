using UnityEngine;

public class DragObject : MonoBehaviour     // Permet de faire un drag and drop avec la souris pour déplacer l'objet cliqué.
{
    private Vector3 screenPoint;
    private Vector3 offset;
   
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);


        // L'offset correspondra à la distance entre le curseur de la souris et le centre de l'objet cliqué.
        // Il sera utilisé dans OnMouseDrag.
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    void OnMouseDrag()
    {
        Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint) + offset;
        transform.position = cursorPosition;
    }
}