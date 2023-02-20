using UnityEngine;

namespace TOM
{
	public class LearnAPI : MonoBehaviour
    {
		/// 學習非靜態 API
		/// 與靜態的差異在於非靜態需要實體物件
		/// </summary>
		
		
			// 屬性
			// 1.取得

			// 語法：
			// 類別名稱 欄位名稱; - 欄位，儲存實體物件用
			// 欄位名稱.屬性名稱;
			public Transform cube;
			public BoxCollider cubeBox;



			// 2. 設定
			// 類別名稱 欄位名稱; - 欄位，儲存實體物件用
			// 欄位名稱.屬性名稱 指定 值;

			// 方法
			// 3. 使用方法
			// 類別名稱 欄位名稱; - 欄位，儲存實體物件用
			// 欄位名稱.方法名稱(對應的引數);
			public Transform andrew;

			public BoxCollider boxCollider;
			public Canvas canvas;
			public AudioSource audioSource;

			public Rigidbody sphere;
			public Transform transformBox;
			public Transform transformSphere;
			public Transform transformCapsule;

			private void Awake()
			{
				// Random.value				//靜態的語法
				// Transform.position		//錯誤的用法
				print($"立方體的座標： { cube.position }");
				print($"立方體的方形碰撞尺寸： { cubeBox.size }");

				cube.eulerAngles = new Vector3(0, -30, 0);
				cubeBox.center = new Vector3(0, 5, 0);
			}
			private void Start()
			{
				print($"音效來源的音量： { audioSource.volume }");
				print($"畫布的渲染方式： { canvas.renderMode }");
				print($"立方體的碰撞器尺寸： { boxCollider.size }");
				boxCollider.center = new Vector3(1, 3, 1);
				audioSource.volume = 0.5f;
				canvas.renderMode = RenderMode.WorldSpace;

				sphere.AddForce(new Vector3(0, 1500, 0));       //球體.添加推力(x,y,z)
			}
			private void Update()
			{
				andrew.Rotate(10, 0, 0);
				transformBox.LookAt(transformSphere);           // 立方體.面向(球體)
				transformCapsule.Translate(0, 0, 3);            // 膠囊體.位移(x, y, z)
			}
		}
	}