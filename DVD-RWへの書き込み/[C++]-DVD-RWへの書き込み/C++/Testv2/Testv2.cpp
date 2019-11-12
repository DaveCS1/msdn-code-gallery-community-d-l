// Testv2.cpp : �R���\�[�� �A�v���P�[�V�����̃G���g�� �|�C���g���`���܂��B
//

#include "stdafx.h"

//
// IMAPI V2 �C���^�[�t�F�[�X�𗘗p�����T���v����
// �X�}�[�g�|�C���^�[��

// IMAPI V2 �C���^�[�t�F�[�X
_COM_SMARTPTR_TYPEDEF( IDiscMaster2 , __uuidof(IDiscMaster2) );
_COM_SMARTPTR_TYPEDEF( IDiscRecorder2 , __uuidof(IDiscRecorder2) );
_COM_SMARTPTR_TYPEDEF( IFileSystemImage , __uuidof(IFileSystemImage) );
_COM_SMARTPTR_TYPEDEF( IFsiDirectoryItem , __uuidof(IFsiDirectoryItem) );
_COM_SMARTPTR_TYPEDEF( IFileSystemImageResult , __uuidof(IFileSystemImageResult) );
_COM_SMARTPTR_TYPEDEF( IDiscFormat2Data , __uuidof(IDiscFormat2Data) );


BSTR g_appName = ::SysAllocString(L"IMAPIv2 TEST");

// �f�X�N�ւ̏�������
void WriteToDisc(LPCWSTR folder)
{
    HRESULT hr;
    IDiscMaster2Ptr DiscMaster2 = NULL;
    IDiscRecorder2Ptr DiscRecorder2 = NULL;
    IDiscFormat2DataPtr DiscFormat2Data = NULL;
	BSTR path =  ::SysAllocString(folder);

	// DiscMaster2�C���X�^���X�̍쐬
    hr = DiscMaster2.CreateInstance( CLSID_MsftDiscMaster2 );
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	// DiscRecorder2�C���X�^���X�̍쐬
    hr = DiscRecorder2.CreateInstance( CLSID_MsftDiscRecorder2 );
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	// IDiscFormat2Data�C���X�^���X�̍쐬
    hr = DiscFormat2Data.CreateInstance( CLSID_MsftDiscFormat2Data );
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	//
    // ���R�[�_�[�̑I��
	//
	BSTR uniqueId;

	hr = DiscMaster2->get_Item(0, &uniqueId);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = DiscRecorder2->InitializeDiscRecorder( uniqueId );
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = DiscFormat2Data->put_Recorder(DiscRecorder2);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}


	//
	// HDD��̃t�H���_���� �\�����X�g���[�W���쐬
	//
    IFileSystemImagePtr FileSystemImage = NULL;
	IFsiDirectoryItemPtr root = NULL;
	IFileSystemImageResultPtr result = NULL;
	IStreamPtr stream = NULL;
	
	hr = FileSystemImage.CreateInstance( CLSID_MsftFileSystemImage );
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = FileSystemImage->put_FileSystemsToCreate( FsiFileSystemUDF ); // UDF ���쐬
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

		hr = FileSystemImage->ChooseImageDefaultsForMediaType( IMAPI_MEDIA_TYPE_DVDDASHRW ); // DVD-RW
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = FileSystemImage->get_Root(&root);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = root->AddTree(path, VARIANT_FALSE);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = FileSystemImage->CreateResultImage(&result);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = result->get_ImageStream(&stream);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	//
	// �����̐ݒ�
	//
	hr = DiscFormat2Data->put_ForceMediaToBeClosed(VARIANT_TRUE);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	hr = DiscFormat2Data->put_ClientName(g_appName);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}


	//
    // �������݊J�n
	//
    wprintf_s(L"���f�B�A�ɏ�������\n");
	hr = DiscFormat2Data->Write(stream);
    if ( !SUCCEEDED(hr) )
	{
		wprintf_s(L"Error (0x%x) (%d)\n", hr, __LINE__);
		return;
	}

	wprintf_s(L"�������ݏI��\n");


	return;
}

// ���C������
// �����F�������ރt�H���_
int _tmain(int argc, _TCHAR* argv[])
{
    HRESULT hr;

    _wsetlocale( LC_ALL, L"jpn" );

	if ( argc != 2 )
	{
		wprintf_s(L"�����F�������ރt�H���_�̃t���p�X\n");
		return 1;
	}

    // COM�̏�����
    hr = ::CoInitialize(NULL);
	
	// ��������
	WriteToDisc(argv[1]);
	
	// COM�̏I��
    ::CoUninitialize();

	return 0;
}

