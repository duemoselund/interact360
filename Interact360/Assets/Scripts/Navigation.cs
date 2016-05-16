using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

    public Texture[] roomTextures;
    public GameObject[] cameraPositions;
    public GameObject sphere360;
    public GameObject parentCamera;
    int arryPos = 1;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            if (arryPos == roomTextures.Length) arryPos = 0;
            Renderer sphereRender = sphere360.GetComponent<Renderer>();
            sphereRender.material.mainTexture = roomTextures[arryPos];
            sphere360.transform.parent.transform.position = cameraPositions[arryPos].transform.position;
            parentCamera.transform.position = cameraPositions[arryPos].transform.position;

            MovieTexture movie = (MovieTexture)sphereRender.material.mainTexture;

            movie.Play();
            movie.loop = true;
            arryPos++;
        }
	}
}
