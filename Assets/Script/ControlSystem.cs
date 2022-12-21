using UnityEngine;

/// <summary>
/// 控制系統
/// </summary>
namespace TOM
{
	public class ControlSystem : MonoBehaviour
	{
		[SerializeField, Header("旋轉速度"), Range(0, 50)]
		private float rangsp = 10.5f;
		[SerializeField, Header("可以發射的彈珠數量"), Range(0, 100)]
		private int babbleam = 10;
		[SerializeField, Header("彈珠速度"), Range(0, 5000)]
		private int babblesp = 1500;
		[SerializeField, Header("彈珠發射間隔"), Range(0, 100)]
		private float babbleblank = 0.5f;
		[SerializeField, Header("彈珠預製物")]
		private GameObject babble1;
		private string Attacksence = "觸發攻擊";
	}

}