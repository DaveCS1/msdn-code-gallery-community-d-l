
// MFCTaskbarDoc.cpp : impl�mentation de la classe CMFCTaskbarDoc
//

#include "stdafx.h"
// SHARED_HANDLERS peuvent �tre d�finis dans les gestionnaires d'aper�u, de miniature
// et de recherche d'impl�mentation de projet ATL et permettent la partage de code de document avec ce projet.
#ifndef SHARED_HANDLERS
#include "MFCTaskbar.h"
#endif

#include "MFCTaskbarDoc.h"

#include <propkey.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// CMFCTaskbarDoc

IMPLEMENT_DYNCREATE(CMFCTaskbarDoc, CDocument)

BEGIN_MESSAGE_MAP(CMFCTaskbarDoc, CDocument)
END_MESSAGE_MAP()


// construction ou destruction de CMFCTaskbarDoc

CMFCTaskbarDoc::CMFCTaskbarDoc()
{
	// TODO: ajoutez ici le code d'une construction unique

}

CMFCTaskbarDoc::~CMFCTaskbarDoc()
{
}

BOOL CMFCTaskbarDoc::OnNewDocument()
{
	if (!CDocument::OnNewDocument())
		return FALSE;
	if (!m_viewList.IsEmpty())
	{
		reinterpret_cast<CEditView*>(m_viewList.GetHead())->SetWindowText(NULL);
	}

	// TODO: ajoutez ici le code de r�initialisation
	// (les documents SDI r�utiliseront ce document)

	return TRUE;
}




// s�rialisation de CMFCTaskbarDoc

void CMFCTaskbarDoc::Serialize(CArchive& ar)
{
	// CEditView contient un contr�le d'�dition qui g�re toutes les op�rations de s�rialisation
	if (!m_viewList.IsEmpty())
	{
		reinterpret_cast<CEditView*>(m_viewList.GetHead())->SerializeRaw(ar);
	}
#ifdef SHARED_HANDLERS

	if (m_viewList.IsEmpty() && ar.IsLoading())
	{
		CFile* pFile = ar.GetFile();
		pFile->Seek(0, FILE_BEGIN);
		ULONGLONG nFileSizeBytes = pFile->GetLength();
		ULONGLONG nFileSizeChars = nFileSizeBytes/sizeof(TCHAR);
		LPTSTR lpszText = (LPTSTR)malloc(((size_t)nFileSizeChars + 1) * sizeof(TCHAR));
		if (lpszText != NULL)
		{
			ar.Read(lpszText, (UINT)nFileSizeBytes);
			lpszText[nFileSizeChars] = '\0';
			m_strThumbnailContent = lpszText;
			m_strSearchContent = lpszText;
		}
	}
#endif
}

#ifdef SHARED_HANDLERS

// Prise en charge des miniatures
void CMFCTaskbarDoc::OnDrawThumbnail(CDC& dc, LPRECT lprcBounds)
{
	// Modifier ce code pour dessiner les donn�es du document
	dc.FillSolidRect(lprcBounds, RGB(255, 255, 255));

	LOGFONT lf;

	CFont* pDefaultGUIFont = CFont::FromHandle((HFONT) GetStockObject(DEFAULT_GUI_FONT));
	pDefaultGUIFont->GetLogFont(&lf);
	lf.lfHeight = 36;

	CFont fontDraw;
	fontDraw.CreateFontIndirect(&lf);

	CFont* pOldFont = dc.SelectObject(&fontDraw);
	dc.DrawText(m_strThumbnailContent, lprcBounds, DT_CENTER | DT_WORDBREAK);
	dc.SelectObject(pOldFont);
}

// Support pour les gestionnaires de recherche
void CMFCTaskbarDoc::InitializeSearchContent()
{
	// D�finir le contenu de recherche � partir des donn�es du document. 
	// Les parties du contenu doivent �tre s�par�es par ";"

	// Utilisez l'int�gralit� du contenu du fichier texte comme contenu de recherche.
	SetSearchContent(m_strSearchContent);
}

void CMFCTaskbarDoc::SetSearchContent(const CString& value)
{
	if (value.IsEmpty())
	{
		RemoveChunk(PKEY_Search_Contents.fmtid, PKEY_Search_Contents.pid);
	}
	else
	{
		CMFCFilterChunkValueImpl *pChunk = NULL;
		ATLTRY(pChunk = new CMFCFilterChunkValueImpl);
		if (pChunk != NULL)
		{
			pChunk->SetTextValue(PKEY_Search_Contents, value, CHUNK_TEXT);
			SetChunkValue(pChunk);
		}
	}
}

#endif // SHARED_HANDLERS

// diagnostics pour CMFCTaskbarDoc

#ifdef _DEBUG
void CMFCTaskbarDoc::AssertValid() const
{
	CDocument::AssertValid();
}

void CMFCTaskbarDoc::Dump(CDumpContext& dc) const
{
	CDocument::Dump(dc);
}
#endif //_DEBUG


// commandes pour CMFCTaskbarDoc
