#pragma once
#include <wrl.h>
#include <wil/com.h>
#include <WebView2.h>
#include <WebView2EnvironmentOptions.h>
#include <Windows.h>
#ifdef DIGAWEBVIEW2NATIVE_EXPORTS
#define  DIGAWEBVIEW2NATIVE_API __declspec(dllexport)
#else
#define DIGAWEBVIEW2NATIVE_API __declspec(dllimport)
#endif

extern "C"  DIGAWEBVIEW2NATIVE_API HRESULT ShowInfo();
extern "C" DIGAWEBVIEW2NATIVE_API HRESULT CompareVersion(PCWSTR source, PCWSTR destination, int* result);
extern "C" DIGAWEBVIEW2NATIVE_API HRESULT GetAvailableVersion(PCWSTR executableFolder, LPWSTR* versionInfo);
extern "C" DIGAWEBVIEW2NATIVE_API HRESULT CreateEnvironment(ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler* ptrCreateCoreHandler);
extern "C" DIGAWEBVIEW2NATIVE_API HRESULT CreateEnvironmentWithOptions(PCWSTR browserExecuteFolder, PCWSTR userDateFolder, ICoreWebView2EnvironmentOptions* ptrOptions, ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler* ptrHandler);
extern "C" DIGAWEBVIEW2NATIVE_API HRESULT GetCurrentVersion(LPWSTR* version);