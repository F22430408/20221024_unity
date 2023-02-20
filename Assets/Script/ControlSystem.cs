using UnityEngine;
using System.Collections;

/// <summary>
/// 控制系統
/// </summary>
namespace TOM
{
	public class ControlSystem : MonoBehaviour
	{
		#region 資料

		[SerializeField, Header("旋轉速度"), Range(0, 50)]
		private float speedTurn = 10.5f;
		[SerializeField, Header("可以發射的彈珠數量"), Range(0, 100)]
		private int countMarbleShoot = 10;
		[SerializeField, Header("彈珠速度"), Range(0, 5000)]
		private int speedMarble = 1500;
		[SerializeField, Header("彈珠發射間隔"), Range(0, 100)]
		private float fireInterval = 0.5f;
		[SerializeField, Header("彈珠預製物")]
		private GameObject perfabMarble;
		private string senceAttack = "觸發攻擊";
		[SerializeField, Header("生成彈珠位置")]
		private Transform pointSpawnMarble;
		[SerializeField, Header("箭頭物件")]
		private GameObject goArrow;
		[SerializeField, Header("玩家滑鼠位置")]
		private Transform pointPlayerMouse;
		#endregion

		#region 事件
		private void Awake()
		{
			//StartCoroutine(ShootMarble());
		}
		private void Update()
		{
			InputManager();
		}
		#endregion

		#region 方法
		/// <summary>
		/// 發射彈珠
		/// </summary>
		private void InputManager()
		{
			if (Input.GetKeyDown(KeyCode.Mouse0))
			{
				print("按下左鍵");
				goArrow.SetActive(true);
			}
			else if (Input.GetKey(KeyCode.Mouse0))
			{
				print("<color=red> 按住左鍵 </color>");
				SetMousePosition();
			}
			else if (Input.GetKeyUp(KeyCode.Mouse0))
			{
				print("<color=yellow> 放開左鍵 </color>");
				goArrow.SetActive(false);
				StartCoroutine(ShootMarble());

			}
		}
		/// <summary>
		/// 設定滑鼠座標
		/// </summary>
		private void SetMousePosition()
		{
			Vector3 posMouse = Input.mousePosition;                     //滑鼠座標
																		//print($"<color=#ff9966> 滑鼠座標：{posMouse}</color>");

			posMouse.z = 10;

			Vector3 posWorld = Camera.main.ScreenToWorldPoint(posMouse);//滑鼠座標轉世界座標
																		//print($"<color=#99ff66>轉換後的世界座標：{posWorld}</color>");
			pointPlayerMouse.position = posWorld;

			transform.LookAt(posWorld);

			Vector3 angle = transform.eulerAngles;
			angle.x = 0;
			angle.z = 0;
			transform.eulerAngles = angle;
		}
		private IEnumerator ShootMarble()
		{
			for (int i = 0; i < countMarbleShoot; i++)
			{
				// 暫存彈珠 = 生成物件(要生成的物件)
				// Quaternion.identity 零度角
				GameObject tempMarble = Instantiate(perfabMarble, pointSpawnMarble.position, Quaternion.identity);
				//tempMarble.GetComponent<Rigidbody>().AddForce(0, 0, speedMarble);
				// X - trasform.right	紅色軸向
				// Y - trasform.up		綠色軸向
				// Z - trasform.forward 藍色軸向
				tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);
				yield return new WaitForSeconds(fireInterval);
			}

		}
		#endregion
	}

}