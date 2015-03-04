#pragma strict

function Start () {

}

function Update () {     
	gameObject.renderer.material.mainTextureOffset = 
	new Vector2(gameObject.renderer.material.mainTextureOffset.x + .05f * Time.deltaTime,
				gameObject.renderer.material.mainTextureOffset.y);
}