using UnityEngine;
using System.Collections;

public class MyImageEffect : MonoBehaviour {
	[SerializeField]Shader shader;
	[SerializeField]
	[Range(0,1)]
	float param = 0f;
	[SerializeField]
	[Range(500,5000)]
	float param2 = 0f;

	Material material;

	void Awake(){
		material = new Material(shader);
	}
	public void OnRenderImage(RenderTexture source, RenderTexture destination){
		UpdateMaterial();
		Graphics.Blit(source,destination,material);
	}

	void UpdateMaterial(){
		material.SetFloat("_Param",param);
		material.SetFloat("_Param2",param2);
	}
}
