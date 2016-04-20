using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour {

	public void LoadStage0()  {

		SceneManager.LoadScene ("jump");
		//CameraFade.StartAlphaFade( Color.black, false, 0.5f, 0f, () => { SceneManager.LoadScene ("Scene0"); } );
	}
	public void LoadStage1()  {
		//	CameraFade.StartAlphaFade( Color.black, false, 0.5f, 0f, () => { SceneManager.LoadScene ("LEGO_base"); } );
		SceneManager.LoadScene ("run");
	}

	public void LoadStage2()  {
		//	CameraFade.StartAlphaFade( Color.black, false, 0.5f, 0f, () => { SceneManager.LoadScene ("LEGO_base"); } );
		SceneManager.LoadScene ("wave");
	}

	public void LoadStage3()  {
		//	CameraFade.StartAlphaFade( Color.black, false, 0.5f, 0f, () => { SceneManager.LoadScene ("LEGO_base"); } );
		SceneManager.LoadScene ("Drink");
	}

	public void LoadStage4()  {
		//	CameraFade.StartAlphaFade( Color.black, false, 0.5f, 0f, () => { SceneManager.LoadScene ("LEGO_base"); } );
		SceneManager.LoadScene ("Menu");
	}

}