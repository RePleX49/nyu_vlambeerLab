using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCentering : MonoBehaviour
{
    GameObject[] TileObjects = new GameObject[7500];
    Vector3 PositionSum;

    int TilesInArray;
    int PreviousArrayCount;

    // Update is called once per frame
    void Update()
    {
        TileObjects = Object.FindObjectsOfType<GameObject>();

        if (PreviousArrayCount != TileObjects.Length && TileObjects.Length != 0)
        {
            foreach (GameObject thing in TileObjects)
            {
                if (thing.CompareTag("FloorTile"))
                {
                    TilesInArray++;
                    PositionSum += thing.transform.position;
                }
            }

            Vector3 NewCamPos = new Vector3(0, 800, 0);

            NewCamPos = (PositionSum / TilesInArray);

            NewCamPos.y = 800;

            if (TilesInArray != 0)
            {
                Camera.main.transform.position = NewCamPos;
            }

            Vector3 ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2, Camera.main.nearClipPlane);
            Vector3 CameraCenter = Camera.main.ScreenToWorldPoint(ScreenCenter);

            PreviousArrayCount = TileObjects.Length;

           // Debug.Log("Adjusting");
        }
    }
}
