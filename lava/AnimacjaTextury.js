
var offset : float;

function Update () 
{
  offset += 0.001;
  renderer.material.SetTextureOffset("_MainTex", Vector2(-offset,0));
}
//_MainTex