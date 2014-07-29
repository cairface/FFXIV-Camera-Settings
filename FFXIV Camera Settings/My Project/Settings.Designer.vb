﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0.78")>  _
        Public Property FOV() As Decimal
            Get
                Return CType(Me("FOV"),Decimal)
            End Get
            Set
                Me("FOV") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("50.0")>  _
        Public Property ZoomMax() As Decimal
            Get
                Return CType(Me("ZoomMax"),Decimal)
            End Get
            Set
                Me("ZoomMax") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SetZoomCurrent() As Boolean
            Get
                Return CType(Me("SetZoomCurrent"),Boolean)
            End Get
            Set
                Me("SetZoomCurrent") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<ArrayOfInt xmlns:xsi=""http://www.w3.org" & _
            "/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  <int>" & _
            "15837456</int>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</ArrayOfInt>")> _
        Public Property CameraAddress() As Integer()
            Get
                Return CType(Me("CameraAddress"), Integer())
            End Get
            Set(value As Integer())
                Me("CameraAddress") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("232")> _
        Public Property ZoomCurrentOffset() As Integer
            Get
                Return CType(Me("ZoomCurrentOffset"), Integer)
            End Get
            Set(value As Integer)
                Me("ZoomCurrentOffset") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("240")> _
        Public Property ZoomMaxOffset() As Integer
            Get
                Return CType(Me("ZoomMaxOffset"), Integer)
            End Get
            Set(value As Integer)
                Me("ZoomMaxOffset") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("244")> _
        Public Property FovCurrentOffset() As Integer
            Get
                Return CType(Me("FovCurrentOffset"), Integer)
            End Get
            Set(value As Integer)
                Me("FovCurrentOffset") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("252")> _
        Public Property FovMaxOffset() As Integer
            Get
                Return CType(Me("FovMaxOffset"), Integer)
            End Get
            Set(value As Integer)
                Me("FovMaxOffset") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.FFXIV_Camera_Settings.My.MySettings
            Get
                Return Global.FFXIV_Camera_Settings.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
