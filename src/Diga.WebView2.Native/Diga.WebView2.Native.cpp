#include "pch.h"
#include "Diga.WebView2.Native.h"

//#include <iterator>
#include <string>
#include <vector>



class DIGAAutoCoMemString {
public:
	DIGAAutoCoMemString() {}
	~DIGAAutoCoMemString() { Release(); }
	void Release() {
		if (m_string) {
			CoTaskMemFree(m_string);
			m_string = nullptr;
		}
	}

	LPCWSTR Set(LPCWSTR str) {
		Release();
		if (str) {
			m_string = MakeCoMemString(str);
		}
		return m_string;
	}
	LPCWSTR Get() { return m_string; }
	LPWSTR Copy() {
		if (m_string)
			return MakeCoMemString(m_string);
		return nullptr;
	}

protected:
	LPWSTR MakeCoMemString(LPCWSTR source) {
		const size_t length = wcslen(source);
		const size_t bytes = (length + 1) * sizeof(*source);
		// Ensure we didn't overflow during our size calculation.
		if (bytes <= length) {
			return nullptr;
		}

		wchar_t* result = reinterpret_cast<wchar_t*>(CoTaskMemAlloc(bytes));
		if (result)
			memcpy(result, source, bytes);

		return result;
	}

	LPWSTR m_string = nullptr;
};



DIGAWEBVIEW2NATIVE_API HRESULT ShowInfo()
{
	MessageBox(nullptr, CORE_WEBVIEW_TARGET_PRODUCT_VERSION, L"Version", MB_OK);
	return S_OK;
}

DIGAWEBVIEW2NATIVE_API HRESULT CompareVersion(PCWSTR source, PCWSTR destination, int* result)
{
	return CompareBrowserVersions(source, destination, result);
}

DIGAWEBVIEW2NATIVE_API HRESULT GetAvailableVersion(PCWSTR executableFolder, LPWSTR* versionInfo)
{
	return GetAvailableCoreWebView2BrowserVersionString(executableFolder, versionInfo);
}

DIGAWEBVIEW2NATIVE_API HRESULT CreateEnvironment(ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler* ptrCreateCoreHandler)
{
	return CreateCoreWebView2Environment(ptrCreateCoreHandler);
}

DIGAWEBVIEW2NATIVE_API HRESULT CreateEnvironmentWithOptions(PCWSTR browserExecuteFolder, PCWSTR userDateFolder, ICoreWebView2EnvironmentOptions* ptrOptions, ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler* ptrHandler)
{
	return CreateCoreWebView2EnvironmentWithOptions(browserExecuteFolder, userDateFolder, ptrOptions, ptrHandler);
}

DIGAWEBVIEW2NATIVE_API HRESULT GetCurrentVersion(LPWSTR* version)
{
	const auto autoString = new DIGAAutoCoMemString();
	autoString->Set(CORE_WEBVIEW_TARGET_PRODUCT_VERSION);
	*version = autoString->Copy();
	delete autoString;
	return S_OK;
}


