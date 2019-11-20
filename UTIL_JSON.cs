// Helper functions for JSONObject
namespace JSONObject {
	public class UTIL_JSON {
		public static void SetString_Protected(ref string _strToSet, string _key, JSONObject _json, string _default = null) {
			JSONObject jsob = _json[_key];
			if (jsob == null || !jsob.IsString) {
				if (_default != null) {
					_strToSet = _default;
				}
				return;
			}

			_strToSet = jsob.str;
		}

		public static void SetBool_Protected(ref bool _bToSet, string _key, JSONObject _json, bool _bUseDefault = false, bool _bDefault = false) {
			JSONObject jsob = _json[_key];
			if (jsob == null || !jsob.IsBool) {
				if (_bUseDefault) {
					_bToSet = _bDefault;
				}
				return;
			}

			_bToSet = jsob.b;
		}

		public static void SetInt_Protected(ref int _nToSet, string _key, JSONObject _json, bool _bUseDefault = false, int _nDefault = 0) {
			JSONObject jsob = _json[_key];
			if (jsob == null || !jsob.IsNumber) {
				if (_bUseDefault) {
					_nToSet = _nDefault;
				}
				return;
			}

			_nToSet = (int)jsob.i;
		}

		public static void SetFloat_Protected(ref float _fToSet, string _key, JSONObject _json, bool _bUseDefault = false, float _fDefault = 0) {
			JSONObject jsob = _json[_key];
			if (jsob == null || !jsob.IsNumber) {
				if (_bUseDefault) {
					_fToSet = _fDefault;
				}
				return;
			}

			_fToSet = jsob.f;
		}
	}
}