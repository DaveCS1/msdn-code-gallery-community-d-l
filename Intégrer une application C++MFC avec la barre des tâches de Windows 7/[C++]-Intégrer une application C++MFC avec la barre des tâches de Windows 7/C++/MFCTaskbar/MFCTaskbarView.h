
// MFCTaskbarView.h : interface de la classe CMFCTaskbarView
//

#pragma once


class CMFCTaskbarView : public CEditView
{
protected: // cr�ation � partir de la s�rialisation uniquement
	CMFCTaskbarView();
	DECLARE_DYNCREATE(CMFCTaskbarView)

// Attributs
public:
	CMFCTaskbarDoc* GetDocument() const;

// Op�rations
public:

// Substitutions
public:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:

// Impl�mentation
public:
	virtual ~CMFCTaskbarView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Fonctions g�n�r�es de la table des messages
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // version debug dans MFCTaskbarView.cpp
inline CMFCTaskbarDoc* CMFCTaskbarView::GetDocument() const
   { return reinterpret_cast<CMFCTaskbarDoc*>(m_pDocument); }
#endif

