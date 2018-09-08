using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace net.matcha_choco010.SingletonMonoBehaviour {

	public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T> {

		private static T instance;
		public static T Instance {
			get {
				if (instance == null) {
					instance = (T) FindObjectOfType (typeof (T));

					if (instance == null) {
						Debug.LogError ($"{typeof(T)} is nothing");
					}
				}
				return instance;
			}
		}

		protected void Awake () {
			if (this != Instance) {
				Debug.LogError ($"{typeof(T)} is duplicated");
			}
		}

	}

}
