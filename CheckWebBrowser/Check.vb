Imports Microsoft.Win32

Public Class Check

    Public Shared Function IsChromeInstalled() As Boolean
        Dim keyPath As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe"
        Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(keyPath)
            Return regKey IsNot Nothing
        End Using
    End Function

    Public Shared Function IsEdgeInstalled() As Boolean
        Dim keyPath As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\msedge.exe"
        Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(keyPath)
            Return regKey IsNot Nothing
        End Using
    End Function

    Public Shared Function IsFirefoxInstalled() As Boolean
        Dim keyPath As String = "SOFTWARE\Mozilla\Mozilla Firefox"
        Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(keyPath)
            Return regKey IsNot Nothing
        End Using
    End Function

    Public Shared Function IsSafariInstalled() As Boolean
        Dim keyPath As String = "SOFTWARE\Apple Computer, Inc.\Safari"
        Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(keyPath)
            Return regKey IsNot Nothing
        End Using
    End Function

    Public Shared Function IsIEInstalled() As Boolean
        Dim keyPath As String = "SOFTWARE\Microsoft\Internet Explorer"
        Using regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(keyPath)
            Return regKey IsNot Nothing
        End Using
    End Function

End Class
