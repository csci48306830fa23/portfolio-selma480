using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{

    // marker properties 
    public Transform writingPoint;
    public Material drawMat;
    public Material wpMat;
    public float markerWidth = 0.01f;

    // hands and marker 
    public OVRGrabber right; 
    public OVRGrabber left;
    public OVRGrabbable marker;

    // actual drawing 
    private LineRenderer drawing;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        wpMat.color = Color.magenta;
    }

    // Update is called once per frame
    void Update()
    {
        bool grabbed = marker.isGrabbed;
        bool rightH = grabbed && marker.grabbedBy == right && OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger);
        bool leftH = grabbed && marker.grabbedBy == left && OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger);

        if (rightH || leftH) {
            draw();
            Debug.Log("in if");
        } else if (drawing != null) {
            drawing = null;
        }
    }

    private void draw() {

        if (drawing == null) {
            index = 0;
            drawing = new GameObject().AddComponent<LineRenderer>();
            drawing.material = drawMat;
            drawing.startColor = Color.magenta;
            drawing.startWidth = markerWidth;
            drawing.positionCount = 1;
            drawing.SetPosition(0, writingPoint.transform.position);
        } else {
            var currentPos = drawing.GetPosition(index);
            if (Vector3.Distance(currentPos, writingPoint.transform.position) > 0.01f) {
                index++;
                drawing.positionCount = index + 1;
                drawing.SetPosition(index, writingPoint.transform.position);
            }
        }

    }
}
