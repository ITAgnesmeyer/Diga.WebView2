#include "pch.h"
#include "Diga.WebView2.Native.h"
#include "RpcObject.h"	
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

DIGAWEBVIEW2NATIVE_API HRESULT GetIDispatchVariant(IUnknown* pUnknown, VARIANT** ppVariant)
{
	if (pUnknown == nullptr || ppVariant == nullptr)
	{
		return E_POINTER;
	}

	// Versuchen, IDispatch aus IUnknown zu erhalten
	IDispatch* pDispatch = nullptr;
	HRESULT hr = pUnknown->QueryInterface(IID_IDispatch, (void**)&pDispatch);
	if (FAILED(hr))
	{
		return hr; // IDispatch ist nicht verfügbar
	}

	// VARIANT initialisieren
	*ppVariant = new VARIANT();
	VariantInit(*ppVariant);

	// IDispatch in VARIANT speichern
	(*ppVariant)->vt = VT_DISPATCH;
	(*ppVariant)->pdispVal = pDispatch; // pDispatch enthält AddRef aus QueryInterface

	return S_OK;
}

DIGAWEBVIEW2NATIVE_API HRESULT GetIUnknownVariant(IUnknown* pUnknown, VARIANT** ppVariant)
{
	if (pUnknown == nullptr || ppVariant == nullptr)
	{
		return E_POINTER;
	}
	*ppVariant = new VARIANT();
	VariantInit(*ppVariant);
	(*ppVariant)->vt = VT_UNKNOWN;
	(*ppVariant)->punkVal = pUnknown;
	return S_OK;
}

DIGAWEBVIEW2NATIVE_API HRESULT GetIUnknownPointerFromObject(VARIANT* pVariant, IUnknown** ppUnknown)
{
	if (pVariant == nullptr || ppUnknown == nullptr)
	{
		return E_POINTER;
	}

	*ppUnknown = nullptr;

	// Überprüfen, ob das VARIANT ein IUnknown enthält
	if (pVariant->vt == VT_UNKNOWN && pVariant->punkVal != nullptr)
	{
		*ppUnknown = pVariant->punkVal;
		(*ppUnknown)->AddRef();
		return S_OK;
	}

	// Überprüfen, ob das VARIANT ein IDispatch enthält und in IUnknown umgewandelt werden kann
	if (pVariant->vt == VT_DISPATCH && pVariant->pdispVal != nullptr)
	{
		return pVariant->pdispVal->QueryInterface(IID_IUnknown, (void**)ppUnknown);
	}

	return E_NOINTERFACE; // Weder IUnknown noch IDispatch verfügbar

}

DIGAWEBVIEW2NATIVE_API HRESULT GetRpcObject(IRpcObject** ppRpcObject)
{
	if (ppRpcObject == nullptr)
	{
		return E_POINTER;
	}

	// Erstelle eine Instanz von RpcObject
	RpcObject* pObject = new RpcObject();

	// Gebe die Instanz zurück
	*ppRpcObject = pObject;
	return S_OK;
}

