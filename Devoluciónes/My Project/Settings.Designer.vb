﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funcionalidad para autoguardar de My.Settings"
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
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("UNIVSYS")>  _
        Public ReadOnly Property CNSGestion_Servidor() As String
            Get
                Return CType(Me("CNSGestion_Servidor"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SQLEXPRESS")>  _
        Public Property CNSGestion_Instancia() As String
            Get
                Return CType(Me("CNSGestion_Instancia"),String)
            End Get
            Set
                Me("CNSGestion_Instancia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("GI_DN")>  _
        Public Property CNSGestion_BD() As String
            Get
                Return CType(Me("CNSGestion_BD"),String)
            End Get
            Set
                Me("CNSGestion_BD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("sa")>  _
        Public Property CNSGestion_Usuario() As String
            Get
                Return CType(Me("CNSGestion_Usuario"),String)
            End Get
            Set
                Me("CNSGestion_Usuario") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ts2008")>  _
        Public Property CNSGestion_Contrasenia() As String
            Get
                Return CType(Me("CNSGestion_Contrasenia"),String)
            End Get
            Set
                Me("CNSGestion_Contrasenia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDragon_Servidor() As String
            Get
                Return CType(Me("CNSDragon_Servidor"),String)
            End Get
            Set
                Me("CNSDragon_Servidor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDragon_Instancia() As String
            Get
                Return CType(Me("CNSDragon_Instancia"),String)
            End Get
            Set
                Me("CNSDragon_Instancia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDragon_BD() As String
            Get
                Return CType(Me("CNSDragon_BD"),String)
            End Get
            Set
                Me("CNSDragon_BD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDragon_Usuario() As String
            Get
                Return CType(Me("CNSDragon_Usuario"),String)
            End Get
            Set
                Me("CNSDragon_Usuario") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDragon_Contrasenia() As String
            Get
                Return CType(Me("CNSDragon_Contrasenia"),String)
            End Get
            Set
                Me("CNSDragon_Contrasenia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSLince_BDArt() As String
            Get
                Return CType(Me("CNSLince_BDArt"),String)
            End Get
            Set
                Me("CNSLince_BDArt") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSLince_BDMov() As String
            Get
                Return CType(Me("CNSLince_BDMov"),String)
            End Get
            Set
                Me("CNSLince_BDMov") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSHexagono_Servidor() As String
            Get
                Return CType(Me("CNSHexagono_Servidor"),String)
            End Get
            Set
                Me("CNSHexagono_Servidor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSHexagono_Instancia() As String
            Get
                Return CType(Me("CNSHexagono_Instancia"),String)
            End Get
            Set
                Me("CNSHexagono_Instancia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSHexagono_BD() As String
            Get
                Return CType(Me("CNSHexagono_BD"),String)
            End Get
            Set
                Me("CNSHexagono_BD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSHexagono_Usuario() As String
            Get
                Return CType(Me("CNSHexagono_Usuario"),String)
            End Get
            Set
                Me("CNSHexagono_Usuario") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSHexagono_Contrasenia() As String
            Get
                Return CType(Me("CNSHexagono_Contrasenia"),String)
            End Get
            Set
                Me("CNSHexagono_Contrasenia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDevoluciones_Servidor() As String
            Get
                Return CType(Me("CNSDevoluciones_Servidor"),String)
            End Get
            Set
                Me("CNSDevoluciones_Servidor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDevoluciones_Instancia() As String
            Get
                Return CType(Me("CNSDevoluciones_Instancia"),String)
            End Get
            Set
                Me("CNSDevoluciones_Instancia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDevoluciones_BD() As String
            Get
                Return CType(Me("CNSDevoluciones_BD"),String)
            End Get
            Set
                Me("CNSDevoluciones_BD") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDevoluciones_Usuario() As String
            Get
                Return CType(Me("CNSDevoluciones_Usuario"),String)
            End Get
            Set
                Me("CNSDevoluciones_Usuario") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CNSDevoluciones_Contrasenia() As String
            Get
                Return CType(Me("CNSDevoluciones_Contrasenia"),String)
            End Get
            Set
                Me("CNSDevoluciones_Contrasenia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300000")>  _
        Public Property IntervaloBusqueda() As ULong
            Get
                Return CType(Me("IntervaloBusqueda"),ULong)
            End Get
            Set
                Me("IntervaloBusqueda") = value
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
        Friend ReadOnly Property Settings() As Global.Devoluciónes.My.MySettings
            Get
                Return Global.Devoluciónes.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
