﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Этот код был создан построителем кодированных тестов ИП.
//      Версия: 14.0.0.0
//
//      Изменения, внесенные в этот файл, могут привести к неправильной работе кода и будут
//      утрачены при повторном формировании кода.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UITests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Используйте "RecordedMethod1Params" для передачи параметров в этот метод.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UIForm1Window.UIItemWindow.UIItemEdit;
            #endregion

            // Запуск "%USERPROFILE%\Desktop\CustomComponentExample.exe"
            ApplicationUnderTest uIForm1Window = ApplicationUnderTest.Launch(this.RecordedMethod1Params.UIForm1WindowExePath, this.RecordedMethod1Params.UIForm1WindowAlternateExePath);

            // Ввести "123" в надпись
            uIItemEdit.Text = this.RecordedMethod1Params.UIItemEditText;
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIForm1Window UIForm1Window
        {
            get
            {
                if ((this.mUIForm1Window == null))
                {
                    this.mUIForm1Window = new UIForm1Window();
                }
                return this.mUIForm1Window;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIForm1Window mUIForm1Window;
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "RecordedMethod1"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Запуск "%USERPROFILE%\Desktop\CustomComponentExample.exe"
        /// </summary>
        public string UIForm1WindowExePath = "C:\\Users\\LocalUser\\Desktop\\CustomComponentExample.exe";
        
        /// <summary>
        /// Запуск "%USERPROFILE%\Desktop\CustomComponentExample.exe"
        /// </summary>
        public string UIForm1WindowAlternateExePath = "%USERPROFILE%\\Desktop\\CustomComponentExample.exe";
        
        /// <summary>
        /// Ввести "123" в надпись
        /// </summary>
        public string UIItemEditText = "123";
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UIForm1Window : WinWindow
    {
        
        public UIForm1Window()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Form1";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "3";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Условия поиска
                    this.mUIItemEdit.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
}
