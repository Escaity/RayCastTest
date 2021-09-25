using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    public Texture2D handCursor;

    // Update is called once per frame
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        int layerMask = 1 << 6;
        float maxDistance = 10;

        if (Physics.Raycast(ray, out hit, maxDistance, layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject.tag == "Items")
                    Destroy(hit.collider.gameObject);
                //Debug.Log(hit.collider.gameObject.tag);
                //Debug.Log(hit.collider.gameObject.name);
                //Debug.Log(hit.collider.transform.position);
            }
            Cursor.SetCursor(handCursor, Vector2.zero, CursorMode.Auto);
        }
    }
}