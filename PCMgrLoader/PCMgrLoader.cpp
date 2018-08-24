#include "stdafx.h"
#include "PCMgrLoader.h"
#include "DyFuns.h"
#include "mcrt.h"

extern bool basedllfailed;
extern WCHAR*usedguid;
WCHAR iniPath[MAX_PATH];

void show_err(const wchar_t* err)
{
	_MessageBoxW(NULL, (LPWSTR)err, PCMGRTITLE, MB_ICONERROR);
}

bool IsWindowsVersionOrGreater(WORD wMajorVersion, WORD wMinorVersion, WORD wServicePackMajor)
{
	RTL_OSVERSIONINFOEXW verInfo;
	verInfo.dwOSVersionInfoSize = sizeof(verInfo);
	m_memset((char*)&verInfo, 0, sizeof(verInfo));

	if (RtlGetVersion != 0 && RtlGetVersion((PRTL_OSVERSIONINFOW)&verInfo) == 0)
	{
		if (verInfo.dwMajorVersion > wMajorVersion)
			return true;
		else if (verInfo.dwMajorVersion < wMajorVersion)
			return false;
		if (verInfo.dwMinorVersion > wMinorVersion)
			return true;
		else if (verInfo.dwMinorVersion < wMinorVersion)
			return false;
		if (verInfo.wServicePackMajor >= wServicePackMajor)
			return true;
	}

	return false;
}
bool test_system_support()
{
	if (!IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_WIN7), LOBYTE(_WIN32_WINNT_WIN7), 0))
	{
		show_err(L"Application not support your Windows, Running this program requires Windows 7 at least.");
		return false;
	}	
	return true;
}

int main()
{
	if(!LoadDyamicFuns())return -1;

	if (!test_system_support())return -1;
	if(basedllfailed)
	{
		show_err(L"Load base dll failed !");
		return 0;
	}

	MAppSet(1, usedguid);
	MAppMainRun();

	return MAppMainGetExitCode();
}
int main_entry() {
	int rs = main();
	_ExitProcess(rs);
	return rs;
}

void try_get() 
{

}







