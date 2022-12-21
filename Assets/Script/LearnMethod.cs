using UnityEngine;

namespace Tom
{
	/// <summary>
	/// 學習方法、功能、程式
	/// Method、Fountion
	/// </summary>
	public class LearnMethod : MonoBehaviour
	{

		private void Awake()
		{
			test1();
			ShootFire();
			ShootIce();
			ShootThund();
			shoot("光");     // 呼叫時放在小括號的稱為引數
			shoot("水");    // 有預設值的參數可以不用填，選填式參數
			shoot("毒");
			//火，咻咻咻，灰燼
			//Shoot("火","灰燼");// 錯誤，灰燼跑錯地方
			Shoot("火", effect: "灰燼");
		}


		//方法
		//語法：
		//參數沒有數量限制，但限制不要太多
		//修飾詞 傳回資料類型 方法名稱(參數類型 參數名稱,參數類型 參數名稱,...)
		//{
		//}
		// void 無
		#region 方法
		private void test1()
		{
			print("我是測試方法");
		}
		private void ShootFire()
		{
			print("球的屬性：火");
			print("播放音效：咻咻咻");
		}
		private void ShootThund()
		{
			print("球的屬性：電");
			print("播放音效：滋滋滋");
		}
		private void ShootIce()
		{
			print("球的屬性：冰");
			print("播放音效：無");
		}
		private void shoot(string type)
		{
			print("球的屬性：" + type);
		}
		#endregion
		//參數可以添加預設值，呼叫時可不用填
		private void Shoot(string type, string sound = "咻咻咻", string effect = "光點")
		{
			print("<color=blue>球的屬性：" + type + "</color>");
			print("<color=blue>播放音效：" + sound + "</color>");
			print($"<Color=#3366ff>播放音效： {effect} </color>");
		}
		/*多行註解
		 * 錯誤範例:選填式參數要寫在右邊
		 private void wrongSample(string a = "哈囉", string b)
		{

		}
		 */
	}
}

