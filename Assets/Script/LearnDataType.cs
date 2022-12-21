using UnityEngine;

namespace TOM
{
	/// <summary>
	/// 學習 Unity 資料類型
	/// Unity 開發遊戲常用的資料型態
	/// </summary>
	public class LearnDataType : MonoBehaviour
	{
		//語法:
		//修飾詞 資料類型 欄位名稱 指定 預設值;

		#region 顏色與座標
		//顏色與座標 Color & Vector
		public Color color1;

		public Color colorRed = Color.red;
		public Color colorYellow = Color.yellow;
		public Color colorGreen = Color.green;

		//color(紅，綠，藍，透明度) - 0 ~ 1
		public Color colorCustom1 = new Color(0.5f, 0.5f, 0);
		public Color colorCustom2 = new Color(0, 0.5f, 0.5f, 0.5f);

		[Header("座標")]
		public Vector2 ver1;
		public Vector3 ver2;
		public Vector4 ver3;

		public Vector2 vver1 = Vector2.one;
		public Vector2 vver2 = new Vector2(55, 100);
		#endregion

		//資料
		public Sprite image;            //圖片
		public AudioClip sound;         //音效，音樂
		public Material mat;            //材質球
		public GameObject prefab;       //預製物
		public GameObject sceneObject;  //場景上的物件
	}
}
