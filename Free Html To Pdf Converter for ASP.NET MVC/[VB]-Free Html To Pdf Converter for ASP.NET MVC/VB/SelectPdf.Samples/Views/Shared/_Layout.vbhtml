﻿<!DOCTYPE html>
<!--[if IE 7]>
<html class="ie ie7" lang="en-US">
<![endif]-->
<!--[if IE 8]>
<html class="ie ie8" lang="en-US">
<![endif]-->
<!--[if !(IE 7) & !(IE 8)]><!-->
<html lang="en-US">
<!--<![endif]-->
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width">
    <title>@ViewBag.Title</title>
    <meta name="description" content="@ViewBag.Description" itemprop="description">
    <meta name="keywords" content="@ViewBag.Keywords" itemprop="keywords">

    <!--[if lt IE 9]>
    <script src="files/html5.js" type="text/javascript"></script>
    <![endif]-->
    <link id="tfg_style-css" href="~/files/tfg_style.css" rel="stylesheet" type="text/css" media="all">
    <link id="twentytwelve-fonts-css" href="~/files/css.css" rel="stylesheet" type="text/css" media="all">
    <link id="twentytwelve-style-css" href="~/files/style.css" rel="stylesheet" type="text/css" media="all">
    <!--[if lt IE 9]>
    <link rel='stylesheet' id='twentytwelve-ie-css'  href='files/ie.css?ver=20121010' type='text/css' media='all' />
    <![endif]-->
    <script src="~/files/jquery.js" type="text/javascript"></script>
    <script src="~/files/jquery-migrate.min.js" type="text/javascript"></script>
    <link href="https://plus.google.com/+SelectPdfPage" rel="author">

    <style id="twentytwelve-header-css" type="text/css">
        .site-header h1 a,
        .site-header h2 {
            color: #454545;
        }
    </style>

    <style id="custom-background-css" type="text/css">
        body.custom-background {
            background-color: #f9ffff;
        }
    </style>
</head>
<body class="single single-post single-format-standard custom-background custom-font-enabled single-author">
    <div class="hfeed site" id="page">
        <header class="site-header" id="masthead"
                role="banner">
            <div class="float-left">
                <a title="SelectPdf for .NET Library Samples" href="~/"><img width="319" height="101" class="header-image" alt="SelectPdf for .NET Library Samples" src="~/files/logo.png"></a>
            </div>
            <nav class="main-navigation" id="site-navigation" role="navigation">
                <button class="menu-toggle">Menu</button>
                <a title="Skip to content" class="assistive-text"
                   href="#content">Skip to content</a>
                <div class="menu-menu-1-container">
                    <ul class="nav-menu" id="menu-menu-1">
                        <li class="menu-item menu-item-type-custom menu-item-object-custom menu-item-home menu-item-8" id="menu-item-1"><a href="http://selectpdf.com" runat="server">SelectPdf.com</a></li>
                        <li class="menu-item menu-item-type-custom menu-item-object-custom menu-item-home menu-item-8" id="menu-item-2"><a href="~/" runat="server">Samples</a></li>
                    </ul>
                </div>
            </nav>
            <!-- #site-navigation -->
        </header>
        <!-- #masthead -->

        <div class="wrapper" id="main">
            <div class="site-content" id="primary">
                <div id="content" role="main">
                    @RenderBody()
                    <br />
                    @If (Request.Url.AbsolutePath.ToLower().Contains("home") Or (Request.Url.AbsolutePath.ToLower().Length = 1)) Then
                        ' do not display code in this case
                    Else
                        Try
                            Dim code As String
                            code = System.IO.File.ReadAllText(Server.MapPath("Controllers\\" + ViewContext.RouteData.Values("controller").ToString() + "Controller.vb"))
                            code = New ColorCode.CodeColorizer().Colorize(code, ColorCode.Languages.VbDotNet)
                            ViewData.Add("Data", code)
                        Catch ex As Exception
                            Response.Write(ex.Message.ToString())
                        End Try
                    End If

                    @Code If (ViewData("Data") IsNot Nothing AndAlso ViewData("Data").ToString().Length > 0) Then
                    End Code
                    <h1>Sample Code VB.NET</h1><br /><br />
                    <div style = "overflow: auto; border: 1px solid #DDDDDD; padding: 10px;" >@Html.Raw(ViewData("Data"))</div>
                    @Code End If
                    End Code
                </div>
                <!-- #content -->
            </div>
            <!-- #primary -->
            <div class="widget-area" id="secondary" role="complementary">
                <aside class="widget widget_recent_entries">
                    <h3 class="widget-title">Html to Pdf Converter</h3>
                    <ul>
                        <li><a href="~/HtmlToPdfConverter" title="SelectPdf Library for .NET - Html to Pdf Converter">Getting Started</a></li>
                        <li><a href="~/ConvertUrlToPdf" title="Html To Pdf with SelectPdf Library for ASP.NET MVC">Convert Url To Pdf</a></li>
                        <li><a href="~/ConvertHtmlCodeToPdf" title="SelectPdf Library for .NET - Convert from html code to pdf">Convert Html Code to Pdf</a></li>
                        <li><a href="~/PdfConverterProperties" title="SelectPdf Library for .NET - Setting Document Properties with Html to Pdf Converter">Pdf Document Properties</a></li>
                        <li><a href="~/PdfConverterViewerPreferences" title="SelectPdf Library for .NET - Setting Pdf Viewer Preferences for the Html to Pdf Converter">Pdf Viewer Preferences</a></li>
                        <li><a href="~/PdfConverterSecurity" title="SelectPdf Library for .NET - Setting Pdf Document Security with the Html to Pdf Converter">Pdf Security Settings</a></li>
                        <li><a href="~/ConversionDelay" title="SelectPdf Library for .NET - Conversion Delay with Html to Pdf Converter">Conversion Delay</a></li>
                        <li><a href="~/HtmlToPdfHeadersAndFooters" title="SelectPdf Library for .NET - Pdf Headers and Footers with Html to Pdf Converter">Headers and Footers</a></li>
                        <li><a href="~/PageBreaks" title="SelectPdf Library for .NET - Control Page Breaks with Html to Pdf Converter">Page Breaks</a></li>
                        <li><a href="~/AutomaticBookmarks" title="SelectPdf Library for .NET - Automatic Bookmarks with Html to Pdf Converter">Automatic Bookmarks</a></li>
                        <li><a href="~/HttpHeaders" title="SelectPdf Library for .NET - Set HTTP Headers with Html to Pdf Converter">HTTP Headers</a></li>
                        <li><a href="~/HttpCookies" title="SelectPdf Library for .NET - Set HTTP Cookies with Html to Pdf Converter">HTTP Cookies</a></li>
                        <li><a href="~/HttpPostRequest" title="SelectPdf Library for .NET - Set parameters with a POST request with Html to Pdf Converter">HTTP POST Request</a></li>
                        <li><a href="~/MediaTypes" title="SelectPdf Library for .NET - Use media types with Html to Pdf Converter">Media Types</a></li>
                        <li><a href="~/HtmlToPdfConverterLinks" title="SelectPdf Library for .NET - Pdf Internal and External Links - Html to Pdf Converter">Internal and External Links</a></li>
                        <li><a href="~/CurrentWebPageToPdf" title="SelectPdf Library for .NET - Convert Current WebPage to Pdf">Current WebPage to Pdf in Asp.Net</a></li>
                        <li><a href="~/ConvertAndEmail" title="SelectPdf Library for .NET - Convert WebPage to Pdf and Email as Attachment">Convert to Pdf and Email as Attachment</a></li>
                    </ul>
                </aside>

            </div>
            <!-- #secondary -->

        </div>
        <!-- #main .wrapper -->
        <footer id="colophon" role="contentinfo">
            <div class="site-info">
                &copy; SelectPdf - <a title="Contact us" href="http://selectpdf.com/contact">Contact us</a> | <a title="Blog" href="http://selectpdf.com/blog">Blog</a> | <a href="http://selectpdf.com/pdf-library-for-net/">PDF Library for .NET</a>
            </div>
            <!-- .site-info -->
        </footer>
        <!-- #colophon -->
    </div>
    <!-- #page -->
    <script src="~/files/navigation.js" type="text/javascript"></script>
</body>
</html>
