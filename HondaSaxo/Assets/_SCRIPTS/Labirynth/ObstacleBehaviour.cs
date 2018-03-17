using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setSprite(Texture2D texture2D)
    {
        GetComponent<Sprite>().texture =  texture2D;
    }
}
