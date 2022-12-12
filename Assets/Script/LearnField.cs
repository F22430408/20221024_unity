using UnityEngine;
/// <summary>
/// 摘要
/// </summary>
public class LearnField : MonoBehaviour
{
	#region 欄位基礎語法與四大類型
	// 欄位 Field
	// 作用 儲存遊戲類的資料 例如血量跟等級

	//語法:
	//欄位名子小寫開頭
	//資料類型 欄位名稱
	int leve1;

	//C# 常用四大類型
	//整數 負數 沒有小數點 例1 999 -123
	int enemyCount;
	//浮數點 正負有小數點 例1.23 -9.99
	float speed;
	//字 串 文字訊息
	string namePlayer;
	//布林直 儲存兩個值  是或否
	bool isDead;

	// 語法
	// = 指定符號:將右邊的值給左邊
	public int skillCount = 3;
	public float speedTurn = 9.5f;
	public float speedWaik = 3.7f;
	public string namePet = "@皮卡丘@";
	public bool isGrounded = true;
	public bool isPass = false;
	#endregion

	#region 欄位完整語法與範例
	private void Awake()
	{
		print("技能數量:" + skillCount);
		print("旋轉速度:" + speedTurn);
		speedWaik = 7.2f;
		isPass = true;
	}
	#endregion

	//標題
	[Header("武器名稱")]
	public string nameWeapon = "美工刀";
	//提示
	[Tooltip("指玩家的等級")]
	public int lv = 70;
	//範圍(最大 最小)= 僅限浮點數和整數使用
	[Range (10,500)]
	public float attack = 3.5f;
	[Range (1,50)]
	public int defense = 10;
	[Range (7,100)]
	public bool hasWeapon;

	//序列化: 將私人資料夾顯示
	[SerializeField]
	private float hp = 200;
	[Header("數量")]
	[Range(0,10)]
	public int count;
	[Header("是否擁有道具"), Tooltip("是否擁有重要道具")]
	public bool hasProp;
	
}
