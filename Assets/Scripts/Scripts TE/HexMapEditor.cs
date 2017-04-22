using UnityEngine;
using UnityEngine.EventSystems;

public class HexMapEditor : MonoBehaviour {

	public Color[] colors;

	public Hexgrid hexGrid;

	private Color activeColor;

	void Awake () {
		SelectColor(0);
	}

	void Update () {//getting input if mouse button is pressed
		if (Input.GetMouseButton(0) &&
            !EventSystem.current.IsPointerOverGameObject()) {
			HandleInput();
		}
	}

	void HandleInput () {//works out where user is pointing
		Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(inputRay, out hit)) {
			hexGrid.ColorCell(hit.point, activeColor);
		}
	}

	public void SelectColor (int index) {
		activeColor = colors[index];
	}
}