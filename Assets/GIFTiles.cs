using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GIFTiles : MonoBehaviour {

	public List<Texture> m_Textures;
	public float m_SleepTime = 0.03f;

	private MeshRenderer m_MR;
	private int m_Frame = 0;
	private int m_MaxFrames = 0;
	private int m_TileTexID = 0;

	// Use this for initialization
	void Start () {
		m_MR = GetComponent<MeshRenderer>();
		m_MaxFrames = m_Textures.Count;
		m_TileTexID = Shader.PropertyToID("_TileOverlay");

	}
	
	void FixedUpdate() {
		m_MR.material.SetTexture(m_TileTexID, m_Textures[m_Frame]);
		m_Frame = (m_Frame + 1) % m_MaxFrames;
	}
}
