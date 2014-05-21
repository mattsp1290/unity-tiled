using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public Sprite[] tiles;
	private SpriteRenderer spriteRenderer;
	public int currentTile;

	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
		spriteRenderer.sprite = tiles[ currentTile ];
	}

	public void updateTile(int uTile){
		spriteRenderer.sprite = tiles[ uTile ];
	}
}
