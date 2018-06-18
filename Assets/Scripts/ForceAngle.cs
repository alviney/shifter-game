using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lean.Touch
{
	public class ForceAngle : MonoBehaviour {

		public GameObject indicator;
		[Tooltip("The current angle")]
		public float Angle;

		public void RotateToDelta(Vector2 delta)
		{
			indicator.SetActive(true);
			Angle = Mathf.Atan2(delta.x, delta.y) * Mathf.Rad2Deg;
			if (Angle < 0)
			{
				Angle = Mathf.Abs(Angle) + 180;
			} else {
				Angle = (180 - Angle);
			}
			// indicator.transform.RotateAround(this.transform.position, Vector3.right, -Angle);
			indicator.transform.localRotation = Quaternion.Euler(Angle, 0.0f, 0.0f);
			StartCoroutine(waitToHide());
		}

		protected virtual void Update()
		{
			indicator.transform.position = this.transform.position;
			// indicator.transform.RotateAround(this.transform.position, Vector3.right, -Angle);
			// //indicator.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -Angle);
		}
		IEnumerator waitToHide() {
			yield return new WaitForSeconds(.5f);
			indicator.SetActive(false);
		}
	}
}