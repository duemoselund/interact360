using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

    public Texture[] roomTextures;
    public GameObject sphere;
    int arryPos = 1;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            if (arryPos == roomTextures.Length) arryPos = 0;
            Renderer sphereRender = sphere.GetComponent<Renderer>();
            sphereRender.material.mainTexture = roomTextures[arryPos];

            MovieTexture movie = (MovieTexture)sphereRender.material.mainTexture;
            movie.Play();
            movie.loop = true;
            arryPos++;
        }
	}
}
