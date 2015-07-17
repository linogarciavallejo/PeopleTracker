﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace peopleService.CodedUITests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// ClickAbout - Test Case 30
        /// </summary>
        public void ClickAbout()
        {
            #region Variable Declarations
            HtmlHyperlink uIAboutHyperlink = this.UIHomeInternetExplorerWindow.UIHomeDocument2.UIAboutHyperlink;
            #endregion

            // Click 'About' link
            Mouse.Click(uIAboutHyperlink, new Point(33, 25));
        }
        
        /// <summary>
        /// StartIE - Test Case 30 - Use 'StartIEParams' to pass parameters into this method.
        /// </summary>
        public void StartIE()
        {

            // Go to web page 'http://dlb-chefnode.cloudapp.net/peopleTracker/' using new browser instance
            BrowserWindow dlbchefnodecloudappnetBrowser = BrowserWindow.Launch(new System.Uri(this.StartIEParams.Url));
        }
        
        /// <summary>
        /// VerifyCopyright - Use 'VerifyCopyrightExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyCopyright()
        {
            #region Variable Declarations
            HtmlDiv uIFabrikamFiberc2014Pane = this.UIAboutInternetExploreWindow.UIAboutDocument.UIFabrikamFiberc2014Pane;
            #endregion

            // Verify that the 'InnerText' property of 'Fabrikam Fiber (c) 2014.' pane equals 'Fabrikam Fiber (c) 2014.'
            Assert.AreEqual(this.VerifyCopyrightExpectedValues.UIFabrikamFiberc2014PaneInnerText, uIFabrikamFiberc2014Pane.InnerText);
        }
        
        #region Properties
        public virtual StartIEParams StartIEParams
        {
            get
            {
                if ((this.mStartIEParams == null))
                {
                    this.mStartIEParams = new StartIEParams();
                }
                return this.mStartIEParams;
            }
        }
        
        public virtual VerifyCopyrightExpectedValues VerifyCopyrightExpectedValues
        {
            get
            {
                if ((this.mVerifyCopyrightExpectedValues == null))
                {
                    this.mVerifyCopyrightExpectedValues = new VerifyCopyrightExpectedValues();
                }
                return this.mVerifyCopyrightExpectedValues;
            }
        }
        
        public UIWelcometoTeamFoundatWindow UIWelcometoTeamFoundatWindow
        {
            get
            {
                if ((this.mUIWelcometoTeamFoundatWindow == null))
                {
                    this.mUIWelcometoTeamFoundatWindow = new UIWelcometoTeamFoundatWindow();
                }
                return this.mUIWelcometoTeamFoundatWindow;
            }
        }
        
        public UIHomeInternetExplorerWindow UIHomeInternetExplorerWindow
        {
            get
            {
                if ((this.mUIHomeInternetExplorerWindow == null))
                {
                    this.mUIHomeInternetExplorerWindow = new UIHomeInternetExplorerWindow();
                }
                return this.mUIHomeInternetExplorerWindow;
            }
        }
        
        public UIAboutInternetExploreWindow UIAboutInternetExploreWindow
        {
            get
            {
                if ((this.mUIAboutInternetExploreWindow == null))
                {
                    this.mUIAboutInternetExploreWindow = new UIAboutInternetExploreWindow();
                }
                return this.mUIAboutInternetExploreWindow;
            }
        }
        #endregion
        
        #region Fields
        private StartIEParams mStartIEParams;
        
        private VerifyCopyrightExpectedValues mVerifyCopyrightExpectedValues;
        
        private UIWelcometoTeamFoundatWindow mUIWelcometoTeamFoundatWindow;
        
        private UIHomeInternetExplorerWindow mUIHomeInternetExplorerWindow;
        
        private UIAboutInternetExploreWindow mUIAboutInternetExploreWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'StartIE'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class StartIEParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://dlb-chefnode.cloudapp.net/peopleTracker/' using new browser instance
        /// </summary>
        public string Url = "http://dlb-chefnode.cloudapp.net/peopleTracker/";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyCopyright'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class VerifyCopyrightExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Fabrikam Fiber (c) 2014.' pane equals 'Fabrikam Fiber (c) 2014.'
        /// </summary>
        public string UIFabrikamFiberc2014PaneInnerText = "Fabrikam Fiber (c) 2014.";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIWelcometoTeamFoundatWindow : BrowserWindow
    {
        
        public UIWelcometoTeamFoundatWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Welcome to Team Foundation Server - Microsoft Team Foundation Server";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Welcome to Team Foundation Server - Microsoft Team Foundation Server");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIFavoritesBarToolBar UIFavoritesBarToolBar
        {
            get
            {
                if ((this.mUIFavoritesBarToolBar == null))
                {
                    this.mUIFavoritesBarToolBar = new UIFavoritesBarToolBar(this);
                }
                return this.mUIFavoritesBarToolBar;
            }
        }
        #endregion
        
        #region Fields
        private UIFavoritesBarToolBar mUIFavoritesBarToolBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIFavoritesBarToolBar : WinToolBar
    {
        
        public UIFavoritesBarToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinToolBar.PropertyNames.Name] = "Favorites Bar";
            this.WindowTitles.Add("Welcome to Team Foundation Server - Microsoft Team Foundation Server");
            #endregion
        }
        
        #region Properties
        public WinButton UIQAButton
        {
            get
            {
                if ((this.mUIQAButton == null))
                {
                    this.mUIQAButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIQAButton.SearchProperties[WinButton.PropertyNames.Name] = "QA";
                    this.mUIQAButton.WindowTitles.Add("Welcome to Team Foundation Server - Microsoft Team Foundation Server");
                    #endregion
                }
                return this.mUIQAButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIQAButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIHomeInternetExplorerWindow : BrowserWindow
    {
        
        public UIHomeInternetExplorerWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Home";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomeDocument UIHomeDocument
        {
            get
            {
                if ((this.mUIHomeDocument == null))
                {
                    this.mUIHomeDocument = new UIHomeDocument(this);
                }
                return this.mUIHomeDocument;
            }
        }
        
        public UIHomeDocument1 UIHomeDocument1
        {
            get
            {
                if ((this.mUIHomeDocument1 == null))
                {
                    this.mUIHomeDocument1 = new UIHomeDocument1(this);
                }
                return this.mUIHomeDocument1;
            }
        }
        
        public UIHomeDocument2 UIHomeDocument2
        {
            get
            {
                if ((this.mUIHomeDocument2 == null))
                {
                    this.mUIHomeDocument2 = new UIHomeDocument2(this);
                }
                return this.mUIHomeDocument2;
            }
        }
        #endregion
        
        #region Fields
        private UIHomeDocument mUIHomeDocument;
        
        private UIHomeDocument1 mUIHomeDocument1;
        
        private UIHomeDocument2 mUIHomeDocument2;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIHomeDocument : HtmlDocument
    {
        
        public UIHomeDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/peopleTracker/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:9090/peopleTracker/";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIAboutHyperlink
        {
            get
            {
                if ((this.mUIAboutHyperlink == null))
                {
                    this.mUIAboutHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "About";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/peopleTracker/about";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:9090/peopleTracker/about";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/peopleTracker/about\"";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIAboutHyperlink.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUIAboutHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIAboutHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIHomeDocument1 : HtmlDocument
    {
        
        public UIHomeDocument1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/peopleTracker/about";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:9090/peopleTracker/about";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIItemCustom.SearchProperties["TagName"] = "P";
                    this.mUIItemCustom.SearchProperties["Id"] = null;
                    this.mUIItemCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIItemCustom.FilterProperties["Class"] = null;
                    this.mUIItemCustom.FilterProperties["ControlDefinition"] = null;
                    this.mUIItemCustom.FilterProperties["TagInstance"] = "1";
                    this.mUIItemCustom.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUIItemCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIItemCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIHomeDocument2 : HtmlDocument
    {
        
        public UIHomeDocument2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/peopleTracker/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://dlb-chefnode.cloudapp.net/peopleTracker/";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIAboutHyperlink
        {
            get
            {
                if ((this.mUIAboutHyperlink == null))
                {
                    this.mUIAboutHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIAboutHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "About";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/peopleTracker/about";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://dlb-chefnode.cloudapp.net/peopleTracker/about";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/peopleTracker/about\"";
                    this.mUIAboutHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIAboutHyperlink.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUIAboutHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIAboutHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIAboutInternetExploreWindow : BrowserWindow
    {
        
        public UIAboutInternetExploreWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "About";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("About");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAboutDocument UIAboutDocument
        {
            get
            {
                if ((this.mUIAboutDocument == null))
                {
                    this.mUIAboutDocument = new UIAboutDocument(this);
                }
                return this.mUIAboutDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAboutDocument mUIAboutDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.22609.0")]
    public class UIAboutDocument : HtmlDocument
    {
        
        public UIAboutDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "About";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/peopleTracker/about";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://dlb-chefnode.cloudapp.net/peopleTracker/about";
            this.WindowTitles.Add("About");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIFabrikamFiberc2014Pane
        {
            get
            {
                if ((this.mUIFabrikamFiberc2014Pane == null))
                {
                    this.mUIFabrikamFiberc2014Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIFabrikamFiberc2014Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = "messageParagraph";
                    this.mUIFabrikamFiberc2014Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIFabrikamFiberc2014Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Fabrikam Fiber (c) 2014.";
                    this.mUIFabrikamFiberc2014Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIFabrikamFiberc2014Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "message";
                    this.mUIFabrikamFiberc2014Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"message\" id=\"messageParagraph\"";
                    this.mUIFabrikamFiberc2014Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "6";
                    this.mUIFabrikamFiberc2014Pane.WindowTitles.Add("About");
                    #endregion
                }
                return this.mUIFabrikamFiberc2014Pane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIFabrikamFiberc2014Pane;
        #endregion
    }
}