//PCMgrLoader.cpp: 定义应用程序的入口点。
//

#include "stdafx.h"
#include "PCMgrLoader.h"
#include <shellapi.h>
#include <shlwapi.h>

HINSTANCE hInst;
WCHAR startPath[MAX_PATH];
WCHAR exePath[MAX_PATH];
WCHAR dll1Path[MAX_PATH];
WCHAR dll2Path[MAX_PATH];

using namespace System;
using namespace System::IO;
using namespace System::Reflection;

int APIENTRY wWinMain(_In_ HINSTANCE hInstance, _In_opt_ HINSTANCE hPrevInstance, _In_ LPWSTR lpCmdLine, _In_ int nCmdShow)
{
	LPWSTR *szArglist = NULL;
	int nArgs = 0;
	szArglist = CommandLineToArgvW(GetCommandLineW(), &nArgs);
	if (NULL != szArglist)
	{
		wcscpy_s(startPath, szArglist[0]);
		PathRemoveFileSpec(startPath);
		wcscpy_s(exePath, startPath);
#if _X64_
		wcscat_s(exePath, L"\\app\\x64\\PCMgr64.exe");
		wcscat_s(dll1Path, L"\\app\\x64\\PCMgr64.dll");
		wcscat_s(dll2Path, L"\\app\\x64\\PCMgrUWP.dll");
#else
		wcscat_s(exePath, L"\\app\\x86\\PCMgr32.exe"); 
		wcscat_s(dll1Path, L"\\app\\x86\\PCMgr32.dll");
		wcscat_s(dll2Path, L"\\app\\x86\\PCMgrUWP.dll");
#endif
		if (_waccess(exePath, 0) == 0) 
		{
			LoadLibrary(dll1Path);
			LoadLibrary(dll2Path);


		}
		else MessageBox(NULL, L"Failed to load main app.", L"ERROR", MB_ICONERROR);
		LocalFree(szArglist);
	}
	return 0;
}


