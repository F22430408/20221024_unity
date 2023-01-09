using UnityEngine;

namespace TOM
{
	/// <summary>
	/// 學習API :靜態 Statis
	/// 已經儲存在電腦裡
	/// </summary>

	public class LearnAPIStatic : MonoBehaviour
	{
		private void Awake()
		{
			//靜態屬性 Static prorerties
			//1.取得
			//2.設定
			print("隨機值:" + Random.value);
			print("當前指標能見度:" + Cursor.visible);

			//設定
			//語法:
			//類別.
			Cursor.visible = false;  //隱藏滑鼠
			Screen.fullScreen = true;  //設定全螢幕

			//唯獨屬性不能設定(Read Only)
			//Random.value = 1.234f;

			//靜態方法 Static Method
			//語法
			//類別.靜態方法名稱(對應的引號);
			print(Mathf.Abs(-321.5f)); //數學 . //絕對值(數值)

			//Random.RandoRange(100f, 200f);  //以過時的API 建議不要用

			float random = Random.Range(100f, 200f);
			print($"<color=yellow>隨機值介於 100 與 200 :{random}</color>");

		}
	}
}